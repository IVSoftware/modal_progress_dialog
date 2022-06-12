using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_disposal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonModal_Click(object sender, EventArgs e)
        {
            var modal = new Progress();

            // Start a worker task to perform the
            // SQL updates and reset the application.
            Task.Run(() => 
            {
                for (int i = 0; i < 100; i++)
                {
                    // Block on the thread doing the
                    // updating to simulate the work.
                    Task.Delay(25).Wait();

                    modal.SetProgress(i);
                }
                Invoke((MethodInvoker)delegate{ modal.Dispose(); });
            });

            // The modal dialog will prevent user interaction,
            // effectively locking user out until the update completes.
            modal.ShowDialog();
        }
    }
}
