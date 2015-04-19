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
        private int commentID;
        private int fileID;
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

        public int CommentID
        {
            get { return commentID; }
            set { commentID = value; }
        }

        public int FileID
        {
            get { return fileID; }
            set { fileID = value; }
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

        // Constructor for a likeflag on a comment.
        public LikeFlag(int likeFlagID, int accountID, int commentID, Type type, DateTime placeTime, bool isComment)
        {
            this.likeFlagID = likeFlagID;
            this.accountID = accountID;
            this.commentID = commentID;
            this.type = type;
            this.placeTime = placeTime;
        }
        // Constructor for a likeflag on a file.
        public LikeFlag(int likeFlagID, int accountID, int fileID, Type type, DateTime placeTime)
        {
            this.likeFlagID = likeFlagID;
            this.accountID = accountID;
            this.fileID = fileID;
            this.type = type;
            this.placeTime = placeTime;
        }
    }
}
