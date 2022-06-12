using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace form_disposal
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
            // https://stackoverflow.com/a/7483238/5438626
            ControlBox = false;
            Text = String.Empty;
        }
        public void SetProgress(int i)
        {
            if (IsHandleCreated)    // Prevent potential race condition
            {
                Invoke((MethodInvoker)delegate { progressBar1.Value = i; });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Debug.WriteLine("Progress dialog is now Disposing");
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    }
}
