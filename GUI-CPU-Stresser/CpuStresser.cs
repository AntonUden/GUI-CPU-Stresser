using System;
using System.Threading;
using System.Windows.Forms;

namespace GUI_CPU_Stresser
{
    public partial class cpustresser : Form
    {
        public bool running = false;

        public cpustresser()
        {
            InitializeComponent();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(running)
            {
                output_status.Text = "Status: Stopped";
                running = false;
                output_bar.Value = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(!running)
            {
                int threads = (int) input_threads.Value;
                running = true;
                ThreadStart ts = new ThreadStart(burn);
                output_bar.Maximum = threads;
                output_status.Text = "Status: starting";
                output_bar.Refresh();
                for (int i = 0; i < threads; i++)
                {
                    output_status.Text = "Status: starting [" + (i + 1) + "/" + threads + "]";
                    output_status.Refresh();
                    Thread t = new Thread(ts);
                    t.Start();
                    output_bar.Value++;
                    output_bar.Refresh();
                }
                output_status.Text = "Status: Running";
                output_bar.Refresh();
            }
        }

        private void burn()
        {
            while (true)
            {
                if (!running) break;
            }
        }

        private void cpustresser_FormClosed(object sender, FormClosedEventArgs e)
        {
            running = false;
            Application.Exit();
        }
    }
}
