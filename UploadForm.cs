using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlickrNet;


namespace SvetanFlickrApp
{
    public partial class UploadForm : SvetanFlickrApp.AuthenticationForm
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            Filename.Text = openFileDialog1.FileName;
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            Flickr flickr = new Flickr(ApiKey.Text, SharedSecret.Text, AuthToken.Text);

            bool uploadAsPublic = false;

            string title = "Test Upload";
            string description = "Test Description";

            string photoId = flickr.UploadPicture(Filename.Text, title, description, "", uploadAsPublic, false, false);

            OutputTextbox.Text = "Photo uploaded Successfully\r\n";
            OutputTextbox.Text += "Photo Id = " + photoId + "\r\n";
        }
    }
}

