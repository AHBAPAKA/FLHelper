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
using SvetanFlickrApp.Model;
using System.Xml;
using System.Reflection;
using System.Data.SqlClient;

namespace SvetanFlickrApp
{
    public partial class ContactList : Form
    {

        //FlickrFavorite cellfav = null;
        Flickr flickr = null;
        List<string> myFullFavoriteList = null;
        List<ContactCollection> lcont = null;
        ContactCollection contrecent = null;
        ContactCollection LoopCol = null;
        string s_userid = string.Empty;
        string s_authtoken = string.Empty;
        List<string> lastfavs = null;
        PhotoFavoriteCollection FullFavCol = null;
        PhotoCommentCollection FullComCol = null;
        List<MyFlickrContact> mycontuploadlast = new  List<MyFlickrContact>();
        MyFlickrContact updcontact = null;
        Dictionary<string, string> CommentsCol = null;
        List<string> BadUsersCollection = null;
        List<string> FailedCollection = null;
        List<string> MyLastfavs = new List<string>();
        PhotoCollection CurUserPhotos = null;
        string selectedphotoid = string.Empty;
        private BindingSource grigbindingSource;
        List<MyFlickrContact> PeopleCommentedMyLastPhotos = null;
        List<MyFlickrContact> AllContactsPhotos = null;
        //Saved Favs
        List<string> MySavedFavesList = null; 
        int num1;
        int MAXGRIDITEMS = 60;

        public ContactList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startdt = DateTime.Now;
            Cache.Responses.Flush();
            button1.Enabled = false;
            grdFavs.Visible = false;
            this.Text = "Initializing...";
            SetUser();
            this.Text = "Retrieving Last Favs...";
            //lastfavs = MyLast500Favs();
            MySavedFavesList = GetMySavedFavs();
            lastfavs = MySavedFavesList;
            RetrieveContacts();
            button1.Enabled = true;
            grdFavs.Visible = true;
            progressBar1.Visible = false;
            progressBar1.Value = 0;
            DateTime enddt = DateTime.Now;
            System.TimeSpan diffResult = enddt.Subtract(startdt);
            lblRandomComment.Text = "Retrieval Process took " + diffResult.Minutes.ToString() + " minutes";

        }

        private void RetrieveContacts()
        {


            ContactCollection extras = new ContactCollection();

            DateTime dt = DateTime.Now.AddHours(-19);
            mycontuploadlast = new List<MyFlickrContact>();
            contrecent = new ContactCollection();
            num1 = 1;

            this.Text = "Working on initial collection...";
            for (int i = 1; i < 10000; i++)
            {


                LoopCol = flickr.ContactsGetPublicList(s_userid, i, 100);
                if (LoopCol.Count == 0)
                {
                    break;
                }
                else
                {
                    foreach (var item in LoopCol)
                    {
                        contrecent.Add(item);

                    }
                }
            }

            this.Text = "Processing collection...";

            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = contrecent.Count;
            progressBar1.Step = 1;


            PopulateCustomContactCollection(contrecent);

            var sorted = from element in mycontuploadlast
                         where element.UploadDT > DateTime.Now.AddDays(-3)
                         orderby element.UploadDT descending
                         select element;

            AllContactsPhotos = sorted.ToList<MyFlickrContact>();


            //mycontuploadlast.Sort(delegate(MyFlickrContact p1, MyFlickrContact p2) { return p1.LastPhotoID.CompareTo(p2.LastPhotoID); });
            //this.grdFavs.DataSource = sorted.ToList<MyFlickrContact>();

            //BindGrid(sorted.ToList<MyFlickrContact>());
            DataFuncs.BindGrid(sorted.ToList<MyFlickrContact>(), this.grdFavs);
            AddComboColumn();

        }

        private List<MyFlickrContact> GetEnnumeration(List<MyFlickrContact> source)
        {
            List<MyFlickrContact> retlist = new List<MyFlickrContact>();
            int num = 1;
            foreach (MyFlickrContact item in source)
            {
                item.ItemNum = num;
                retlist.Add(item);

                num++;
            }
            if (AllContactsPhotos != null)
            {
                this.Text = "Preselected " + retlist.Count.ToString() + " photos for com/fav from total of " + AllContactsPhotos.Count.ToString();
            }
            else
            {
                this.Text = "Preselected " + retlist.Count.ToString() + " photos for com/fav";
            }
            return retlist;
        }

