using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary;
using System.IO;
using DataLibrary;


namespace SocialMediaSharingSystem
{
    public class SuperManager
    {

        PostManager pManager = new PostManager();
        AccountManager aManager = new AccountManager();
        DataManager dManager = new DataManager();

        private List<Object> infos = new List<Object>();

        public List<Object> Infos
        {
            get { return infos; }
            set { infos = value; }
        }


        public SuperManager()
        {

        }


        public bool ListDirectoryContent(DirectoryInfo root)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (DirectoryNotFoundException)
            {
                return false;
            }

            if (files != null)
            {
                foreach (FileInfo f in files)
                {
                    infos.Add(f);
                    //pManager.AddPost()
                }
            }

            subDirs = root.GetDirectories();

            foreach (DirectoryInfo d in subDirs)
            {
                infos.Add(d);
            }

            return true;
        }

        public bool UploadFile(File file)
        {
            return true;
        }

        public void CopyFile(string sourceFile, string destFile)
        {
            System.IO.File.Copy(sourceFile, destFile, true);

        }

        public File GetFile(string filePath)
        {
            return new File(1, 1, "Test title", 12, 14, "path", 2);
        }
    }

}
