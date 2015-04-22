using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public class Comment : Post
    {
        private string message;
        private int fileID;
        private int parentID;

        public int FileID
        {
            get { return fileID; }
            set { fileID = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        public Comment(int postID, int fileID, int accountID, int parentID, DateTime date, string title, int amountOfLikes, int amountOfFlags, string message)
            : base(postID, accountID, date, title, amountOfLikes, amountOfFlags)
        {
            this.fileID = fileID;
            this.parentID = parentID;
            this.message = message;
        }

        public override string ToString()
        {
            return String.Format(" - Titel: {0} ({1}) - {2} likes", Title, PostID, AmountOfLikes) + ", Hoort bij " + (parentID != 0 ? "ID: " + Convert.ToString(parentID) : "n.v.t");
        }

        /// <summary>
        /// Return a list with strings describing the comment properties.
        /// Used for updating the comment info in the database.
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList()
        {
            List<string> list = new List<string>();

            list.Add(Convert.ToString(PostID));
            list.Add(Convert.ToString(FileID));
            list.Add(Convert.ToString(AccountID));
            list.Add(ParentID == 0 ? "null" : Convert.ToString(ParentID));
            list.Add(Date.ToString());
            list.Add(Title);
            list.Add(Message);
            list.Add(Convert.ToString(AmountOfLikes)); // Amount of likes
            list.Add(Convert.ToString(AmountOfFlags)); // Amount of flags

            return list;
        }
    }
}
