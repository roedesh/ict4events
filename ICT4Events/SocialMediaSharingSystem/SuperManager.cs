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

        PostManager postManager = new PostManager();
        AccountManager accountManager = new AccountManager();
        DataManager dataManager = new DataManager();

        private List<Object> infos = new List<Object>();

        public List<Object> Infos
        {
            get { return infos; }
            set { infos = value; }
        }

        public List<string> Paths { get; set; }

        

        public SuperManager()
        {
            Paths = new List<String>();

        }


        public File GetFile(string filePath)
        {
            List<Dictionary<string, string>> list = dataManager.GetFileByFilePath(filePath);
            File f = null;
            foreach (Dictionary<string, string> d in list)
            {
                f = new File(
                    Convert.ToInt32(d["FILEID"]),
                    Convert.ToInt32(d["ACCOUNTID"]),
                    Convert.ToInt32(d["CATEGORYID"]),
                    Convert.ToDateTime(d["DATETIMEFILE"]),
                    d["TITLE"],
                    d["FILEPATH"],
                    Convert.ToInt32(d["NUMBEROFLIKES"]),
                    Convert.ToInt32(d["NUMBEROFFLAGS"])

                    );                   
            }
            return f;
        }


        public void AddFile(int fileID, int accountID, int categoryID, DateTime date, string title, string filePath, string sourcePath)
        {
            // Add path to Paths for category-generation
            Paths.Add(filePath);

            // Add file to DB
            //List<string> list = new List<string>();

            //list.Add(Convert.ToString(fileID));
            //list.Add(Convert.ToString(accountID));
            //list.Add(Convert.ToString(categoryID));
            //list.Add(Convert.ToString(date));
            //list.Add(title);
            //list.Add(filePath);
            //list.Add("0"); // Amount of likes
            //list.Add("0"); // Amount of flags

            //dataManager.SetFile(list);

            // Add file to file server
            System.IO.File.Copy(sourcePath, filePath, true);

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
    }

}
