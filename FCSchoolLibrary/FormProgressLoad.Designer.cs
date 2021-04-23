
namespace FCSchoolLibrary
{
    partial class FormProgressLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_ProgressLoad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pb_ProgressLoad
            // 
            this.pb_ProgressLoad.Location = new System.Drawing.Point(12, 12);
            this.pb_ProgressLoad.Name = "pb_ProgressLoad";
            this.pb_ProgressLoad.Size = new System.Drawing.Size(244, 23);
            this.pb_ProgressLoad.TabIndex = 0;
            // 
            // FormProgressLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 45);
            this.Controls.Add(this.pb_ProgressLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProgressLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_ProgressLoad;
    }
}