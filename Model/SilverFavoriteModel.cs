using System;
using System.Collections.Generic;


//using System.Windows.Media.Imaging;
using FlickrNet;


namespace SvetanFlickrApp.Model
{
    public class SilverFavoriteModel
    {
        private static readonly SilverFavoriteModel _instance = new SilverFavoriteModel();

        /// <summary>
        /// Returns the single instance of the app model
        /// </summary>
        /// <returns>single instance of the app model</returns>
        public static SilverFavoriteModel Instance { get { return _instance; } }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static SilverFavoriteModel()
        {
        }

        /// <summary>
        /// Private constructor for singeltom object
        /// </summary>
        private SilverFavoriteModel()
            : base()
        {
        }

        private List<FlickrFavorite> _photoList = new List<FlickrFavorite>();
        /// <summary>
        /// Data model for search result data binding
        /// </summary>
        public List<FlickrFavorite> FavoriteList
        {
            get { return _photoList; }
            set
            {
                _photoList = value;
                //NotifyPropertyChanged("FavoriteList");
            }
        }

        private int _selectedIdx = -1;

        /// <summary>
        /// Data model for selected photo index
        /// </summary>
        public int SelectedIdx
        {
            get
            {
                return _selectedIdx;
            }
            set
            {
                _selectedIdx = value;
                //NotifyPropertyChanged("SelectedPhotoSource");
                //NotifyPropertyChanged("SelectedIdx");
            }
        }

        /// <summary>
        /// Read-only property for image displaying
        /// </summary>
        public string SelectedPhotoSource
        {

            get
            {
                String retstring = String.Empty;

                //if (PhotoList.Count > 2)
                //{
                //    //Remove other user's photos
                //    List<FlickRPhoto> newPhotolist = new List<FlickRPhoto>();

                //    foreach (var photo in PhotoList)
                //    {
                //        if (photo.Owner.Equals(this.UserID))
                //        {
                //            newPhotolist.Add(photo);
                //        }

                //    }

                //    PhotoList = newPhotolist;


                //}

                retstring = (_selectedIdx < 0 || FavoriteList.Count < 2) ? "" : FavoriteList[_selectedIdx].ImageUrl;

                return retstring;
            }
        }

        private string _UserID = "42268376@N06";

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        //private string _max_fave_date = FlickrNet.UtilityMethods.DateToUnixTimestamp(DateTime.Now.AddMonths(-5));

        private string _max_fave_date = string.Empty;

        public string Max_fave_date
        {
            get { return _max_fave_date; }
            set { _min_fave_date = value; }
        }

        private string _min_fave_date = string.Empty;
        //private string _min_fave_date = FlickrNet.UtilityMethods.DateToUnixTimestamp(DateTime.Now.AddMonths(-6));

        public string Min_fave_date
        {
            get { return _min_fave_date; }
            set { _min_fave_date = value; }
        }

        private string _searchTerm = "Marquisa";
        /// <summary>
        /// Data model for search term
        /// </summary>
        public string SearchTerm
        {
            get { return _searchTerm; }
            set { _searchTerm = value; /*NotifyPropertyChanged("SearchTerm");*/ }
        }

        private bool _readySearchAgain = true;
        /// <summary>
        /// to prevent search again before previous search returns
        /// </summary>
        public bool ReadySearchAgain
        {
            get { return _readySearchAgain; }
            set { _readySearchAgain = value; }// NotifyPropertyChanged("ReadySearchAgain"); }
        }

    }
}
