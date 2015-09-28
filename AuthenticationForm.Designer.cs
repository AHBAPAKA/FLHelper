namespace SvetanFlickrApp
{
    partial class AuthenticationForm
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
            this.Step1Button = new System.Windows.Forms.Button();
            this.Step2Button = new System.Windows.Forms.Button();
            this.Step3Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SharedSecret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthToken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Step1Button
            // 
            this.Step1Button.Location = new System.Drawing.Point(15, 65);
            this.Step1Button.Name = "Step1Button";
            this.Step1Button.Size = new System.Drawing.Size(75, 23);
            this.Step1Button.TabIndex = 5;
            this.Step1Button.Text = "Authenticate";
            this.Step1Button.UseVisualStyleBackColor = true;
            this.Step1Button.Click += new System.EventHandler(this.Step1Button_Click);
            // 
            // Step2Button
            // 
            this.Step2Button.Enabled = false;
            this.Step2Button.Location = new System.Drawing.Point(97, 65);
            this.Step2Button.Name = "Step2Button";
            this.Step2Button.Size = new System.Drawing.Size(75, 23);
            this.Step2Button.TabIndex = 6;
            this.Step2Button.Text = "Continue";
            this.Step2Button.UseVisualStyleBackColor = true;
            this.Step2Button.Click += new System.EventHandler(this.Step2Button_Click);
            // 
            // Step3Button
            // 
            this.Step3Button.Enabled = false;
            this.Step3Button.Location = new System.Drawing.Point(179, 65);
            this.Step3Button.Name = "Step3Button";
            this.Step3Button.Size = new System.Drawing.Size(75, 23);
            this.Step3Button.TabIndex = 7;
            this.Step3Button.Text = "Cancel";
            this.Step3Button.UseVisualStyleBackColor = true;
            this.Step3Button.Click += new System.EventHandler(this.Step3Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your Shared Secret";
            // 
            // SharedSecret
            // 
            this.SharedSecret.Location = new System.Drawing.Point(396, 6);
            this.SharedSecret.Name = "SharedSecret";
            this.SharedSecret.Size = new System.Drawing.Size(106, 20);
            this.SharedSecret.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Auth Token";
            // 
            // AuthToken
            // 
            this.AuthToken.Location = new System.Drawing.Point(88, 33);
            this.AuthToken.Name = "AuthToken";
            this.AuthToken.Size = new System.Drawing.Size(196, 20);
            this.AuthToken.TabIndex = 11;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.Step3Button);
            this.Controls.Add(this.SharedSecret);
            this.Controls.Add(this.AuthToken);
            this.Controls.Add(this.Step2Button);
            this.Controls.Add(this.Step1Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "AuthenticationForm";
            this.Load += new System.EventHandler(this.AuthenticationForm_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Step1Button, 0);
            this.Controls.SetChildIndex(this.Step2Button, 0);
            this.Controls.SetChildIndex(this.AuthToken, 0);
            this.Controls.SetChildIndex(this.SharedSecret, 0);
            this.Controls.SetChildIndex(this.Step3Button, 0);
            this.Controls.SetChildIndex(this.ApiKey, 0);
            this.Controls.SetChildIndex(this.OutputTextbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Step1Button;
        private System.Windows.Forms.Button Step2Button;
        private System.Windows.Forms.Button Step3Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox AuthToken;
        protected System.Windows.Forms.TextBox SharedSecret;
    }
}
