using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSharingSystem
{
    public class PostManager
    {
        public List<File> Files { get; private set; }
        public List<Comment> Comments { get; private set; }



        public PostManager()
        {
            Files = new List<File>();
            Comments = new List<Comment>();
        }

        public bool AddFile(File file)
        {
            File exists = Files.Find(f => f.PostID == file.PostID);
            if (exists != null && file.PostID != 0)
            {
                return false;
            }
            Files.Add(file);
            return true;
        }

        public bool RemoveFile(int id)
        {
            File file = Files.Find(f => f.PostID == id);
            if (file != null)
            {
                Files.Remove(file);
                return true;
            }

            return false;
        }


    }   
}
