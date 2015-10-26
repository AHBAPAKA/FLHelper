using System;
using System.Text;
using FlickrNet;

namespace SvetanFlickrApp
{
    public class FlickrFavorite
    {

        public bool IsReadyForDelete { get; set; }
        public string Id { get; set; }
        public string Owner { get; set; }
        public bool IsFriend { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date_Faved { get; set; }
        private string _Date_Faved = DateTime.Now.ToString("d");

    }
}
