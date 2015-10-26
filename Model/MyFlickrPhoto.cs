using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlickrNet;
using System.Drawing;


namespace SvetanFlickrApp
{
    public class MyFlickrPhoto
    {
        public Photo MyPhoto;
        public List<PhotoFavorite> PhotoFavList;
        public Flickr flickr;
        public List<PhotoComment> PhotoComList;
        public ContactCollection ContactsList;
        public List<Person> FriendsComList;
        public List<Person> FriendsFavList;

        public MyFlickrPhoto(Photo photo, Flickr f)
        {
            MyPhoto = photo;
            flickr = f;
           
        }
        public MyFlickrPhoto(string photoid, Flickr f)
        {
            PhotoInfo photoinfo = flickr.PhotosGetInfo(photoid);
            ActivityItemCollection activities = flickr.ActivityUserPhotos(100, "D");

            //activities[0].
            
            
            flickr = f;

        }



        public PhotoCommentCollection GetPhotoComments(string photoid)
        {
            PhotoCommentCollection retlist = flickr.PhotosCommentsGetList(photoid);
            PhotoComList = retlist.ToList<PhotoComment>();
            return retlist;

        }

        public PhotoFavoriteCollection GetPhotoFavs(string photoid)
        {
            PhotoFavoriteCollection retlist = flickr.PhotosGetFavorites(photoid);
            PhotoFavList = retlist.ToList<PhotoFavorite>();
            return retlist;

        }
        public List<Person> GetFriendsCommmented()
        {
            List<Person> retlist = null;

            foreach(var com in PhotoComList)
            {
                string uid = com.AuthorUserId;
                Contact foundfriend = ContactsList.Where(c => c.UserId == com.AuthorUserId).FirstOrDefault<Contact>();
                if(foundfriend !=null)
                {
                    //retlist.Add
                }
            };

            return retlist;
        }


    }
}
