namespace SvetanFlickrApp
{
    partial class UpdateForm
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
            this.NewTitle = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.OldTitle = new System.Windows.Forms.Label();
            this.GetPhotoButton = new System.Windows.Forms.Button();
            this.UpdatePhotoButton = new System.Windows.Forms.Button();
            this.PhotoId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Size = new System.Drawing.Size(272, 253);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Title:";
            // 
            // NewTitle
            // 
            this.NewTitle.Location = new System.Drawing.Point(355, 85);
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.Size = new System.Drawing.Size(163, 20);
            this.NewTitle.TabIndex = 14;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(334, 131);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(214, 185);
            this.webBrowser1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Old Title:";
            // 
            // OldTitle
            // 
            this.OldTitle.AutoSize = true;
            this.OldTitle.Location = new System.Drawing.Point(352, 58);
            this.OldTitle.Name = "OldTitle";
            this.OldTitle.Size = new System.Drawing.Size(0, 13);
            this.OldTitle.TabIndex = 17;
            // 
            // GetPhotoButton
            // 
            this.GetPhotoButton.Location = new System.Drawing.Point(524, 48);
            this.GetPhotoButton.Name = "GetPhotoButton";
            this.GetPhotoButton.Size = new System.Drawing.Size(86, 23);
            this.GetPhotoButton.TabIndex = 18;
            this.GetPhotoButton.Text = "Get Photo";
            this.GetPhotoButton.UseVisualStyleBackColor = true;
            this.GetPhotoButton.Click += new System.EventHandler(this.GetPhotoButton_Click);
            // 
            // UpdatePhotoButton
            // 
            this.UpdatePhotoButton.Location = new System.Drawing.Point(524, 82);
            this.UpdatePhotoButton.Name = "UpdatePhotoButton";
            this.UpdatePhotoButton.Size = new System.Drawing.Size(86, 23);
            this.UpdatePhotoButton.TabIndex = 19;
            this.UpdatePhotoButton.Text = "Update Photo";
            this.UpdatePhotoButton.UseVisualStyleBackColor = true;
            this.UpdatePhotoButton.Click += new System.EventHandler(this.UpdatePhotoButton_Click);
            // 
            // PhotoId
            // 
            this.PhotoId.AutoSize = true;
            this.PhotoId.Location = new System.Drawing.Point(575, 129);
            this.PhotoId.Name = "PhotoId";
            this.PhotoId.Size = new System.Drawing.Size(35, 13);
            this.PhotoId.TabIndex = 20;
            this.PhotoId.Text = "label6";
            this.PhotoId.Visible = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.PhotoId);
            this.Controls.Add(this.UpdatePhotoButton);
            this.Controls.Add(this.GetPhotoButton);
            this.Controls.Add(this.OldTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.NewTitle);
            this.Controls.Add(this.label4);
            this.Name = "UpdateForm";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.NewTitle, 0);
            this.Controls.SetChildIndex(this.webBrowser1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.OldTitle, 0);
            this.Controls.SetChildIndex(this.GetPhotoButton, 0);
            this.Controls.SetChildIndex(this.SharedSecret, 0);
            this.Controls.SetChildIndex(this.AuthToken, 0);
            this.Controls.SetChildIndex(this.ApiKey, 0);
            this.Controls.SetChildIndex(this.OutputTextbox, 0);
            this.Controls.SetChildIndex(this.UpdatePhotoButton, 0);
            this.Controls.SetChildIndex(this.PhotoId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewTitle;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label OldTitle;
        private System.Windows.Forms.Button GetPhotoButton;
        private System.Windows.Forms.Button UpdatePhotoButton;
        private System.Windows.Forms.Label PhotoId;
    }
}
