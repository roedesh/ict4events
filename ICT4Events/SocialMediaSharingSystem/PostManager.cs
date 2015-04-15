using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public class PostManager
    {
        private List<Post> posts;

        public List<Post> Posts
        {
            get { return posts; }
            set { posts = value; }
        }

        public PostManager()
        {
            posts = new List<Post>();

        }

        public bool AddPost(Post post)
        {
            if(posts.Find(p => p.PostID == post.PostID) == null)
            {
                posts.Add(post);               
                return true;
            }

            return false;
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
