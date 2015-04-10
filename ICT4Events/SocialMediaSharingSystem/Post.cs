using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public abstract class Post
    {
        private int postID;
        private int uploaderID;
        private string title;
        private int amountOfLikes;
        private int amountOfFlags;
        private bool isHidden;
        private DateTime date;

        #region Properties
        public int PostID
        {
            get { return postID; }
            set { postID = value; }
        }

        public int UploaderID
        {
            get { return uploaderID;}
            set { uploaderID = value; }
        }

        private string Title
        {
            get { return title;}
            set { title = value;}
        }

        public int AmountOfLikes
        {
            get { return amountOfLikes; }
            set { amountOfLikes = value; }
        }

        public int AmountOfFlags
        {
            get { return amountOfFlags; }
            set { amountOfFlags = value; }
        }

        public bool IsHidden
        {
            get { return isHidden; }
            set { isHidden = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        #endregion

        public Post(int postID, int uploaderID, string title, int amountOfLikes, int amountOfFlags)
        {
            this.postID = postID;
            this.uploaderID = uploaderID;
            this.title = title;
            this.amountOfLikes = amountOfLikes;
            this.amountOfFlags = amountOfFlags;

            if (this.amountOfFlags > 8)
            {
                this.isHidden = true;
            }
        }

        public override string ToString()
        {
            return Title + " - " + UploaderID + ": " + Convert.ToString(AmountOfLikes) + "likes, " + Convert.ToString(AmountOfFlags) + " flags";
        }
    }
}
