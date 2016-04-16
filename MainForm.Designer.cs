namespace SvetanFlickrApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateFormButton = new System.Windows.Forms.Button();
            this.LoadFavoritesSveta = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.LoadFavoritesAnvar = new System.Windows.Forms.Button();
            this.cmdCleanContacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Example Form 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Authentication Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(90, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Upload Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateFormButton
            // 
            this.UpdateFormButton.Location = new System.Drawing.Point(90, 161);
            this.UpdateFormButton.Name = "UpdateFormButton";
            this.UpdateFormButton.Size = new System.Drawing.Size(133, 23);
            this.UpdateFormButton.TabIndex = 3;
            this.UpdateFormButton.Text = "Update Form";
            this.UpdateFormButton.UseVisualStyleBackColor = true;
            this.UpdateFormButton.Click += new System.EventHandler(this.UpdateFormButton_Click);
            // 
            // LoadFavoritesSveta
            // 
            this.LoadFavoritesSveta.AccessibleName = "72157625482901225-e096749a1a4f4565";
            this.LoadFavoritesSveta.Location = new System.Drawing.Point(90, 200);
            this.LoadFavoritesSveta.Name = "LoadFavoritesSveta";
            this.LoadFavoritesSveta.Size = new System.Drawing.Size(133, 23);
            this.LoadFavoritesSveta.TabIndex = 4;
            this.LoadFavoritesSveta.Text = "Cleanup Sveta Favorites";
            this.LoadFavoritesSveta.UseVisualStyleBackColor = true;
            this.LoadFavoritesSveta.Click += new System.EventHandler(this.LoadSvetaFavs_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.Location = new System.Drawing.Point(90, 279);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(133, 23);
            this.btnContacts.TabIndex = 5;
            this.btnContacts.Text = "Fav/Comment Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // LoadFavoritesAnvar
            // 
            this.LoadFavoritesAnvar.AccessibleName = "72157625482901225-e096749a1a4f4565";
            this.LoadFavoritesAnvar.Location = new System.Drawing.Point(90, 239);
            this.LoadFavoritesAnvar.Name = "LoadFavoritesAnvar";
            this.LoadFavoritesAnvar.Size = new System.Drawing.Size(133, 23);
            this.LoadFavoritesAnvar.TabIndex = 6;
            this.LoadFavoritesAnvar.Text = "Cleanup Anvar Favorites";
            this.LoadFavoritesAnvar.UseVisualStyleBackColor = true;
            this.LoadFavoritesAnvar.Click += new System.EventHandler(this.LoadAnvarFavs_Click);
            // 
            // cmdCleanContacts
            // 
            this.cmdCleanContacts.Location = new System.Drawing.Point(90, 319);
            this.cmdCleanContacts.Name = "cmdCleanContacts";
            this.cmdCleanContacts.Size = new System.Drawing.Size(133, 23);
            this.cmdCleanContacts.TabIndex = 7;
            this.cmdCleanContacts.Text = "Manage Contacts";
            this.cmdCleanContacts.UseVisualStyleBackColor = true;
            this.cmdCleanContacts.Click += new System.EventHandler(this.cmdCleanContacts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 379);
            this.Controls.Add(this.cmdCleanContacts);
            this.Controls.Add(this.LoadFavoritesAnvar);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.LoadFavoritesSveta);
            this.Controls.Add(this.UpdateFormButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Svetan Flickr Management App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UpdateFormButton;
        private System.Windows.Forms.Button LoadFavoritesSveta;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button LoadFavoritesAnvar;
        private System.Windows.Forms.Button cmdCleanContacts;
    }
}