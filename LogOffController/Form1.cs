using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace LogOffController
{
    public partial class LogOffForm : Form
    {
        private int executionCounter = 0;
        private EXECUTION_STATE lastState = 0;

        [Flags]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        public LogOffForm()
        {
            InitializeComponent();
            StartWorker();
        }

        private void StartWorker()
        {
            Thread.Sleep(500);
            keepAliveWorker.WorkerReportsProgress = true;
            keepAliveWorker.WorkerSupportsCancellation = true;
            keepAliveWorker.RunWorkerAsync();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void keepAliveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (!worker.CancellationPending)
            {
                lastState = SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
                worker.ReportProgress(0, "");
                for (int i = 0; i < 10 && !worker.CancellationPending; Thread.Sleep(1000), i++) ;
            }
        }

        private void keepAliveWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            counter.Text = (++executionCounter).ToString();

            awayValue.Text = lastState.HasFlag(EXECUTION_STATE.ES_AWAYMODE_REQUIRED).ToString();

            continuousValue.Text = lastState.HasFlag(EXECUTION_STATE.ES_CONTINUOUS).ToString();

            displayValue.Text = lastState.HasFlag(EXECUTION_STATE.ES_DISPLAY_REQUIRED).ToString();

            systemValue.Text = lastState.HasFlag(EXECUTION_STATE.ES_SYSTEM_REQUIRED).ToString();
        }

        private void keepAliveWorker_WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }
    }
}
