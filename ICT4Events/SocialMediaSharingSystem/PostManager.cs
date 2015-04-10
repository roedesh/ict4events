using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public class PostManager
    {
        private List<Post> posts = new List<Post>();

        public List<Post> Posts
        {
            get { return posts; }
            set { posts = value; }
        }

        public PostManager()
        {

        }

        public bool LikePost(int postID, int accountID)
        {
            foreach (Post p in posts)
            {
                if (p.PostID == postID)
                {
                    p.AmountOfLikes++;
                    return true;
                }

            }
            return false;
        }

        public bool FlagPost(int postID, int accountID)
        {
            foreach (Post p in posts)
            {
                if (p.PostID == postID)
                {
                    p.AmountOfFlags++;
                    return true;
                }
            }
            return false;
        }
    }

   
    
}
