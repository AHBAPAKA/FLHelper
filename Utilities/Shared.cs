using System;
using FlickrNet;

namespace SvetanFlickrApp
{
    public sealed class Shared
    {
        /// <summary>
        /// Singleton implementation
        /// </summary>
        private static volatile Shared instance;

        private static object syncRoot = new Object();
        public static Flickr flickr { get; set; }
        public static string CurUserID { get; set; }
        public static string CurUserName { get; set; }
        public static int ProcessID { get; set; }

        public static Shared Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Shared();
                    }
                }

                return instance;
            }
        }
    }
}