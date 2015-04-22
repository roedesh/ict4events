using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    // Manager class for saving the currently loaded file and comments.
    public class PostManager
    {
        public List<Comment> Comments { get; private set; }

        public File CurrentFile { get; set; }

        public PostManager()
        {
            Comments = new List<Comment>();
        }
    }   
}