        private void BindGrid(List<MyFlickrContact> bindingsource)
        {
            //List<MyFlickrContact> griddata = bindingsource;

            List<MyFlickrContact> griddata = bindingsource.Distinct<MyFlickrContact>().ToList<MyFlickrContact>();

            if (bindingsource.Count > MAXGRIDITEMS)
            {
                griddata = bindingsource.Take(MAXGRIDITEMS).ToList<MyFlickrContact>();
            }
            grigbindingSource = new BindingSource();
            grigbindingSource.DataSource = GetEnnumeration(griddata);
            this.grdFavs.DataSource = grigbindingSource;
            grdFavs.Visible = true;

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

        private MyFlickrContact LoadedContact(string UserId, string UserName, string RealName,
            bool? IsFamily, bool? IsFriend, string BuddyIconUrl)
        {

            MyFlickrContact mycontact = new MyFlickrContact();

            try
            {

                this.Text = "Inside Loaded Contact for " + UserName + " #" + num1.ToString();

                mycontact.ItemNum = num1;
                mycontact.UserID = UserId;
                mycontact.UserName = UserName;
                string fname, mname, lname;

                if (!String.IsNullOrEmpty(RealName))
                {
                    mycontact.ParseFullName(RealName, out fname, out mname, out lname);
                    mycontact.FirstName = fname;
                }


                mycontact.Family = IsFamily;
                mycontact.Friend = IsFriend;

                if (UserName.Contains("brend"))
                {
                    // break;
                }
                this.Text = "Checking last photo of " + UserName + ". Precelected " + num1.ToString() + " photos so far"; ;
                PhotoCollection col = flickr.PeopleGetPublicPhotos(mycontact.UserID);
                if (col.Count > 0)
                {


                    if (!BadUser().Contains(UserId))
                    {

                        mycontact.LastPhotoID = col[0].PhotoId;


                        PhotoInfo curphoto = null;

                        if (!col[0].PhotoId.Equals("5735906673"))
                        {
                            curphoto = flickr.PhotosGetInfo(col[0].PhotoId);
                        }


                        if (curphoto != null)
                        {
                            if (!String.IsNullOrEmpty(curphoto.OwnerRealName))
                            {
                                mycontact.RealName = curphoto.OwnerRealName;
                                mycontact.ParseFullName(curphoto.OwnerRealName, out fname, out mname, out lname);
                                mycontact.FirstName = fname;
                            }
                            mycontact.Location = curphoto.WebUrl;
                            mycontact.UploadDT = curphoto.DateUploaded;
                        }




                    }
                    else
                    {
                    BADUSER_EXIT:
                        this.Text = "Skipped " + UserName;
                    }

                    mycontact.LastPhoto = LoadPicture(col[0].SmallUrl);



                    mycontact.Icon = LoadPicture(BuddyIconUrl);
                }
            }
            catch (Exception exp)
            {
                this.Text = exp.Message;
            }



            return mycontact;
        }

        public List<string> BadUser()
        {
            return BadUsersCollection;

        }

        private void PopulateCustomContactCollection(ContactCollection row_con)
        {
            lcont = new List<ContactCollection>();
            MyFlickrContact mycontact = null;

            foreach (var f in row_con)
            {
                try
                {
                    if (f.UserId == s_userid)
                    {
                        continue;
                    }
                    this.Text = "Processing " + f.UserName + ". Preselected " + mycontuploadlast.Count.ToString() + "photos so far";

                    if (!BadUser().Contains(f.UserId))
                    {
                        mycontact = LoadedContact(f.UserId, f.UserName,
                                            f.RealName, f.IsFamily, f.IsFriend, f.BuddyIconUrl);
                    }

                    if (mycontact != null)
                    {
                        progressBar1.PerformStep();
                        progressBar1.Refresh();

                        if (mycontact.LastPhotoID == "4266613217")
                        {
                        }

                        if (!lastfavs.Contains(mycontact.LastPhotoID))
                        {
                            if (mycontact.UploadDT > DateTime.Now.AddDays(-5))
                            {
                                mycontuploadlast.Add(mycontact);
                                num1++;


                                ///TEST
                                //if (num1 > 3)
                                //    break;

                            }
                        }


                    }



                }

                catch (Exception exp)
                {
                    this.Text = exp.Message;
                }

            }


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

            DateTime startdt = DateTime.Now;
            lblRandomComment.Text = "";

            grdFavs.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = grdFavs.Rows.Count;
            int iloop = 1;
            int leftover = 0;
            int ifailed = 0;
            FailedCollection = new List<string>();
            bool goterr = false;

            foreach (DataGridViewRow row in this.grdFavs.Rows)
            {
                goterr = false;

                if (row.DataBoundItem != null)
                {
                    updcontact = row.DataBoundItem as MyFlickrContact;

                    if (updcontact.IsFav)
                    {
                        leftover = grdFavs.Rows.Count - iloop;
                        this.Text = "Processing " + updcontact.UserName + " #" + iloop.ToString() + " from " + grdFavs.Rows.Count.ToString() +
                                        " number of failed " + ifailed.ToString();
                        try
                        {
                            goterr = AddFav(updcontact.LastPhotoID);
                           
                        }
                        catch (Exception exp)
                        {
                            FailedCollection.Add(updcontact.UserName);
                            ifailed++;
                            goterr = true;
                        }

                        if (!goterr)
                        {

                            AddComment(updcontact);

                        }

                        //Highlite row
                        row.DefaultCellStyle.BackColor = Color.Yellow;

                    }

                    updcontact.ProcessDT = DateAndTime.Now;

                    iloop++;

                    if(AllContactsPhotos !=null)
                    {
                        AllContactsPhotos.Remove(updcontact);
                    }

                    progressBar1.PerformStep();

                    Thread.Sleep(10000);
                }
            }

            if(AllContactsPhotos !=null)
            {
                if (AllContactsPhotos.Count > 0)
                {
                    BindGrid(AllContactsPhotos);
                }
                this.Text = "Fav/comments process is done" + "number of failed " + ifailed;
                progressBar1.Visible = false;

                DateTime enddt = DateTime.Now;
                System.TimeSpan diffResult = enddt.Subtract(startdt);
                lblRandomComment.Text = "Com/Fav Process took " + diffResult.Minutes.ToString() + " minutes";
                MySavedFavesList = GetMySavedFavs();
                this.Text = MySavedFavesList.Count.ToString() + " faves saved in local DB";
                //if (FailedCollection.Count > 0)
                //{
                //    StringBuilder sb = new StringBuilder();
                //    foreach (string s in FailedCollection)
                //    {
                //        sb.Append(s + ", ");
                //    }

                //    lblRandomComment.Text = lblRandomComment.Text + " Failed: " + sb.ToString();
                //}
            }
            else
            {
                grdFavs.Visible = false;


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
            else 
            { 
                //Capitalize first letter of first name
                fname = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fname.ToLower());
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
            catch (Exception exp)
            {
                
                //throw;
            }

        }

        private bool AddFav(string photoid)
        {
            bool retval = false;
            try
            {
                flickr.FavoritesAdd(photoid);
                AddFavToDB(photoid);
            }
            catch (Exception exp)
            {
                retval = true;
            }

            return retval;
        }

        private void tblMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFavAll_Click(object sender, EventArgs e)
        {
            bool isfav = btnFavAll.Text == "Fav All";
            grdFavs.Enabled = false;
            grdFavs.Refresh();


            foreach (DataGridViewRow row in this.grdFavs.Rows)
            {

                if (row.DataBoundItem != null)
                {
                    MyFlickrContact updcontact = row.DataBoundItem as MyFlickrContact;
                    updcontact.IsFav = isfav;
                }


            }
            grdFavs.Enabled = true;
            grdFavs.Refresh();

            if (isfav)
            {
                btnFavAll.Text = "UnFav All";
            }
            else
            {
                btnFavAll.Text = "Fav All";
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

                if (row.DataBoundItem != null)
                {

                    updcontact.Comment = RandomComment(CommentsCol);
                }

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


            PhotoCollection favs = null;
            List<string> retlist = new List<string>();

            //flickr = new Flickr(Properties.Settings.Default.ApiKey, Properties.Settings.Default.SharedSecret, s_authtoken);

            for (int i = 1; i < 1000; i++)
            {

                favs = flickr.FavoritesGetList(s_userid, i, 450);

                if (favs != null)
                {
                    this.Text = "Favorite Trip #" + i.ToString() + " delivered " + favs.Count.ToString() + " favs; Total:" + retlist.Count.ToString();

                    if (favs.Count == 0)
                    {
                        break;
                    }

                    foreach (var f in favs)
                    {
                        retlist.Add(f.PhotoId.ToString());
                    }


                    this.Text = "Favorite Trip #" + i.ToString() + " delivered " + favs.Count.ToString() + " favs; Total:" + retlist.Count.ToString();
                }

            }


            return retlist;


        }

        private List<string> GetMySavedFavs(bool bload = false)
        {
            List<string> retlist = new List<string>();

            if (this.chkUseLocalFavs.Checked || bload)
            {

                try
                {

                    using (DataClasses1DataContext db = new DataClasses1DataContext())
                    {
                        retlist = (from f in db.Favs
                                   select f.photoid).ToList<string>();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                retlist = MyLast500Favs();
            }

            return retlist;


        }

        private void LoadMyFavsToDB(List<string> favslist)
        {
            List<Fav> favstoinsert = new List<Fav>();

            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.ExecuteCommand("DELETE FROM Favs");

                    foreach (var f in favslist)
                    {
                        if (f == "4266613217")
                        {
                        }
                        Fav fav = new Fav();
                        fav.photoid = f.ToString().ToString();
                        favstoinsert.Add(fav);
                    }

                    favstoinsert.GroupBy(i => i.photoid).Select(group => group.First());

                    DataFuncs.BulkInsert(db.Connection.ConnectionString, "Favs", favstoinsert);
                    this.Text = "Saved " + favstoinsert.Count.ToString() + " favs to local DB";

                }
            }
            catch (Exception exp)
            {

                //throw;
            }



        }
        private void AddFavToDB(string photoid)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                        Fav fav = new Fav();
                        fav.photoid = photoid;
                        db.Favs.InsertOnSubmit(fav);
                        db.SubmitChanges();
                }
            }
            catch (Exception exp)
            {

                //throw;
            }



        }


