
namespace form_disposal
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModal
            // 
            this.buttonModal.Location = new System.Drawing.Point(31, 47);
            this.buttonModal.Name = "buttonModal";
            this.buttonModal.Size = new System.Drawing.Size(295, 34);
            this.buttonModal.TabIndex = 0;
            this.buttonModal.Text = "Reset Database";
            this.buttonModal.UseVisualStyleBackColor = true;
            this.buttonModal.Click += new System.EventHandler(this.buttonModal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.buttonModal);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        private System.Windows.Forms.Button buttonModal;
    }
}

