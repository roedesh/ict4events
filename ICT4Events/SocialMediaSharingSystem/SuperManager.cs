using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using System.IO;


namespace SocialMediaSharingSystem
{
    public class SuperManager
    {
        Account a = new Account();



        //  private List<Object> infos = new List<Object>();

        //  public List<Object> Infos
        // {
        //     get { return infos; }
        //      set { infos = value; }
        //  }

        PostManager postmanager = new PostManager();


        public SuperManager()
        {

        }

        public List<object> ListDirectoryContent(DirectoryInfo root)
        {
            List<object> infos = new List<object>();

            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (DirectoryNotFoundException e)
            {
                //MessageBox.Show(e.Message);
            }

            if (files != null)
            {
                foreach (FileInfo f in files)
                {
                    infos.Add(f);
                }
            }

            subDirs = root.GetDirectories();

            foreach (DirectoryInfo d in subDirs)
            {
                infos.Add(d);
            }

        }
    }

}