        private void SetUser()
        {
            string seltext = cmbUsers.Text;

            if (seltext.Equals("Sveta"))
            {
                s_userid = Properties.Settings.Default.SvetaUserID;
                s_authtoken = Properties.Settings.Default.SvetaAuthToken;
                //lblUser.Text = "User " + "Marquisa" + " " + s_userid;
                this.Text = "Marquisa Contacts";
            }

            if (seltext.Equals("Anvar"))
            {
                s_userid = Properties.Settings.Default.AnvarUserID;
                s_authtoken = Properties.Settings.Default.AnvarAuthToken;
                //lblUser.Text = "User " + "Russiantexan" + " " + s_userid;
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
            this.dtDeleteMaxDate.Value = DateTime.Now.AddMonths(-4);
            List<string> users = new List<string>();
            users.Add("Anvar");
            users.Add("Sveta");
            this.cmbUsers.DataSource = users;
            this.CommentsCol = GetComments();
            CurUserPhotos = GetPhotoColForUser();
            PopulateCommentsCombo();
            PopulateBadUsers();
            this.radioFavs.Checked = true;

            MySavedFavesList = GetMySavedFavs(true);
            this.Text = MySavedFavesList.Count.ToString() + " faves allocated in local DB";
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

            int iloop = 1;

            string docpath = Path.Combine(GetAppFolder(), @"XML\Comments.xml");
            XmlTextReader reader = new XmlTextReader(docpath);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        retdic.Add(iloop.ToString(), reader.Value);
                        iloop++;
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
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
            string photoid = cmdMyPhotos.SelectedValue.ToString();

            btnLastPhotofavs.Enabled = false;
            grdFavs.Visible = false;

            mycontuploadlast.Clear();

            ProcessMyPhotoFavs(photoid);

            btnLastPhotofavs.Enabled = true;
            grdFavs.Visible = true;
        }
        private void ProcessMyPhotoFavs(string photoid)
        {
            FullFavCol = new PhotoFavoriteCollection();
            mycontuploadlast = new List<MyFlickrContact>();
            string myLastPhotoId = string.Empty;

           // myLastPhotoId = GetLastPhotoID(s_userid);
            myLastPhotoId = photoid;

            if (myLastPhotoId.Length == 0) return;

            //LoadCollection of my favorites
            GetMyFavs();

            //BindGrid(WhoFavedMyPhoto(myLastPhotoId));
            DataFuncs.BindGrid(WhoFavedMyPhoto(myLastPhotoId), this.grdFavs);
            //this.grdFavs.DataSource = WhoFavedMyPhoto(myLastPhotoId);

        }

        private PhotoCollection GetPhotoColForUser(string userid = "", int selectlastonly = 0)
        {
            PhotoCollection retval = new PhotoCollection();
            if (userid.Length == 0) userid = s_userid;
            PhotoCollection col = flickr.PeopleGetPublicPhotos(userid);
            retval = col;

            return retval;
        }

        private void ProcessMyPhotoComs(string photoid)
        {
            FullFavCol = new PhotoFavoriteCollection();
            string myLastPhotoId = string.Empty;

            myLastPhotoId = GetLastPhotoID(s_userid);
            if (myLastPhotoId.Length == 0) return;

            //LoadCollection of my favorites
            GetMyFavs();

            this.grdFavs.DataSource = WhoFavedMyPhoto(myLastPhotoId);
        }
        private string GetLastPhotoID(string user_id)
        {
            string retval = string.Empty;
            SetUser();
            Cache.Responses.Flush();
            Flickr.FlushCache();

            PhotoCollection col = flickr.PeopleGetPublicPhotos(user_id, 1, 1);

            if (col == null) return retval;
            if (col.Count == 0) return retval;

            retval = col[0].PhotoId;

            return retval;
        }

        private List<PhotoFavorite> GetMyLastPhotoFavs(string phid)
        {
            List<PhotoFavorite> retval = new List<PhotoFavorite>();
            PhotoFavoriteCollection favcol = null;

            try
            {
                for (int i = 1; i < 15; i++)
                {
                    favcol = flickr.PhotosGetFavorites(phid, 500, i);
                    if (favcol != null)
                    {
                        foreach (var item in favcol)
                        {
                            if (!retval.Contains(item))
                            {
                                retval.Add(item);
                            }

                        }
                    }
                }
            }
            catch (Exception exp)
            {

                throw;
            }

            return retval;
        }

        private List<PhotoComment> GetMyLastPhotoComments(string phid)
        {
            List<PhotoComment> retval = new List<PhotoComment>();
            PhotoCommentCollection comcol = null;

            try
            {
                comcol = flickr.PhotosCommentsGetList(phid);

                if (comcol != null)
                {
                    foreach (var item in comcol)
                    {
                        if (!retval.Contains(item))
                        {
                            retval.Add(item);
                        }

                    }
                }
            }

            catch (Exception exp)
            {

                throw;
            }

            return retval;
        }
        private void grdFavs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                string sURL = ((SvetanFlickrApp.MyFlickrContact)(grdFavs.Rows[e.RowIndex].DataBoundItem)).Location;

                //System.Diagnostics.Process.Start(sURL);
                System.Diagnostics.Process.Start("firefox.exe", sURL);

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
            CurUserPhotos = GetPhotoColForUser();
            PopulateMyPhotosCombo(20);
        }

