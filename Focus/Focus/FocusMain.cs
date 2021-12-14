using System;
using System.Resources;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace Focus
{
    public partial class FocusMain : Form
    {
        private TextProcess CurrentTextProcess;
        private string StrCurrentProcess = "";
        private string StrTodayProcess = "";
        private string StrStat = "";
        private int StatTotalTime = 0;
        private int StatCount = 0;
        private TaskbarManager TaskbarProcess = TaskbarManager.Instance;

        public FocusMain()
        {
            InitializeComponent();
        }

        private void FocusMain_Load(object sender, EventArgs e)
        {
            //load data
            LoadData();
            //init form
            LabStat.Text = StrStat;
            LabCurrentProcess.Text = StrCurrentProcess;
            LabTodayProcess.Text = StrTodayProcess;
            Start.Enabled = true;
            Pause.Enabled = false;
            this.Notify.Visible = true;
            CurrentTextProcess = new TextProcess(30*60);    //default 30 min
        }

        private void LoadData()
        {
            
        }

        private void SaveData()
        {
            //save data to resx
            using (ResXResourceWriter rw = new ResXResourceWriter("data.resx"))
            {
                rw.AddResource("StrTodayProcess", StrTodayProcess);
                rw.AddResource("StrStat", StrStat);
                rw.AddResource("StatTotalTime", Convert.ToString(StatTotalTime));
                rw.AddResource("StatCount", Convert.ToString(StatCount));
                rw.Close();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //init taskbar process
            TaskbarProcess.SetProgressState(TaskbarProgressBarState.NoProgress);
            StartProcess();
        }

        private void StartProcess()
        {
            //start tic
            tic.Enabled = true;
            Start.Enabled = false;
            Pause.Enabled = true;
            TaskbarProcess.SetProgressState(TaskbarProgressBarState.Normal);
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            PauseProcess();
            //reflush icon
            UpdateNotifyIcon();
            UpdateTaskbarProcess();
        }

        private void PauseProcess()
        {
            //pause tic
            tic.Enabled = false;
            Start.Enabled = true;
            Pause.Enabled = false;

            //add current process to today process
            StrTodayProcess = CurrentTextProcess.GetCurrentProcess()
                + Sec2MinSecStr(CurrentTextProcess.GetCurrentTime())
                + '\n'
                + StrTodayProcess;
            LabTodayProcess.Text = StrTodayProcess;

            StatTotalTime = StatTotalTime + CurrentTextProcess.GetCurrentTime();
            StrStat = "TotalTime:"
                + Sec2MinSecStr(StatTotalTime)
                + "    "
                + "Complete："
                + Convert.ToString(StatCount);
            LabStat.Text = StrStat;
            
            //clear current process
            CurrentTextProcess.ResetCurrentProcess();

            StrCurrentProcess = CurrentTextProcess.GetCurrentProcess()
                + Sec2MinSecStr(CurrentTextProcess.GetCurrentTime());
            LabCurrentProcess.Text = StrCurrentProcess;
        }

        private void tic_Tick(object sender, EventArgs e)
        {
            //pass 1 sec
            CurrentTextProcess.CurrentProcessClick();

            StrCurrentProcess = CurrentTextProcess.GetCurrentProcess() 
                + Sec2MinSecStr(CurrentTextProcess.GetCurrentTime());
            LabCurrentProcess.Text = StrCurrentProcess;
            UpdateNotifyIcon();
            UpdateTaskbarProcess();

            if (CurrentTextProcess.IsFull())
            {
                //1 cycle
                //call pause
                StatCount++;
                PauseProcess();

                //red icon
                SetFinalIcon();
                SetFinalTaskbarProcess();
            }
        }

        private void FocusMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                return;
            }
        }

        private void Notify_DoubleClick(object sender, EventArgs e)
        {
            //show dialog
            if (this.Visible)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveData();

            this.Notify.Visible = false;
            this.Close();
            this.Dispose();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        private void UpdateNotifyIcon()
        {
            //get current process
            int c = CurrentTextProcess.GetCurrentTime();
            int t = CurrentTextProcess.GetTotalTime();
            double i = Convert.ToDouble(t) / 12;        //only 12 icons
            int index = Convert.ToInt32(c / i);
            switch (index)
            {
                case 0:
                    Notify.Icon = icons._127; break;
                case 1:
                    Notify.Icon = icons._128; break;
                case 2:
                    Notify.Icon = icons._129; break;
                case 3:
                    Notify.Icon = icons._130; break;
                case 4:
                    Notify.Icon = icons._131; break;
                case 5:
                    Notify.Icon = icons._132; break;
                case 6:
                    Notify.Icon = icons._133; break;
                case 7:
                    Notify.Icon = icons._134; break;
                case 8:
                    Notify.Icon = icons._135; break;
                case 9:
                    Notify.Icon = icons._136; break;
                case 10:
                    Notify.Icon = icons._137; break;
                case 11:
                case 12:
                    Notify.Icon = icons._138; break;
                default:
                    break;
            }
        }

        private void SetFinalIcon()
        {
            Notify.Icon = icons._000;
        }

        private void UpdateTaskbarProcess()
        {
            //get current process
            int c = CurrentTextProcess.GetCurrentTime();
            int t = CurrentTextProcess.GetTotalTime();
            
            TaskbarProcess.SetProgressValue(c, t);
        }

        private void SetFinalTaskbarProcess()
        {
            TaskbarProcess.SetProgressState(TaskbarProgressBarState.Paused);
        }

        private string Sec2MinSecStr(int InputSec)
        {
            int Min = InputSec / 60;
            int Sec = InputSec % 60;
            string MinStr = Min.ToString("00");
            string SecStr = Sec.ToString("00");

            return MinStr + ":" + SecStr;
        }
    }
}
