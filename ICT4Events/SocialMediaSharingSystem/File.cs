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
        private int categorieID;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public int CategorieID
        {
            get { return categorieID; }
            set { categorieID = value; }
        }

        public File(int postID, int uploaderID, string title, int amountOfLikes, int amountOfFlags, string filePath, int categorieID)
            : base(postID, uploaderID, title, amountOfLikes, amountOfFlags)
        {
            this.filePath = filePath;
            this.categorieID = categorieID;
        }
    }
}
