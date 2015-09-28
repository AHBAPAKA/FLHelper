using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlickrNet;
using System.Drawing;

namespace SvetanFlickrApp
{
    public class MyFlickrContact
    {
        public int ItemNum          { get; set; }
        public string UserID        { get; set; }
        public string RealName      { get; set; }
        public string FirstName     { get; set; }
        public DateTime UploadDT    { get; set; }
        public DateTime ProcessDT   { get; set; }
        public string UserName      { get; set; }
        public Image Icon           { get; set; }
        public string Location      { get; set; }
        public string PathAls       { get; set; }
        public bool? Friend         { get; set; }
        public bool? Family         { get; set; }
        public string LastPhotoID   { get; set; }
        public Image LastPhoto      { get; set; }
        public bool IsFav           { get; set; }
        public string Comment       { get; set; }
        



        public Photo GetLatestPhoto(string LastPhotoID)
        {
            Photo photo = null;

            return photo;


        }


         
        public void ParseFullName(string FullName, out string _firstName, out string _middleInitial, out string _lastName)
        {
            _firstName = "";
            _middleInitial = "";
            _lastName = "";

            string[] parts = new string[] { };
            string[] seperators = new string[1] { " " };
            parts = FullName.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            switch (parts.Length)
            {
                case 1:
                    {
                        // OPTIONS
                        //
                        // 0=firstname
                        //
                        _firstName = parts[0];      // 0=firstname
                        break;
                    }
                case 2:
                    {
                        // OPTIONS:
                        //
                        // option1: 0=salutation, 1=lastname
                        // option2: 0=firstname, 1=lastname
                        //
                        if (parts[0].EndsWith(".")) // option2
                        {
                            try
                            {
                                //TODO: parse salutation    // 0=salutation
                            }
                            catch
                            {
                                _firstName = parts[0];      // 0=firstname
                            }
                            _lastName = parts[1];           // 1=lastname
                        }
                        else // option2
                        {
                            _firstName = parts[0];          // 0=firstname
                            _lastName = parts[1];           // 1=lastname
                        }
                        break;
                    }
                case 3:
                    {
                        // OPTIONS:
                        //
                        // option1: 0=salutation, 1=firstname, 2=lastname
                        // option2: 0=firstname, 1=middle, 2=lastname
                        // option3: 0=firstname, 1=lastname, 3=namesuffix
                        //
                        if (parts[0].EndsWith("."))
                        {
                            //TODO: parse salutation                                    // 0=salutation
                            _firstName = parts[1];                                      // 1=firstname
                            _lastName = parts[2];                                       // 2=lastname
                        }
                        else
                        {
                            _firstName = parts[0];                                      // 0=firstname
                            if (parts[1].EndsWith(".") | parts[1].Length == 1)
                            {
                                _middleInitial = parts[1].Substring(0, 1).ToUpper();    // 1=middle
                                _lastName = parts[2];                                   // 2=lastname
                            }
                            else
                            {

                                    _firstName = parts[0];                              // 0=firstname
                                    _lastName = parts[1];                               // 1=lastname
                                    //TODO: parse namesuffix                            // 3=namesuffix

                            }
                        }
                        break;
                    }
                case 4:
                    {
                        // OPTIONS:
                        //
                        // option1: 0=salutation, 1=firstname, 2=lastname, 3=namesuffix
                        // option2: 0=salutation, 1=firstname, 2=middle, 3=lastname
                        // option3: 0=firstname, 1=middle, 2=lastname, 3=namesuffix
                        //
                        if (parts[0].EndsWith(".")) //option1
                        {
                            //TODO: parse salutation                                // 0=salutation
                            _firstName = parts[1];                                  // 1=firstname

                            if (parts[2].EndsWith(".")) //option2
                            {
                                _middleInitial = parts[2].Substring(0, 1).ToUpper(); // 2=middleinitial
                                _lastName = parts[3];                               // 3=lastname
                            }
                            else //option1
                            {
                                _lastName = parts[2];                               // 2=lastname                            
                                //TODO: parse namesuffix                            // 3=namesuffix
                            }
                        }
                        else //option3
                        {
                            _firstName = parts[0];                                  // 0=firstname
                            _middleInitial = parts[1].Substring(0, 1).ToUpper();     // 1=middle
                            _lastName = parts[2];                                   // 2=lastname
                            //TODO: parse namesuffix                                // 3=namesuffix
                        }
                        break;
                    }
            }
        }


    }


    public class MyManagedContact
    {

        public enum Relation {None = 0, Contact=1, Friend=2, Family=3};

        public int ItemNum { get; set; }
        public string UserID { get; set; }
        public string RealName { get; set; }
        public DateTime LastUploadDT { get; set; }
        public DateTime ContactAddedDT { get; set; }
        public DateTime LastFavDT { get; set; }
        public DateTime LastCommentDT { get; set; }
        public string UserName { get; set; }
        public Image Icon { get; set; }

        private Relation myrelation;
        public Relation MyRelationTo
        {
            get { return myrelation; }
            set { myrelation = value; }
        }

        private Relation theirrelation;
        public Relation TheirRelationTo
        {
             
            get { return theirrelation; }
            set { theirrelation = value; }
        }
        public int? FavedMeTimes { get; set; }
        public int? CommentMeTimes { get; set; }
        public string LastPhotoID { get; set; }
        public Image LastPhoto { get; set; }
        public bool LeaveAsContact { get; set; }


    }
}
