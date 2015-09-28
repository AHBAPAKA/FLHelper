using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlickrNet;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Web;
using System.IO;
using System.Net;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Threading;

namespace SvetanFlickrApp
{
    public partial class ManageContacts : Form
    {

        //FlickrFavorite cellfav = null;
        Flickr flickr = null;
        List<ContactCollection> lcont = null;
        ContactCollection contrecent = null;
        ContactCollection LoopCol = null;
        string s_userid = string.Empty;
        string s_authtoken = string.Empty;
        List<string> lastfavs = null;
        PhotoFavoriteCollection FullFavCol = null;
        List<MyManagedContact> mycontuploadlast = null;
        MyFlickrContact updcontact = null;
        Dictionary<string, string> CommentsCol = null;
        int num1;
        List<MyManagedContact> gridsource = null;
        public ManageContacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cache.Responses.Flush();
            btnPolulateContactList.Enabled = false;
            grdFavs.Visible = false;
            this.Text = "Initializing...";
            SetUser();
            this.Text = "Retrieving Last Favs...";
            //lastfavs = MyLast500Favs();
            RetrieveConracts();
            btnPolulateContactList.Enabled = true;
            grdFavs.Visible = true;
        }

        private void RetrieveConracts()
        {

            //flickr = new Flickr(Properties.Settings.Default.ApiKey, Properties.Settings.Default.SharedSecret,
            //    s_authtoken);

            ContactCollection extras = new ContactCollection();

            DateTime dt = DateTime.Now.AddHours(-19);
            // contrecent = flickr.ContactsGetListRecentlyUploaded(dt, "all");
            mycontuploadlast = new List<MyManagedContact>();
            contrecent = new ContactCollection();
            num1 = 1;

            this.Text = "Working on initial collection...";
            for (int i = 1; i < 10; i++)
            {
                //LoopCol = flickr.ActivityUserCommentsAsync()

                LoopCol = flickr.ContactsGetList(s_userid, i, 100);
                if (LoopCol.Count == 0)
                {
                    break;
                }
                else
                {
                    int iloop = 1;

                    foreach (var item in LoopCol)
                    {
                        //TEST 25 Users only
                        if (iloop >25)
                            goto Continue;
                        contrecent.Add(item);
                        iloop++;

                    }
                }
            }

            Continue:

            this.Text = "Processing collection...";

            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = contrecent.Count;
            progressBar1.Step = 1;


            PopulateCustomContactCollection(contrecent);


            IOrderedEnumerable<MyManagedContact> sortedsource=
                from element in mycontuploadlast
                where element.LastUploadDT > DateTime.Now.AddDays(-30)
                orderby element.LastUploadDT descending
                select element;



            var sorted = from element in mycontuploadlast
                         where element.LastUploadDT > DateTime.Now.AddDays(-30)
                         orderby element.LastUploadDT descending
                         select element;

            

            //mycontuploadlast.Sort(delegate(MyFlickrContact p1, MyFlickrContact p2) { return p1.LastPhotoID.CompareTo(p2.LastPhotoID); });
            //this.grdFavs.DataSource = sorted.ToList<MyFlickrContact>();

            BindGrid(sorted.ToList<MyManagedContact>());
            AddComboColumn();

        }

        private List<MyManagedContact> GetEnnumeration(List<MyManagedContact> source)
        {
            List<MyManagedContact> retlist = new List<MyManagedContact>();
            int num = 1;
            foreach (MyManagedContact item in source)
            {
                item.ItemNum = num;
                retlist.Add(item);

                num++;
            }

            return retlist;
        }

        private void BindGrid(List<MyManagedContact> bindingsource)
        {

            this.grdFavs.DataSource = GetEnnumeration(bindingsource);

        }

