using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public enum Type { Flag, Like };

    public class LikeFlag
    {
        private int likeFlagID;
        private int accountID;
        private int postID;
        private Type type;
        private DateTime placeTime;

        #region Properties
        public int LikeFlagID
        {
            get { return likeFlagID; }
            set { likeFlagID = value; }
        }

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public int PostID
        {
            get { return postID; }
            set { postID = value; }
        }

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        public DateTime PlaceTime
        {
            get { return placeTime; }
            set { placeTime = value; }
        }
        #endregion

        public LikeFlag(int likeFlagID, int accountID, int postID, Type type, DateTime placeTime)
        {
            this.likeFlagID = likeFlagID;
            this.accountID = accountID;
            this.postID = postID;
            this.type = type;
            this.placeTime = placeTime;
        }
    }
}
