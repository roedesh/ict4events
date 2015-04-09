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

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public Comment(int postID, int uploaderID, string title, int amountOfLikes, int amountOfFlags, string message)
            : base(postID, uploaderID, title, amountOfLikes, amountOfFlags)
        {
            this.message = message;
        }

    }
}