        private void AddComboColumn()
        {
            DataGridViewComboBoxColumn cmbColumn = new DataGridViewComboBoxColumn();
            cmbColumn.DataSource = new BindingSource(CommentsCol, null);
            cmbColumn.DisplayMember = "Value";
            cmbColumn.ValueMember = "Key";
            this.grdFavs.Columns.Add(cmbColumn);
            cmbColumn.Width = 300;
            grdFavs.ResumeLayout();
        }

        private void PopulateCustomContactCollection(ContactCollection row_con)
        {
            lcont = new List<ContactCollection>();

            foreach (var f in row_con)
            {
                this.Text = "Processing " + f.UserName + " #" + num1.ToString();
                MyManagedContact mycontact = new MyManagedContact();
                mycontact.ItemNum = num1;
                mycontact.UserID = f.UserId;
                mycontact.UserName = f.UserName;

                //default Relationship
                mycontact.MyRelationTo = MyManagedContact.Relation.Contact;
                mycontact.TheirRelationTo = MyManagedContact.Relation.None;

                bool friend = (bool)f.IsFriend;
                if (friend) { mycontact.MyRelationTo = MyManagedContact.Relation.Friend; }

                bool family =(bool)  f.IsFamily;
                if (family){mycontact.MyRelationTo = MyManagedContact.Relation.Family;}

                Person person = flickr.PeopleGetInfo(f.UserId);



                bool revcontact = (bool)person.IsReverseContact;
                if (revcontact) { mycontact.TheirRelationTo = MyManagedContact.Relation.Contact; }

                bool revfriend = (bool)person.IsReverseFriend;
                if (revfriend) { mycontact.TheirRelationTo = MyManagedContact.Relation.Friend; }

                bool revfamily = (bool)person.IsReverseFamily;
                if (revfamily) { mycontact.TheirRelationTo = MyManagedContact.Relation.Family; }

                //PhotoPerson p = flickr.PhotosPeopleGetList(
                //PhotoInfo curphoto = flickr.PhotosGetInfo(userphotos[0].PhotoId);
                //mycontact.MyRelationTo = f.IsFamily;
                //mycontact.Friend = f.IsFriend;

                PhotoCollection col = flickr.PeopleGetPublicPhotos(mycontact.UserID);

                if (col.Count > 0)
                {

                    mycontact.LastPhotoID = col[0].PhotoId;
                    PhotoInfo lastphoto = flickr.PhotosGetInfo(col[0].PhotoId);
                    mycontact.LastUploadDT = lastphoto.DateUploaded;
                    mycontact.LastPhoto = LoadPicture(lastphoto.SmallUrl);
                    mycontact.Icon = LoadPicture(f.BuddyIconUrl);
                }

                mycontuploadlast.Add(mycontact);
                num1++;
                progressBar1.PerformStep();
                progressBar1.Refresh();



            }

            //var sorted = from element in mycontuploadlast
            //             orderby element.ItemNum ascending
            //              select element;


            ////mycontuploadlast.Sort(delegate(MyFlickrContact p1, MyFlickrContact p2) { return p1.LastPhotoID.CompareTo(p2.LastPhotoID); });
            //this.grdFavs.DataSource = sorted.ToList < MyFlickrContact>();
            //grdFavs.row

        }

        private Bitmap LoadPicture(string url)
        {
            HttpWebRequest wreq;
            HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (HttpWebRequest)WebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //var to_process = from element in this.grdFavs.Rows
            //var to_process = from element in this.grdFavs.Rows
            //where element. > DateTime.Now.AddDays(-30)
            //orderby element.UploadDT descending
            //select element;

            foreach (DataGridViewRow row in this.grdFavs.Rows)
            {

                updcontact = row.DataBoundItem as MyFlickrContact;

                if (updcontact.IsFav)
                {
                    this.Text = "Processing " + updcontact.UserName;
                    AddComment(updcontact);
                    AddFav(updcontact.LastPhotoID);
                }
                updcontact.ProcessDT = DateAndTime.Now;

                int cycleSleepTime = 30;

                Thread.Sleep(TimeSpan.FromSeconds(cycleSleepTime));
            }

        }

