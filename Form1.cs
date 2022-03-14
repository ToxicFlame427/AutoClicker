using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        //private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        //private const int MOUSEEVENTF_RIGHTUP = 0x10;

        System.Timers.Timer timer = new System.Timers.Timer();
        Thread keyboardThread;

        private int minutesValue;
        private int secondsValue;
        private int milisecondsValue;
        private int calculatedValue;

        public Form1()
        {
            InitializeComponent();

            //Start the thread searching for keyboard presses
            keyboardThread = new Thread(KeyboardListener);
            keyboardThread.SetApartmentState(ApartmentState.STA);
            keyboardThread.Start();

            //Add TextChanged listeners becasue by default, NumericalUpDowns do not have this event
            minutesBox.TextChanged += textChangedInBox;
            secondsBox.TextChanged += textChangedInBox;
            milisecondsBox.TextChanged += textChangedInBox;
        }

        //Repeat this finction periodically to check if a new key was pressed in the background
        private void KeyboardListener(){
            while (true) {
                Thread.Sleep(40);
                //If F1 is pressed in background, stop autoclicking
                if ((Keyboard.GetKeyStates(Key.F1) & KeyStates.Down) > 0)
                {
                    //Check if any values in the form are empty
                    if (minutesValue != 0 || secondsValue != 0 || milisecondsValue != 0)
                    {
                        startAutoClick();
                    }
                    else
                    {
                        MessageBox.Show("There must be an interval value to begin the autoclicker.");

                        //Restart the thread becasue it will suspend after the messagebox (unknown why this happens)
                        keyboardThread = new Thread(KeyboardListener);
                        keyboardThread.SetApartmentState(ApartmentState.STA);
                        keyboardThread.Start();
                    }
                }
                //If F2 is pressed in background, stop autoclicking
                else if ((Keyboard.GetKeyStates(Key.F2) & KeyStates.Down) > 0)
                {
                    stopAutoClick();
                }
            }
        }

        //Function for virtually clicking the mouse
        private void clickMouse(object source, EventArgs e)
        {
            SetCursorPos(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        //Run when the start button is clicked
        private void startButton_Click(object sender, EventArgs e)
        {
            //Check if a value other than 0 exists
            if (minutesValue != 0 || secondsValue != 0 || milisecondsValue != 0)
            {
                startAutoClick();
            }
            else
            {
                MessageBox.Show("There must be an interval value to begin the autoclicker.");
            }
        }

        //Run when the stop button is clicked
        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            stopAutoClick();
        }

        //Stops the autoclick from occurring
        private void stopAutoClick()
        {
            //Must invoke on the UIThread due to using another custom thread
            Invoke((MethodInvoker)delegate {
                //Enable and disable buttons
                startButton.Enabled = true;
                stopButton.Enabled = false;

                //Enable the input boxes
                minutesBox.Enabled = true;
                secondsBox.Enabled = true;
                milisecondsBox.Enabled = true;
            });

            //Stop the timer from doing anything
            timer.Enabled = false;
            timer.Stop();
        }

        private void startAutoClick()
        {
            Invoke((MethodInvoker)delegate
            {
                //Enable and disable buttons
                startButton.Enabled = false;
                stopButton.Enabled = true;

                //Disable the input boxes
                minutesBox.Enabled = false;
                secondsBox.Enabled = false;
                milisecondsBox.Enabled = false;
            });

            //Reset all timer values
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += clickMouse;
            timer.Interval = calculatedValue;
            timer.Start();
        }

        private void textChangedInBox(object sender, EventArgs e)
        {
            //Update the integer values with the text values in the textbox
            //No need to check data type, numerical up down already handles number inpout only
            minutesValue = int.Parse(minutesBox.Value.ToString());
            secondsValue = int.Parse(secondsBox.Value.ToString());
            milisecondsValue = int.Parse(milisecondsBox.Value.ToString());

            //Create the calculated value for the timer interval
            calculatedValue = milisecondsValue + (secondsValue * 1000) + (minutesValue * 10000);
        }

        //Just opens the help window when the help icon is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HelpForm helpform = new HelpForm();
            helpform.Show();
        }

        private void exitProgram(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
