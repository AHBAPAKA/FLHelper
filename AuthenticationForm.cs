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
    public partial class AuthenticationForm : SvetanFlickrApp.TemplateForm
    {

        string userid = string.Empty;


        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private string Frob;

        private void Step1Button_Click(object sender, EventArgs e)
        {
            try
            {
                Flickr flickr = new Flickr(ApiKey.Text, SharedSecret.Text);

                Frob = flickr.AuthGetFrob();

                OutputTextbox.Text += "Frob = " + Frob + "\r\n";

                string url = flickr.AuthCalcUrl(Frob, AuthLevel.Write);

                OutputTextbox.Text += "Url = " + url + "\r\n";

                System.Diagnostics.Process.Start(url);

                Step1Button.Enabled = false;
                Step2Button.Enabled = true;
                Step3Button.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Step2Button_Click(object sender, EventArgs e)
        {
            Flickr flickr = new Flickr(ApiKey.Text, SharedSecret.Text);

            try
            {
                Auth auth = flickr.AuthGetToken(Frob);
                OutputTextbox.Text += "User Authenticated = " + auth.User.UserName + "\r\n";
                OutputTextbox.Text += "Auth Token = " + auth.Token + "\r\n";

                AuthToken.Text = auth.Token;
            }
            catch (FlickrException ex)
            {
                OutputTextbox.Text += "Authentication failed : " + ex.Message + "\r\n";
            }

            Step1Button.Enabled = true;
            Step2Button.Enabled = false;
            Step3Button.Enabled = false;
        }

        private void Step3Button_Click(object sender, EventArgs e)
        {
            Step1Button.Enabled = true;
            Step2Button.Enabled = false;
            Step3Button.Enabled = false;
        }

        private void AuthenticationForm_Load(object sender, EventArgs e)
        {
            //this.ApiKey.Text  = "63619b74e4361d4857e65b827cab055a";
            //this.SharedSecret.Text = "98200e4436c2ca50";
            userid = Properties.Settings.Default.SvetaUserID; //"42268376@N06";

            userid = Properties.Settings.Default.AnvarUserID;

            this.ApiKey.Text = Properties.Settings.Default.ApiKey;
            this.SharedSecret.Text = Properties.Settings.Default.SharedSecret;
            
        }
    }
}

