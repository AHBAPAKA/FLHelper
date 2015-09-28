namespace SvetanFlickrApp
{
    partial class UploadForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.TextBox();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.UploadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Filename";
            // 
            // Filename
            // 
            this.Filename.Location = new System.Drawing.Point(345, 33);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(208, 20);
            this.Filename.TabIndex = 13;
            // 
            // FindFileButton
            // 
            this.FindFileButton.Location = new System.Drawing.Point(562, 33);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(24, 20);
            this.FindFileButton.TabIndex = 14;
            this.FindFileButton.Text = "..";
            this.FindFileButton.UseVisualStyleBackColor = true;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(346, 65);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(85, 23);
            this.UploadFileButton.TabIndex = 15;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseVisualStyleBackColor = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.FindFileButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Filename);
            this.Name = "UploadForm";
            this.Controls.SetChildIndex(this.Filename, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.FindFileButton, 0);
            this.Controls.SetChildIndex(this.UploadFileButton, 0);
            this.Controls.SetChildIndex(this.AuthToken, 0);
            this.Controls.SetChildIndex(this.ApiKey, 0);
            this.Controls.SetChildIndex(this.OutputTextbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Filename;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.Button UploadFileButton;
    }
}
