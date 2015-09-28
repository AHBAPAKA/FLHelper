namespace SvetanFlickrApp
{
    partial class ExampleForm1
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
            this.SimpleSearchButton1 = new System.Windows.Forms.Button();
            this.FindUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SimpleSearchButton1
            // 
            this.SimpleSearchButton1.Location = new System.Drawing.Point(15, 43);
            this.SimpleSearchButton1.Name = "SimpleSearchButton1";
            this.SimpleSearchButton1.Size = new System.Drawing.Size(98, 23);
            this.SimpleSearchButton1.TabIndex = 3;
            this.SimpleSearchButton1.Text = "Simple Search 1";
            this.SimpleSearchButton1.UseVisualStyleBackColor = true;
            this.SimpleSearchButton1.Click += new System.EventHandler(this.SimpleSearchButton1_Click);
            // 
            // FindUserButton
            // 
            this.FindUserButton.Location = new System.Drawing.Point(201, 43);
            this.FindUserButton.Name = "FindUserButton";
            this.FindUserButton.Size = new System.Drawing.Size(98, 23);
            this.FindUserButton.TabIndex = 5;
            this.FindUserButton.Text = "Find User";
            this.FindUserButton.UseVisualStyleBackColor = true;
            this.FindUserButton.Click += new System.EventHandler(this.FindUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(377, 45);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 359);
            this.Controls.Add(this.SimpleSearchButton1);
            this.Controls.Add(this.FindUserButton);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Username, 0);
            this.Controls.SetChildIndex(this.FindUserButton, 0);
            this.Controls.SetChildIndex(this.SimpleSearchButton1, 0);
            this.Controls.SetChildIndex(this.ApiKey, 0);
            this.Controls.SetChildIndex(this.OutputTextbox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SimpleSearchButton1;
        private System.Windows.Forms.Button FindUserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Username;
    }
}

