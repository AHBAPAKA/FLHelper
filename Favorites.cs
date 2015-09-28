using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FlickrNet;
using System.Net;
using System.IO;
using System.Threading;
using System.Text;
using System.Media;
using System.Data.SqlServerCe;
using System.Configuration;
using System.Threading;
using SvetanFlickrApp.Model;
using System.Xml;
using System.Reflection;

namespace SvetanFlickrApp
{
    public partial class Favorites : Form
    {

        #region VRAs
        FlickrFavorite cellfav = null;
        Flickr flickr = null;
        List<FlickrFavorite> lfavs = null;
        List<string> DelList = null;
        PhotoCollection favs = null;
        string s_userid = string.Empty;
        string s_authtoken = string.Empty;
        StringBuilder sb = null;
        DateTime enddt;
        DateTime begindt;
        TimeSpan duration;
        DateTime maxFavDate = DateTime.Now;
        DateTime minFavDate = DateTime.Now;
        int GlobalPageNum = 9;
        bool bauto = false;
        #endregion VARs
        
        

        public Favorites()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.grdFavs.DataSource = null;
            grdFavs.Refresh();
            RetrieveFavs();
            this.button1.Enabled = true;
        }


        private void RetrieveFavs()
        {
            flickr = new Flickr(Properties.Settings.Default.ApiKey, Properties.Settings.Default.SharedSecret, s_authtoken);

            PhotoSearchExtras extras = new PhotoSearchExtras();
            maxFavDate = this.dtMax.Value;
            minFavDate = this.dtMin.Value;
            int pagenumber = Convert.ToUInt16(this.numPageNumber.Value);
            int perPage =Convert.ToUInt16(this.txtPerPage.Text);
            //favs = flickr.FavoritesGetPublicList(s_userid, maxFavDate, minFavDate, extras, pagenumber, perPage);
            favs = flickr.FavoritesGetList(s_userid, pagenumber, perPage);

            PopulateCustomCollection(favs);

            //PhotoCollection favs = flickr.FavoritesGetPublicList(s_userid);
            DataFuncs.BindGrid(lfavs, grdFavs);
            //this.grdFavs.DataSource = lfavs;
            
            this.lblCount.Text = lfavs.Count.ToString();
            //grdFa
        }

        private void grdFavs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            //cellphoto = dgv.CurrentRow.DataBoundItem as Photo;
            cellfav = dgv.CurrentRow.DataBoundItem as FlickrFavorite;
           // string strURL = cellphoto.MediumUrl.ToString();

            string strURL = cellfav.ImageUrl.ToString();
            this.picPhoto.Image = LoadPicture(strURL);
            //string screenName = cellphoto.UserId;
            string screenName = cellfav.Owner;
            //FoundUser user = flickr.PeopleFindByUserName(screenName);
            //string userId = user.UserId;

            Person persib = flickr.PeopleGetInfo(screenName);
            this.lblAuthor.Text = persib.UserName;