        private void PopulateBadUsers()
        {
            BadUsersCollection = new List<string>();
            string docpath = Path.Combine(GetAppFolder(), @"XML\BadContacts.xml");
            XmlTextReader reader = new XmlTextReader(docpath);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.;
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        BadUsersCollection.Add(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        break;
                }
            }
            StringBuilder s = new StringBuilder();
            foreach (string c in BadUsersCollection)
            {
                s.Append(c + ", ");
            }
            if (BadUsersCollection.Count > 0)
            {
                this.Text = "Bad contacts: " + s.ToString();
            }
        }

        private void cmdTestRCom_Click(object sender, EventArgs e)
        {
            if (cmd10PhotoFavs.Text == "10 photo favs")
            {
                LoadMyLastPhotosFavs(10);
            }
            else
            {
                LoadMyLastPhotosComments(10);
            }

            progressBar1.Visible = false;
            lblCount.Text = "";
            lblCount.Visible = false;


        }

        private string GetAppFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        }

        private void cmdHideColums_Click(object sender, EventArgs e)
        {

            grdFavs = ExtensionGridView.RemoveEmptyColumns(grdFavs);


        }

        private List<MyFlickrContact> WhoCommentedMyPhoto(string myphotoid)
        {
            List<MyFlickrContact> retval = new List<MyFlickrContact>();



            return retval;
        }

        private List<MyFlickrContact> WhoFavedMyPhoto(string myphotoid)
        {
            List<MyFlickrContact> retval = new List<MyFlickrContact>();
            List<PhotoFavorite> mylastphotofavs = GetMyLastPhotoFavs(myphotoid);
            try
            {
                int num = 0;
                foreach (var photofav in mylastphotofavs)
                {
                    if (photofav.UserId == s_userid)
                    {
                        continue;
                    }
                    string friendLastPhotoId = GetLastPhotoID(photofav.UserId);
                    this.Text = "Processing last photo of " + photofav.UserName + ". Preselected " + mycontuploadlast.Count.ToString() + " photos for processing";
                    
                    bool favexists = MyLastfavs.Contains(friendLastPhotoId);

                    if (!favexists)
                    {
                        Person person = flickr.PeopleGetInfo(photofav.UserId);
                        PhotoInfo curphoto = flickr.PhotosGetInfo(friendLastPhotoId);
                        num++;
                        MyFlickrContact mycontact = new MyFlickrContact();
                        mycontact.ItemNum = num;
                        mycontact.UserID = person.UserId; ;
                        mycontact.UserName = person.UserName;
                        mycontact.RealName = person.RealName;

                        string fname, mname, lname;

                        if (curphoto != null)
                        {

                            if (!String.IsNullOrEmpty(curphoto.OwnerRealName))
                            {
                                mycontact.RealName = curphoto.OwnerRealName;
                                mycontact.ParseFullName(curphoto.OwnerRealName, out fname, out mname, out lname);
                                mycontact.FirstName = fname;
                            }
                            mycontact.Location = curphoto.WebUrl;
                            mycontact.UploadDT = curphoto.DateUploaded;
                        }

                        mycontact.Family = person.IsFamily;
                        mycontact.Friend = person.IsFriend;

                        mycontact.LastPhotoID = curphoto.PhotoId;
                        mycontact.LastPhoto = LoadPicture(curphoto.SmallUrl);
                        mycontact.Icon = LoadPicture(person.BuddyIconUrl);
                        mycontact.UploadDT = curphoto.DateUploaded;

                        DateTime maxdt = DateTime.Now.AddMonths(-1);
                        if (mycontact.UploadDT > maxdt)
                        {
                            mycontuploadlast.Add(mycontact);
                        }

                    }

                }

                retval = mycontuploadlast;
            }
            catch (Exception exp)
            {

                //throw;
            }
            this.Text = "Preselected " + retval.Count.ToString() + " photos of those who faved my photo " + cmdMyPhotos.Text;

            return retval;
        }

        private List<Person> PeopleWhoFavedMyPhoto(string myphotoid)
        {
            List<Person> retval = new List<Person>();
            List<PhotoFavorite> mylastphotofavs = GetMyLastPhotoFavs(myphotoid);
            try
            {
                int num = 0;
                foreach (var photofav in mylastphotofavs)
                {

                        Person person = flickr.PeopleGetInfo(photofav.UserId);
                        retval.Add(person);

                }

               
            }
            catch (Exception exp)
            {

                //throw;
            }

            return retval;
        }

        private List<Person> PeopleWhoFavedMyPhotos(List<string> myphotos)
        {
            List<Person> retval = new List<Person>();
            try
            {

                foreach (var photoid in myphotos)
                {
                    int num = 1;
                    this.lblCount.Visible = true;
                    lblCount.Text = "Processing data for photo #" + num.ToString();
                    this.progressBar1.Visible = true;
                    this.Text = "Checking favs of my photo # " + num.ToString() + " from " + myphotos.Count().ToString();
                    Application.DoEvents();
                    List<PhotoFavorite> mylastphotofavs = GetMyLastPhotoFavs(photoid);
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = mylastphotofavs.Count + 1;
                    int progress = 1;
                    foreach (var photofav in mylastphotofavs)
                    {
                        progressBar1.Value = progress;
                        Person person = flickr.PeopleGetInfo(photofav.UserId);
                        if (!retval.Contains(person))
                        {
                            retval.Add(person);
                        }
                        progress++; ;

                    }


                    num++;
                }


            }
            catch (Exception exp)
            {

                //throw;
            }

            retval = retval.GroupBy(x => x.UserId).Select(y => y.First()).ToList<Person>();

            return retval;
        }
        private List<Person> PeopleWhoCommentedMyPhotos(List<string> myphotos)
        {
            List<Person> retval = new List<Person>();
            try
            {
                int num = 1;

                foreach (var photoid in myphotos)
                {
                    this.lblCount.Visible = true;
                    lblCount.Text = "Processing data for photo #" + num.ToString();
                    this.progressBar1.Visible = true;
                    this.Text = "Checking favs of my photo # " + num.ToString() + " from " + myphotos.Count().ToString();
                    Application.DoEvents();
                    this.Text = "Checking favs of my photo # " + num.ToString() + " from " + myphotos.Count().ToString();
                    Application.DoEvents();
                    List<PhotoComment> mylastphotocoms = GetMyLastPhotoComments(photoid);
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = mylastphotocoms.Count + 1;
                    int progress = 1;
                    foreach (var photocom in mylastphotocoms)
                    {
                        progressBar1.Value = progress;
                        Person person = flickr.PeopleGetInfo(photocom.AuthorUserId);

                        if (!retval.Contains(person))
                        {
                            retval.Add(person);
                        }
                        progress++; ;
                    }
                    num++;
                }


            }
            catch (Exception exp)
            {

                //throw;
            }

            retval = retval.GroupBy(x => x.UserId).Select(y => y.First()).ToList<Person>();

            return retval;
        }

        private List<PhotoFavorite> WhoFavedPhoto(string myphotoid)
        {
            List<PhotoFavorite> retval = new List<PhotoFavorite>();
            List<PhotoFavorite> mylastphotofavs = GetMyLastPhotoFavs(myphotoid);
            return retval;

        }

        private void btnLastPhotoComments_Click(object sender, EventArgs e)
        {


            FullComCol = new PhotoCommentCollection();
            mycontuploadlast = new List<MyFlickrContact>();
            Cache.Responses.Flush();
            Flickr.FlushCache();
            btnLastPhotoComments.Enabled = false;

            grdFavs.Visible = false;
            SetUser();
            //string myLastPhotoId = GetLastPhotoID(s_userid);
            mycontuploadlast.Clear();

            string myLastPhotoId = cmdMyPhotos.SelectedValue.ToString();
            if (myLastPhotoId.Length == 0) return;
            PhotoCollection col = flickr.PeopleGetPublicPhotos(s_userid, 1, 1);

            List<PhotoComment> mylastphotocoms = GetMyLastPhotoComments(myLastPhotoId);

            //LoadCollection of my favorites
            GetMyFavs();

            try
            {
                int num = 0;
                foreach (var photocom in mylastphotocoms)
                {
                    if(photocom.AuthorUserId == s_userid)
                    {
                        continue;
                    }
                    string friendLastPhotoId = GetLastPhotoID(photocom.AuthorUserId);
                    this.Text = "Processing last photo of " + photocom.AuthorUserName + ". Preselected " + mylastphotocoms.Count.ToString() + " favorites fro processing";

                    if (!MyLastfavs.Contains(friendLastPhotoId))
                    {
                        Person person = flickr.PeopleGetInfo(photocom.AuthorUserId);
                        PhotoInfo curphoto = flickr.PhotosGetInfo(friendLastPhotoId);
                        num++;
                        MyFlickrContact mycontact = new MyFlickrContact();
                        mycontact.ItemNum = num;
                        mycontact.UserID = person.UserId; ;
                        mycontact.UserName = person.UserName;
                        mycontact.RealName = person.RealName;

                        string fname, mname, lname;

                        if (curphoto != null)
                        {

                            if (!String.IsNullOrEmpty(curphoto.OwnerRealName))
                            {
                                mycontact.RealName = curphoto.OwnerRealName;
                                mycontact.ParseFullName(curphoto.OwnerRealName, out fname, out mname, out lname);
                                mycontact.FirstName = fname;
                            }
                            mycontact.Location = curphoto.WebUrl;
                            mycontact.UploadDT = curphoto.DateUploaded;
                        }

                        mycontact.Family = person.IsFamily;
                        mycontact.Friend = person.IsFriend;

                        mycontact.LastPhotoID = curphoto.PhotoId;
                        mycontact.LastPhoto = LoadPicture(curphoto.SmallUrl);
                        mycontact.Icon = LoadPicture(person.BuddyIconUrl);
                        mycontact.UploadDT = curphoto.DateUploaded;

                        DateTime maxdt = DateTime.Now.AddMonths(-1);
                        if (mycontact.UploadDT > maxdt)
                        {
                            mycontuploadlast.Add(mycontact);
                        }

                    }

                }

            }
            catch (Exception exp)
            {

                throw;
            }


            //BindGrid(mycontuploadlast);
            DataFuncs.BindGrid(mycontuploadlast, this.grdFavs);

            //this.grdFavs.DataSource = mycontuploadlast;
            if (mycontuploadlast.Count > 0)
            {
                this.Text = "Selected " + mycontuploadlast.Count.ToString() + " images";
            }
            else
            {
                this.Text = string.Empty;
            }
            btnLastPhotoComments.Enabled = true;
            grdFavs.Visible = true;



        }

        private bool IsValid(string suserid)
        {

            List<string> novalidlst = new List<string>();
            novalidlst.Add("33669907@N08");

            //if (novalidlst.Contains(suserid))
            //{
            //    retval = false;
            //}


            return (!novalidlst.Contains(suserid));

        }
        private void PopulateMyPhotosCombo(int limit=5, int favsforonly = 0)
        {
            if (CurUserPhotos.Count == 0) return;
            Dictionary<string,string> dic = new Dictionary<string,string>();
            string sTitle = string.Empty;
            int count = 0; 
            foreach(var item in CurUserPhotos)
            {
                if (count <= 0)
                {
                    List<PhotoFavorite> photofavs = GetMyLastPhotoFavs(item.PhotoId);
                    int numfavs = photofavs.Count;
                    List<PhotoComment> photocoms = GetMyLastPhotoComments(item.PhotoId);
                    int numcomms = photocoms.Count;

                    sTitle = item.Title + " - favs:" + numfavs.ToString() + " coms:" + numcomms.ToString();
                }
                else
                {
                    sTitle = item.Title;
                }

                dic.Add(item.PhotoId, sTitle);
                count++;
                if (count == limit)
                {
                    break;
                }

            }
            cmdMyPhotos.DataSource = new BindingSource(dic, null);
            cmdMyPhotos.DisplayMember = "Value";
            cmdMyPhotos.ValueMember = "Key";
            selectedphotoid = CurUserPhotos[0].PhotoId;
        }

        private void LoadMyLastPhotosComments(int limit = 5)
        {
            if (CurUserPhotos.Count == 0) return;
            //LoadCollection of my favorites

            List<string> myphotoids = new List<string>();
            for (int i = 0; i < limit; i++)
            {
                myphotoids.Add(CurUserPhotos[i].PhotoId);
            }

            List<Person> activefriends = PeopleWhoCommentedMyPhotos(myphotoids);

            GetMyFavs();

            List<MyFlickrContact> FullMyFlickrContacts = new List<MyFlickrContact>();
            FullMyFlickrContacts = activefriendsphotos(activefriends);

            //get rid of duplicates
            FullMyFlickrContacts = FullMyFlickrContacts.GroupBy(x => x.LastPhotoID).Select(y => y.First()).ToList<MyFlickrContact>();

            //populate global collection
            //PeopleCommentedMyLastPhotos = FullMyFlickrContacts;

            DataFuncs.BindGrid(FullMyFlickrContacts, grdFavs);
        }
        private void LoadMyLastPhotosFavs(int limit=5)
        {
            if (CurUserPhotos.Count == 0) return;
            //LoadCollection of my favorites

            List<string> myphotoids = new List<string>();
            for (int i = 0; i < limit; i++)
            {
                myphotoids.Add(CurUserPhotos[i].PhotoId);
            }

            List<Person> activefriends = PeopleWhoFavedMyPhotos(myphotoids);

            GetMyFavs();

            List<MyFlickrContact> FullMyFlickrContacts = new List<MyFlickrContact>();
            FullMyFlickrContacts = activefriendsphotos(activefriends);

            //get rid of duplicates
            FullMyFlickrContacts = FullMyFlickrContacts.GroupBy(x => x.LastPhotoID).Select(y => y.First()).ToList<MyFlickrContact>();

            //populate global collection
            //PeopleCommentedMyLastPhotos = FullMyFlickrContacts;

            DataFuncs.BindGrid(FullMyFlickrContacts, grdFavs);
        }
        private List<MyFlickrContact> activefriendsphotos(List<Person> activefriends)
        {
            List<MyFlickrContact> retval = new List<MyFlickrContact>();
            int num = 0;
            foreach (var friend in activefriends)
            {
                this.Text = "Checking last photo of " + friend.RealName;
                Application.DoEvents();
                string friendLastPhotoId = GetLastPhotoID(friend.UserId);
                if (friendLastPhotoId.Length == 0) break;

                if (!MyLastfavs.Contains(friendLastPhotoId))
                {
                    Person person = friend;
                    PhotoInfo curphoto = flickr.PhotosGetInfo(friendLastPhotoId);
                    num++;
                    MyFlickrContact mycontact = new MyFlickrContact();
                    mycontact.ItemNum = num;
                    mycontact.UserID = person.UserId; ;
                    mycontact.UserName = person.UserName;
                    mycontact.RealName = person.RealName;

                    string fname, mname, lname;

                    if (curphoto != null)
                    {

                        if (!String.IsNullOrEmpty(curphoto.OwnerRealName))
                        {
                            mycontact.RealName = curphoto.OwnerRealName;
                            mycontact.ParseFullName(curphoto.OwnerRealName, out fname, out mname, out lname);
                            mycontact.FirstName = fname;
                        }
                        mycontact.Location = curphoto.WebUrl;
                        mycontact.UploadDT = curphoto.DateUploaded;
                    }

                    mycontact.Family = person.IsFamily;
                    mycontact.Friend = person.IsFriend;

                    mycontact.LastPhotoID = curphoto.PhotoId;
                    mycontact.LastPhoto = LoadPicture(curphoto.SmallUrl);
                    mycontact.Icon = LoadPicture(person.BuddyIconUrl);
                    mycontact.UploadDT = curphoto.DateUploaded;

                    retval.Add(mycontact);
                    this.Text = "Collected so far  " + retval.Count.ToString() + " photos...";
                }

            }

            return retval;
        }

        private void btnFavSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdFavs.SelectedRows)
            {
                string comment = cmbComments.Text;
                MyFlickrContact updcontact = row.DataBoundItem as MyFlickrContact;
                if (updcontact != null)
                {
                    updcontact.Comment = comment;
                }
            }

            grdFavs.Enabled = true;
            grdFavs.Refresh();


        }

        private void cmdDeleteRows_Click(object sender, EventArgs e)
        {
            DeteteRows();
            this.Text = "Number of selected images:" + grdFavs.Rows.Count.ToString();
        }


        private void DeteteRows()
        {
            foreach (DataGridViewRow row in grdFavs.SelectedRows)
            {

                updcontact = row.DataBoundItem as MyFlickrContact;
                //Remove photo from cached collection
                if (AllContactsPhotos != null)
                {
                    AllContactsPhotos.Remove(updcontact);
                }

                grdFavs.Rows.Remove(row);
                grdFavs.Invalidate();

            }
        }

        private void cmdUpdateFavDB_Click(object sender, EventArgs e)
        {
            MySavedFavesList = MyLast500Favs();
            this.Text = "Saving favs to DB...";
            LoadMyFavsToDB(MySavedFavesList);
        }


        private void cmdSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                grdFavs = ExtensionGridView.SeachResultInRaws(this.grdFavs, txtSearch.Text);
            }
        }

        private void cmdHideGavnoColumns_Click(object sender, EventArgs e)
        {
            grdFavs = ExtensionGridView.HideGavnoColumns(this.grdFavs);
            grdFavs.AutoResizeColumns();
        }


        private void GetMyFavs()
        {
            MyLastfavs = GetMySavedFavs();
        }

        private void cmdMyPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedphotoid = cmdMyPhotos.SelectedValue.ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdFavsToDelete_Click(object sender, EventArgs e)
        {
            PhotoCollection favs;
            DataFuncs.PopulateMyFriensList();
            DataFuncs.FavsToDeleteList = new List<FavsToDelete>();

            for (int i = 1; i < 1000; i++)
            {
                //send request to the server
                favs = flickr.FavoritesGetList(s_userid, i, 500);

                if (favs != null)
                {
                    this.Text = "Favorite Trip #" + i.ToString() + " delivered " + favs.Count.ToString() + " favs, total: " + DataFuncs.FavsToDeleteList.Count.ToString();

                    if (favs.Count == 0)
                    {
                        //last request to the server
                        break;
                    }

                    DataFuncs.PopulateCustomCollection(favs);
                    //Process favs

                }

            }

            DataFuncs.LoadDBFavsToDelete();
            this.Text = "Saved to DB " + DataFuncs.FavsToDeleteList.Count.ToString() + " favs to DELETE";
        }

        private void cmdDeleteFavs_Click(object sender, EventArgs e)
        {

            DateTime maxtime = this.dtDeleteMaxDate.Value;
            List<FavsToDelete> delproclist = DataFuncs.GetSavedFavsToDEleteList();

            List<FavsToDelete> photostodeletelist = (from f in delproclist
                                               where f.DateAdded < maxtime
                                               orderby f.DateAdded descending
                                                     select f).ToList<FavsToDelete>();

            progressBar1.Visible = true;
            progressBar1.Maximum = photostodeletelist.Count;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            int counter = 1;

            foreach (var pho in photostodeletelist)
            {
                try
                {
                    flickr.FavoritesRemove(pho.photoID);
                }
                catch (Exception)
                {
                    
                    //throw;
                }
                counter++;
                if (counter < photostodeletelist.Count - 1)
                {
                    progressBar1.Value = counter;
                }
                this.Text = "Deleted " + counter.ToString() + " favs from total of:" + photostodeletelist.Count.ToString();
            }

            progressBar1.Visible = false;
            progressBar1.Value = 0;


        }

        private void radioComments_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if(radio.Checked)
            {
                cmd10PhotoFavs.Text = "10 photo comments";
            }
            else
            {
                cmd10PhotoFavs.Text = "10 photo favs";
            }
        }

        

    }



    public static class ExtensionGridView
    {

        public static DataGridView HideGavnoColumns(DataGridView grdView)
        {
            List<string> MiscCols = new List<string>();
            MiscCols.Add("ItemNum");
            MiscCols.Add("UploadDT");
            MiscCols.Add("ProcessDT");
            MiscCols.Add("Location");
            MiscCols.Add("PathAls");
            MiscCols.Add("Friend");
            MiscCols.Add("Family");
            MiscCols.Add("LastPhotoID");

            foreach (DataGridViewColumn clm in grdView.Columns)
            {

                if (MiscCols.Contains(clm.Name))
                {
                    grdView.Columns[clm.Index].Visible = false;
                }
            }

            return grdView;
        }
        public static DataGridView RemoveEmptyColumns(DataGridView grdView)
        {

            foreach (DataGridViewColumn clm in grdView.Columns)
            {
                bool notAvailable = true;

                foreach (DataGridViewRow row in grdView.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells[clm.Index].Value.ToString()))
                    {
                        notAvailable = false;
                        break;
                    }

                }
                if (notAvailable)
                {
                    grdView.Columns[clm.Index].Visible = false;
                }
            }

            return grdView;
        }

        public static DataGridView SeachResultInRaws(DataGridView grdView, string svalue)
        {


            for (int r = 0; r < grdView.Rows.Count; r++)
            {

                for (int col = 0; col < grdView.Columns.Count; col++)
                {

                    if (grdView[col, r].Value != null)
                    {
                        if (grdView[col, r].Value.ToString().ToUpper().Contains(svalue.ToUpper()))
                        {
                            grdView.Rows[r].Selected = true;
                            grdView.FirstDisplayedScrollingRowIndex = r;
                            goto EXIT;
                        }
                    }

                }

            }



        EXIT:
            return grdView;
        }
    }
}
