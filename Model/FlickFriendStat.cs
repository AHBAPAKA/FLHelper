using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SvetanFlickrApp
{
    public class FlickFriendStat
    {
        public bool IsReadyUnfriend { get; set; }
        public string UserID { get; set; }
        public string RealName { get; set; }
        public string FirstName { get; set; }
        public DateTime LastUploadDT { get; set; }
        public DateTime LastFavedMeDT { get; set; }
        public DateTime LastCommentedMeDT { get; set; }
    }
}