            //pictureDetail.Image = LoadPicture(strURL);



        }


        ///// <summary>
        ///// Get a bitmap directly from the web
        ///// </summary>
        ///// <param name="URL">The URL of the image</param>
        ///// <returns>A bitmap of the image requested</returns>
        //private Bitmap LoadPicture(string url)
        //{
        //    HttpWebRequest wreq;
        //    HttpWebResponse wresp;
        //    Stream mystream;
        //    Bitmap bmp;

        //    bmp = null;
        //    mystream = null;
        //    wresp = null;
        //    try
        //    {
        //        wreq = (HttpWebRequest)WebRequest.Create(url);
        //        wreq.AllowWriteStreamBuffering = true;

        //        wresp = (HttpWebResponse)wreq.GetResponse();

        //        if ((mystream = wresp.GetResponseStream()) != null)
        //            bmp = new Bitmap(mystream);
        //    }
        //    finally
        //    {
        //        if (mystream != null)
        //            mystream.Close();

        //        if (wresp != null)
        //            wresp.Close();
        //    }

        //    return (bmp);
        //}

        private void grdFavs_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void PopulateCustomCollection(PhotoCollection rowfavs)
        {
            lfavs = new List<FlickrFavorite>();
            if (sb == null)
            {
                sb = new StringBuilder();
            }
            foreach (var f in rowfavs)
            {
                if (!MyFriends().Contains(f.UserId))
                {
                    FlickrFavorite newfav = new FlickrFavorite();
                    newfav.IsReadyForDelete = false;
                    newfav.Id = f.PhotoId;
                    newfav.Owner = f.UserId;
                    newfav.IsFriend = (bool) f.IsFriend;
                    newfav.ImageUrl = f.MediumUrl.ToString();
                    newfav.Title = f.Title;
                    newfav.Date_Faved = f.DateFavorited.Value;


                    lfavs.Add(newfav);
                }
                else
                {

                    sb.Append("Excluded photo of " + f.UserId);
                    sb.AppendLine();
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


        private void btnDelete_Click(object sender, EventArgs e)
        {

            pbar.Visible = true;
            pbar.Value = 0;
            this.btnDelete.Enabled = false;
            this.button1.Enabled = false;
            this.grdFavs.Enabled = false;
            duration = new TimeSpan();
            begindt = DateTime.Now;
            DeletionProcess();
            //enddt = DateTime.Now;
            //duration = begindt.Subtract(enddt);

            lblAuthor.Text = "Deletion Process took " + duration.Minutes.ToString();
            pbar.Visible = false;
            this.btnDelete.Enabled = true;
            this.button1.Enabled = true;
            this.grdFavs.Enabled = true;
            this.grdFavs.Refresh();

            if (bauto)
            {
                this.Refresh();
                Automate();
            }
            //RetrieveFavs();
            
        }

        private void DeleteAuto()
        {

            pbar.Visible = true;
            pbar.Value = 0;
            this.btnDelete.Enabled = false;
            this.button1.Enabled = false;
            this.grdFavs.Enabled = false;
            duration = new TimeSpan();
            begindt = DateTime.Now;
            DeletionProcess();
            //enddt = DateTime.Now;
            //duration = begindt.Subtract(enddt);

            lblAuthor.Text = "Deletion Process took " + duration.Minutes.ToString();
            pbar.Visible = false;
            this.btnDelete.Enabled = true;
            this.button1.Enabled = true;
            this.grdFavs.Enabled = true;
            this.grdFavs.Refresh();

        }

        private void DeletionProcess()
        {
            DelList = new List<string>();
            sb = new StringBuilder();
            pbar.Visible = true;
            //Create Del collection
            foreach (DataGridViewRow row in this.grdFavs.Rows)
            {

                FlickrFavorite fav = row.DataBoundItem as FlickrFavorite;

                if (fav != null)
                {
                    bool bdelete = fav.IsReadyForDelete;
                    string curuser = fav.Owner;

                    bool ismyfriend = MyFriends().Contains(curuser);

                    if (!ismyfriend)
                    {
                        if (bdelete)
                        {


                            DateTime favdt = fav.Date_Faved;//(DateTime)row.Cells[6].Value;

                            if (favdt < this.maxFavDate)
                            {
                                DelList.Add(fav.Id);

                            }
                            else
                            {
                                //Application.Exit();
                            }
                        }
                    }
                    else
                    {
                        sb.Append(curuser + "is friend");
                        sb.AppendLine();
                    }
                }
            }

            int DelCount = DelList.Count;
            pbar.Minimum = 0;
            pbar.Maximum = DelCount;


            int icount = 1;
            //Loop through Collection and Delete
            foreach (string d in DelList)
            {
                try
                {
                    flickr.FavoritesRemove(d);
                    icount = icount++;
                    this.lblAuthor.Text = "Loop #" + icount.ToString() + " Deleting PhotoID " + d;
                    //pbar.PerformStep();
                }
                catch (Exception exp)
                {
                    //MessageBox.Show("Error for Photoid " + d + " " + exp.ToString());
                }

                lblAuthor.Visible = true;
                this.lblAuthor.Text = "Loop #" + icount.ToString() + " Deleting PhotoID " + d;
                pbar.Value = icount - 1;
                icount++;
            }


            // play Sound
            SystemSounds.Exclamation.Play();
            enddt = DateTime.Now;
            duration = enddt.Subtract(begindt);
            pbar.Value = 0;
            pbar.Visible = false;

            if (sb.Length > 0)
            {
                //MessageBox.Show(sb.ToString());
            }
            else
            {
                //MessageBox.Show("Process completed in " + duration.Minutes.ToString() + " minutes", "favorite Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        private void picPhoto_Click(object sender, EventArgs e)
        {

        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            //Check each item in  grid datasource
            bool bready = chk.Checked;
            List<FlickrFavorite> updatelist = new List<FlickrFavorite>();

            foreach (DataGridViewRow row in grdFavs.Rows)
            {
                FlickrFavorite fav = row.DataBoundItem as FlickrFavorite;

                if (fav != null)
                {
                    fav.IsReadyForDelete = bready;
                    updatelist.Add(fav);
                }


            }

            DataFuncs.BindGrid(updatelist, grdFavs);

        }


        private List<string> MyFriends()
        {

            List<String> retList = new List<string>();

            //retList.Add("33669907@N08"); //Russain texan
            //retList.Add("55886188@N08"); //Svetan_photography
            //retList.Add("42268376@N06"); //Marquisa

            //retList.Add("56199696@N00"); //Olga Kuprina
            //retList.Add("30524031@N02"); //Polina
            //retList.Add("34305729@N07"); //Photoma
            //retList.Add("29230346@N02"); //Nikos
            //retList.Add("25952140@N03"); //Valerio
            //retList.Add("98335148@N00"); //Lena Kovalevitch

            string docpath = Path.Combine(GetAppFolder(), @"XML\ExcludeFromDeleteFav.xml");
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
                        retList.Add(reader.Value);
                        
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            


            return retList;
        }

        private string GetAppFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        }
        private void grdFavs_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int index = e.ColumnIndex;

            
            DataGridViewColumn col =  grdFavs.Columns[index];

           // if(col.SortMode = dataGridViewSortMo

            grdFavs.Sort(col, ListSortDirection.Ascending);
            
        //    public virtual void Sort(
        //DataGridViewColumn dataGridViewColumn,
        //ListSortDirection direction
        
        }

        private void tblMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Favorites_Load(object sender, EventArgs e)
        {
            SetUser();
            SetControls();
        }


        private void SetControls()
        {
            this.dtMin.Value = Convert.ToDateTime(Properties.Settings.Default.DefMinDate);
            this.dtMax.Value = DateTime.Now.AddMonths(-3);
            this.numPageNumber.Value = 47;
            this.txtPerPage.Text = Properties.Settings.Default.DefPerpage.ToString();

         
        }

        private void SetUser()
        {
            if (this.Tag.Equals("Sveta"))
            {
                s_userid = Properties.Settings.Default.SvetaUserID;
                s_authtoken = Properties.Settings.Default.SvetaAuthToken;
                this.Text = "Marquisa Favorites";
            }

            if (this.Tag.Equals("Anvar"))
            {
                s_userid = Properties.Settings.Default.AnvarUserID;
                s_authtoken = Properties.Settings.Default.AnvarAuthToken;
                this.Text = "RussianTexan Favorites";
            }
        }

        private void cmdAuto_Click(object sender, EventArgs e)
        {
            Automate();
        }

        private void Automate()
        {
            bauto = true;
            this.Text = this.Text + " - Running in Auto Mode";
            this.Refresh();
            GlobalPageNum = (int)this.numPageNumber.Value;
            int i = 1;
            while (GlobalPageNum>0)
            {
                this.Text = "Running in Auto Mode" + " trip:" + i.ToString();
                chkAll.Checked = false;
                this.numPageNumber.Value = GlobalPageNum - 1;
                //button1_Click(null, null);
                GlobalPageNum = (int)this.numPageNumber.Value;
                chkAll.Checked = true;
                DeleteAuto();
                this.Refresh();
                i++;
            }

        }


    }
}