        private string ProcessComment(MyFlickrContact updcontact)
        {
            string retval = string.Empty;

            string fname = updcontact.FirstName;

            if (!updcontact.Comment.Contains("{0}"))
            {
                return updcontact.Comment.Replace("<br>", System.Environment.NewLine);
            }

            if (string.IsNullOrEmpty(fname))
            {
                fname = string.Empty;
            }

            retval = String.Format(updcontact.Comment, fname);
            retval = retval.Replace("<br>", System.Environment.NewLine);


            return retval;
        }

        private void AddComment(MyFlickrContact updcontact)
        {
            try
            {

                string comment = ProcessComment(updcontact);
                flickr.PhotosCommentsAddComment(updcontact.LastPhotoID, comment);
            }
            catch (Exception e)
            {
                string msg = e.Message;
            }
        }

        private void AddFav(string photoid)
        {
            try
            {
                flickr.FavoritesAdd(photoid);
            }
            catch (Exception exp)
            {
            }
        }

        private void tblMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFavAll_Click(object sender, EventArgs e)
        {
            bool ischeck = btnFavAll.Text == "Check All";
            grdFavs.Enabled = false;
            grdFavs.Refresh();
            foreach (DataGridViewRow row in this.grdFavs.Rows)
            {
                MyManagedContact updcontact = row.DataBoundItem as MyManagedContact;
                updcontact.LeaveAsContact = ischeck;

            }
            grdFavs.Enabled = true;
            grdFavs.Refresh();

            if (ischeck)
            {
                btnFavAll.Text = "Uncheck All";
            }
            else
            {
                btnFavAll.Text = "Check All";
            }

        }

        private void btnPopulateDefComments_Click(object sender, EventArgs e)
        {


            grdFavs.Enabled = false;
            grdFavs.Refresh();

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow row in this.grdFavs.Rows)
            {
                MyFlickrContact updcontact = row.DataBoundItem as MyFlickrContact;

                updcontact.Comment = RandomComment(CommentsCol);

            }
            grdFavs.Enabled = true;
            grdFavs.Refresh();

