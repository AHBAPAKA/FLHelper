using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlickrNet;
using System.Drawing;


namespace SvetanFlickrApp.Model
{
    public class MyFlickrPhoto
    {
        public Photo MyPhoto;
        public List<PhotoFavorite> PhotoFavList;
        public Flickr flickr;
        public List<PhotoComment> PhotoComList;

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
            //retlist[0].
            return retlist;

        }

        public PhotoFavoriteCollection GetPhotoFavs(string photoid)
        {
            PhotoFavoriteCollection retlist = flickr.PhotosGetFavorites(photoid);
            //retlist[0].
            return retlist;

        }





    }
}
