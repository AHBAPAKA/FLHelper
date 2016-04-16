using System;
using FlickrNet;

namespace SvetanFlickrApp
{
    public class FlickrFuncs
    {
        public static Flickr _flickr;

        public static void SetFlickr(string username = "")
        {
            string authtoken = string.Empty;
            string s_userid = string.Empty;

            if (String.IsNullOrEmpty(username)) username = "Anvar";

            if (username.Equals("Sveta"))
            {
                s_userid = Properties.Settings.Default.SvetaUserID;
                authtoken = Properties.Settings.Default.SvetaAuthToken;
            }
            else
            {
                s_userid = Properties.Settings.Default.AnvarUserID;
                authtoken = Properties.Settings.Default.AnvarAuthToken;
            }

            Shared.CurUserID = s_userid;
            Shared.CurUserName = username;

            //string secret  = Properties.Settings.Default.SharedSecret + "al";
            //string api = Properties.Settings.Default.ApiKey + "al";
            //authtoken = authtoken + "al";
            string secret = Properties.Settings.Default.SharedSecret;
            string api = Properties.Settings.Default.ApiKey;
            _flickr = GetFlickr(api, secret, authtoken);
            Shared.flickr = _flickr;
        }

        public static ContactCollection GetMyFlickrContacts(string userid)
        {
            ContactCollection retval = new ContactCollection();

            for (int i = 1; i < 10000; i++)
            {
                ContactCollection LoopCol = Shared.flickr.ContactsGetPublicList(userid, i, 100);
                if (LoopCol.Count == 0)
                {
                    break;
                }
                else
                {
                    foreach (var item in LoopCol)
                    {
                        retval.Add(item);
                    }
                }
            }

            return retval;
        }

        public static Flickr GetFlickr(string apiKey, string sharedSecret, string token)
        {
            return new Flickr(apiKey, sharedSecret, token);
        }

        public static PhotoCollection GetPhotoColForUser(string userid)
        {
            PhotoCollection retval = new PhotoCollection();
            PhotoCollection col = Shared.flickr.PeopleGetPublicPhotos(userid);
            retval = col;

            return retval;
        }

        public static PhotoCollection GetPhotoColForUser(string userid, Flickr flickr)
        {
            PhotoCollection retval = new PhotoCollection();

            try
            {
                PhotoCollection col = flickr.PeopleGetPublicPhotos(userid);
                retval = col;
            }
            catch (Exception exp)
            {
                //just to handle User Doesn't exist exeptions
                //throw;
            }

            return retval;
        }

        public static DateTime GetLastUploadedPhotoDT(string userid)
        {
            DateTime retval = DateTime.Now.AddYears(-100);
            PhotoCollection myphotos = GetPhotoColForUser(userid);
            PhotoInfo curphoto = _flickr.PhotosGetInfo(myphotos[0].PhotoId);
            if (curphoto != null) retval = curphoto.DateUploaded;
            return retval;
        }

        public static DateTime GetLastUploadedPhotoDT(string userid, Flickr flickr)
        {
            DateTime retval = DateTime.Now.AddYears(-100);
            PhotoCollection myphotos = GetPhotoColForUser(userid, flickr);
            if (myphotos.Count > 0)
            {
                PhotoInfo curphoto = flickr.PhotosGetInfo(myphotos[0].PhotoId);
                if (curphoto != null) retval = curphoto.DateUploaded;
            }
            return retval;
        }
    }
}