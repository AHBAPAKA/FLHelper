using System;
using System.Windows.Forms;

namespace SvetanFlickrApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExampleForm1 frm = new ExampleForm1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthenticationForm frm = new AuthenticationForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UploadForm frm = new UploadForm();
            frm.Show();
        }

        private void UpdateFormButton_Click(object sender, EventArgs e)
        {
            UpdateForm frm = new UpdateForm();
            frm.Show();
        }

        private void LoadAnvarFavs_Click(object sender, EventArgs e)
        {
            Favorites frm = new Favorites();
            frm.Tag = "Anvar";
            frm.Show();
        }

        private void LoadSvetaFavs_Click(object sender, EventArgs e)
        {
            Favorites frm = new Favorites();
            frm.Tag = "Sveta";
            frm.Show();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            ContactList frm = new ContactList();
            frm.Show();
        }

        private void cmdCleanContacts_Click(object sender, EventArgs e)
        {
            ManageContacts frm = new ManageContacts();
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FlickrFuncs.SetFlickr();
        }
    }
}