            if (grdFavs.Columns.Count > 0)
            {
                grdFavs.AutoResizeColumn(grdFavs.Columns.Count - 1);
                grdFavs.ResumeLayout();
            }

        }

        public string Capitalize(string value)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        public enum SortDirection
        {
            Ascending, Decending
        }

        private void Sort<TKey>(ref List<MyFlickrContact> list, Func<MyFlickrContact, TKey> sorter, SortDirection direction)
        {
            if (direction == SortDirection.Ascending)
            {
                //list = list.OrderBy(sorter); 
            }
            else
            {
                //list = list.OrderByDescending(sorter); 
            }
        }

        private List<string> MyLast500Favs()
        {

            List<string> retlist = new List<string>();

            //flickr = new Flickr(Properties.Settings.Default.ApiKey, Properties.Settings.Default.SharedSecret, s_authtoken);

            PhotoCollection favs = flickr.FavoritesGetList(s_userid, 1, 500);

            foreach (var f in favs)
            {
                retlist.Add(f.PhotoId.ToString());
            }

            return retlist;


        }

        private void SetUser()
        {
            string seltext = cmbUsers.Text;

            if (seltext.Equals("Sveta"))
            {
                s_userid = Properties.Settings.Default.SvetaUserID;
                s_authtoken = Properties.Settings.Default.SvetaAuthToken;
                lblUser.Text = "User " + "Marquisa" + " " + s_userid;
                this.Text = "Marquisa Contacts";
            }

            if (seltext.Equals("Anvar"))
            {
                s_userid = Properties.Settings.Default.AnvarUserID;
                s_authtoken = Properties.Settings.Default.AnvarAuthToken;
                lblUser.Text = "User " + "Russiantexan" + " " + s_userid;
                this.Text = "RussianTexan Contacts";
            }

            string api = Properties.Settings.Default.ApiKey;
            string secret = Properties.Settings.Default.SharedSecret;

            //Initialise Flickr
            flickr = GetFlickr(api, secret, s_authtoken);
        }

        private void ContactList_Load(object sender, EventArgs e)
        {
            Cache.Responses.Flush();
            List<string> users = new List<string>();
            users.Add("Anvar");
            users.Add("Sveta");
            this.cmbUsers.DataSource = users;
            this.CommentsCol = GetComments();
            PopulateCommentsCombo();
            string rcomment = RandomComment(CommentsCol);
        }

        private void PopulateCommentsCombo()
        {

            try
            {
                cmbComments.DataSource = new BindingSource(CommentsCol, null);
                cmbComments.DisplayMember = "Value";
                cmbComments.ValueMember = "Key";

            }
            catch (Exception exp)
            {
            }


        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private Dictionary<string, string> GetComments()
        {
            Dictionary<string, string> retdic = new Dictionary<string, string>();

            foreach (SettingsProperty currentProperty in Properties.Settings.Default.Properties)
            {

                if (currentProperty.Name.Contains("Comment"))
                {
                    retdic.Add(currentProperty.Name, currentProperty.DefaultValue.ToString());
                }
            }

            return retdic;
        }

        private String RandomComment(Dictionary<string, string> dict)
        {
            string retval = string.Empty;

            int r = RandomNumber(1, dict.Count);

            //var com =
            //          from entry in dict
            //          where (entry.Value.ToString().Contains(r.ToString()))
            //          select entry.Key;


            foreach (KeyValuePair<string, string> item in dict)
            {
                if (item.Key.Contains(r.ToString()))
                {
                    retval = item.Value.ToString();
                    break;
                }
            }


            return retval;
        }

        private Flickr GetFlickr(string api, string secret, string token)
        {

            return new Flickr(api, secret, token);
        }

        private void btnLastPhotofavs_Click(object sender, EventArgs e)
        {
            FullFavCol = new PhotoFavoriteCollection();
            mycontuploadlast = new List<MyManagedContact>();
            Cache.Responses.Flush();
            Flickr.FlushCache();
            btnLastPhotofavs.Enabled = false;
            grdFavs.Visible = false;
            SetUser();
            //flickr = new Flickr(Properties.Settings.Default.ApiKey, Properties.Settings.Default.SharedSecret,
            //Properties.Settings.Default.SvetaAuthToken);
            PhotoCollection col = flickr.PeopleGetPublicPhotos(s_userid, 1, 1);

            PhotoFavoriteCollection favcol = null;

            List<string> MyLastfavs = MyLast500Favs();

            for (int i = 1; i < 15; i++)
            {
                favcol = flickr.PhotosGetFavorites(col[0].PhotoId, 500, i);

                if (favcol.Count > 0)
                {
                    int num = 1;

                    foreach (PhotoFavorite item in favcol)
                    {
                        this.Text = "";
                        if (!FullFavCol.Contains(item))
                        {

                            FullFavCol.Add(item);

                            PhotoCollection userphotos = flickr.PeopleGetPhotos(item.UserId, 1, 1);
                            if (userphotos.Count > 0)
                            {
                                Photo lastphoto = userphotos[0];
                                if (MyLastfavs.Contains(lastphoto.PhotoId))
                                {
                                    break;
                                }
                                this.Text = "Processing last photo of " + item.UserName;
                                MyFlickrContact mycontact = new MyFlickrContact();
                                Person person = flickr.PeopleGetInfo(item.UserId);
                                //PhotoPerson p = flickr.PhotosPeopleGetList(
                                PhotoInfo curphoto = flickr.PhotosGetInfo(userphotos[0].PhotoId);

                                mycontact.ItemNum = num;
                                mycontact.UserID = item.UserId; ;
                                mycontact.UserName = item.UserName;
                                mycontact.RealName = person.RealName;

                                string fname, mname, lname;

                                if (!String.IsNullOrEmpty(curphoto.OwnerRealName))
                                {
                                    mycontact.RealName = curphoto.OwnerRealName;
                                    mycontact.ParseFullName(curphoto.OwnerRealName, out fname, out mname, out lname);
                                    mycontact.FirstName = fname;
                                }
                                mycontact.Location = curphoto.WebUrl;
                                mycontact.UploadDT = curphoto.DateUploaded;

                                mycontact.Family = person.IsFamily;
                                mycontact.Friend = person.IsFriend;

                                mycontact.LastPhotoID = lastphoto.PhotoId;
                                mycontact.LastPhoto = LoadPicture(lastphoto.SmallUrl);
                                mycontact.Icon = LoadPicture(person.BuddyIconUrl);
                                mycontact.UploadDT = lastphoto.DateUploaded;

                                //mycontuploadlast.Add(mycontact);

                            }


                        }
                    }
                }

            }


            this.grdFavs.DataSource = mycontuploadlast;
            btnLastPhotofavs.Enabled = true;
            grdFavs.Visible = true;





        }

        private void grdFavs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14)
            {
                object value = grdFavs.Rows[e.RowIndex].Cells[9].Value;
                if (value == null) { return; }

                string sURL = value.ToString();

                Form frm = new WBForm();
                frm.Tag = sURL;
                frm.ShowDialog();

            }

        }

        private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
        {
            if (grdFavs.Columns[cellEvent.ColumnIndex] is
                DataGridViewLinkColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return false; }
        }

        private bool IsANonHeaderButtonCell(DataGridViewCellEventArgs cellEvent)
        {
            if (grdFavs.Columns[cellEvent.ColumnIndex] is
                DataGridViewButtonColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return (false); }
        }

        private void grdFavs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cmbBox;
            string comment = (((System.Windows.Forms.DataGridView)(sender)).CurrentCell).EditedFormattedValue.ToString();
            //if (grdFavs.CurrentCell.ColumnIndex == 15) 
            //{ 
            cmbBox = e.Control as ComboBox;
            if (cmbBox == null)
                return;
            cmbBox.SelectedIndexChanged += cmbBox_SelectedIndexChanged;
            //}
        }

        void cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmbBox = (ComboBox)sender;

            if (!String.IsNullOrEmpty(cmbBox.Text))
            {
                //this.
                //MessageBox.Show(cmbBox.SelectedValue.ToString());
                //string com = grdFavs.SelectedCells[0].Value.ToString();
                grdFavs.CurrentRow.Cells[16].Value = cmbBox.Text;
            }

        }

        private void grdFavs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUser();
        }

        private void cmdTestRCom_Click(object sender, EventArgs e)
        {
            grdFavs = ExtensionGridView.SeachResultInRaws(grdFavs, txtSearch.Text);
            //lblRandomComment.Text = com;
        }

        private void cmdHideColums_Click(object sender, EventArgs e)
        {

            grdFavs = ExtensionGridView.RemoveEmptyColumns(grdFavs);


        }

        private void grdFavs_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void grdFavs_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int colindex = e.ColumnIndex;
            string colName = grdFavs.Columns[colindex].HeaderText;
            SortGrid(colName);
        }


        private void SortGrid(string ColumnName)
        {


            gridsource = grdFavs.DataSource as List<MyManagedContact>;

            //var sorted = from s in gridsource
            //             orderby s.UserName
            //             select s;

            //var sorted = (from s in gridsource
            //              orderby s.UserName
            //              select s).OrderBy(ColumnName);

            //this.grdFavs.DataSource = sorted.ToList<MyManagedContact>();
           // grdFavs.DataBindings.Add(
        }


    }

}

