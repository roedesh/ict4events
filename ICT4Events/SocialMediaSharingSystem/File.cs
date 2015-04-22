using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public class File : Post
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public File(int postID, int uploaderID, DateTime date, string title, string filePath, int amountOfLikes, int amountOfFlags)
            : base(postID, uploaderID, date, title, amountOfLikes, amountOfFlags)
        {
            this.filePath = filePath;
        }

        /// <summary>
        /// Return a list with strings describing the file properties.
        /// Used for updating the comment info in the database.
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList()
        {
            List<string> list = new List<string>();

            list.Add(Convert.ToString(PostID));
            list.Add(Convert.ToString(AccountID));
            list.Add(Date.ToString());
            list.Add(Title);
            list.Add(FilePath);
            list.Add(Convert.ToString(AmountOfLikes)); // Amount of likes
            list.Add(Convert.ToString(AmountOfFlags)); // Amount of flags

            return list;
        }




    }
}
