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
    public partial class UpdateForm : SvetanFlickrApp.AuthenticationForm
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void GetPhotoButton_Click(object sender, EventArgs e)
        {
            Flickr flickr = new Flickr(ApiKey.Text, SharedSecret.Text, AuthToken.Text);

            Auth auth = flickr.AuthCheckToken(AuthToken.Text);

            PhotoSearchOptions options = new PhotoSearchOptions(auth.User.UserId);
            options.SortOrder = PhotoSearchSortOrder.DatePostedDescending;
            options.PerPage = 1;

            PhotoCollection photos = flickr.PhotosSearch(options);

            Flickr.FlushCache(flickr.LastRequest);

            Photo photo = photos[0];

            webBrowser1.Navigate(photo.SmallUrl);

            OldTitle.Text = photo.Title;
            PhotoId.Text = photo.PhotoId;
        }

        private void UpdatePhotoButton_Click(object sender, EventArgs e)
        {

            Flickr flickr = new Flickr(ApiKey.Text, SharedSecret.Text, AuthToken.Text);

            flickr.PhotosSetMeta(PhotoId.Text, NewTitle.Text, null);

            OutputTextbox.Text += "Photo title updated";

            PhotosetCollection sets = flickr.PhotosetsGetList();
            Photoset set = sets[0];

            flickr.PhotosetsAddPhoto(set.PhotosetId, PhotoId.Text);
        }
    }
}

