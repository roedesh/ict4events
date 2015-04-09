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
            get { return isHidden}
        }


        #endregion

    }
}
