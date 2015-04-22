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

        private Account currentAccount;
        private bool isEmployee;

        public List<Comment> Comments
        {
            get {return postManager.Comments;}
        }

        public Account CurrentAccount
        {
            get { return currentAccount; }
            set { currentAccount = value; }
        }

        public bool IsEmployee
        {
            get { return isEmployee; }
            set { isEmployee = value; }
        }

        public SuperManager()
        {
            // Default constructor
        }

        /// <summary>
        /// Set currentAccount to the account that has logged in.
        /// Also set a bool is it is an employee.
        /// </summary>
        /// <param name="account"></param>
        public void SetLoginAccount(List<Dictionary<string, string>> account)
        {
            Dictionary<string, string> d = account[0];
            int id = Convert.ToInt32(d["ACCOUNTID"]);

            List<Dictionary<string, string>> list = dataManager.GetGuestAccount(id);

            if (list.Count == 0)
            {
                currentAccount = GetAccount(id, "employee");
                isEmployee = true;
            }
            else
            {
                currentAccount = GetAccount(id, "guest");
                isEmployee = false;
            }
        }

        /// <summary>
        /// Get an account from the database through an accountID and accountType.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Account GetAccount(int id, string type)
        {
            Account a = null;

            // Get the employee account:
            if (type == "employee")
            {
                List<Dictionary<string, string>> list = dataManager.GetEmployeeAccount(id);
                foreach (Dictionary<string, string> d in list)
                {
                    a = new Employee(Convert.ToInt32(d["ACCOUNTID"]),
                        Convert.ToInt32(d["EVENTID"]),
                        d["USERNAME"], d["PASSWORD"],
                        d["FULLNAME"], d["ADRESS"],
                        d["CITY"], d["POSTALCODE"],
                        Convert.ToDateTime(d["DATEOFBIRTH"]),
                        d["EMAIL"], d["PHONENUMBER"],
                        (AccountLibrary.Employee.AccountRole)Enum.Parse(typeof(AccountLibrary.Employee.AccountRole), d["ROLEID"]));
                }
            }
            // Get the guest account:
            else
            {
                List<Dictionary<string, string>> list = dataManager.GetGuestAccount(id);
                foreach (Dictionary<string, string> gd in list)
                {
                    a = new Guest(
                        Convert.ToInt32(gd["ACCOUNTID"]),
                        Convert.ToInt32(gd["EVENTID"]),
                        gd["USERNAME"],
                        gd["PASSWORD"],
                        gd["FULLNAME"],
                        gd["ADRESS"],
                        gd["CITY"],
                        gd["POSTALCODE"],
                        Convert.ToDateTime(gd["DATEOFBIRTH"]),
                        gd["EMAIL"],
                        gd["PHONENUMBER"],
                        gd["RFID"],
                        gd["ISPRESENT"]
                        );
                }
            }
            return a;
        }

        /// <summary>
        /// Send a like/flag to the DB.
        /// Supports likes and flags for both files and comments.
        /// </summary>
        /// <param name="postID"></param>
        /// <param name="accountID"></param>
        /// <param name="commentIndex"></param>
        /// <param name="date"></param>
        /// <param name="isLike"></param>
        public void LikeFlagPost(int postID, int accountID, int  commentIndex, DateTime date, bool isLike)
        {
            // Send a file-like to the database:
            if (commentIndex == -1 && isLike)
            {
                List<string> list = new List<string>();

                list.Add("0");
                list.Add(Convert.ToString(accountID));
                list.Add("null");
                list.Add(Convert.ToString(postID));
                list.Add(date.ToString());
                list.Add(Convert.ToString(Type.Like));

                dataManager.SetLikeOrFlag(list);

                File file = postManager.CurrentFile;
                file.AmountOfLikes++;

                dataManager.UpdateFile(file.ToStringList());
            }
            // Send a file-flag to the database:
            else if (commentIndex == -1 && !isLike)
            {
                List<string> list = new List<string>();

                list.Add("0");
                list.Add(Convert.ToString(accountID));
                list.Add("null");
                list.Add(Convert.ToString(postID));
                list.Add(date.ToString());
                list.Add(Convert.ToString(Type.Flag));

                dataManager.SetLikeOrFlag(list);

                File file = postManager.CurrentFile;
                file.AmountOfFlags++;

                dataManager.UpdateFile(file.ToStringList());
            }
            // Send a comment-like to the database:
            else if (commentIndex != -1 && isLike)
            {
                List<string> list = new List<string>();

                list.Add("0");
                list.Add(Convert.ToString(accountID));
                list.Add(Convert.ToString(postID));
                list.Add("null");
                list.Add(date.ToString());
                list.Add(Convert.ToString(Type.Like));

                dataManager.SetLikeOrFlag(list);

                Comment comment = postManager.Comments[commentIndex];
                comment.AmountOfLikes++;

                dataManager.UpdateComment(comment.ToStringList());
            }
            // Send a comment-flag to the database:
            else
            {
                List<string> list = new List<string>();

                list.Add("0");
                list.Add(Convert.ToString(accountID));
                list.Add(Convert.ToString(postID));
                list.Add("null");
                list.Add(date.ToString());
                list.Add(Convert.ToString(Type.Flag));

                dataManager.SetLikeOrFlag(list);

                Comment comment = postManager.Comments[commentIndex];
                comment.AmountOfFlags++;

                dataManager.UpdateComment(comment.ToStringList());
            }
        }

        /// <summary>
        /// Return a list with likes and flags depending on target type (comment or file).
        /// </summary>
        /// <param name="targetID"></param>
        /// <param name="targetType"></param>
        /// <param name="accountID"></param>
        /// <returns></returns>
        public List<LikeFlag> GetLikeFlag(int targetID, string targetType, int accountID)
        {
            List<LikeFlag> likeFlags = new List<LikeFlag>();

            // Return list with flagLikes for a file:
            if (targetType == "file")
            {
                List<Dictionary<string, string>> list = dataManager.GetFileLikeFlag(targetID, accountID);

                foreach (Dictionary<string, string> d in list)
                {
                    LikeFlag l = new LikeFlag(
                        Convert.ToInt32(d["LIKEFLAGID"]),
                        Convert.ToInt32(d["ACCOUNTID"]),
                        Convert.ToInt32(d["FILEID"]),
                        d["TYPELOF"] == "LIKE" ? Type.Like : Type.Flag,
                        Convert.ToDateTime(d["DATETIMELOF"])
                        );

                    likeFlags.Add(l);
                }
            }
            // Return list with flaglikes for a comments:
            else
            {
                List<Dictionary<string, string>> list = dataManager.GetCommentLikeFlag(targetID, accountID);

                foreach (Dictionary<string, string> d in list)
                {
                    LikeFlag l = new LikeFlag(
                        Convert.ToInt32(d["LIKEFLAGID"]),
                        Convert.ToInt32(d["ACCOUNTID"]),
                        Convert.ToInt32(d["COMMENTID"]),
                        d["TYPELOF"] == "LIKE" ? Type.Like : Type.Flag,
                        Convert.ToDateTime(d["DATETIMELOF"]),
                        true
                        );

                    likeFlags.Add(l);
                }
            }
            return likeFlags;
        }

        /// <summary>
        /// Get file from the database depending on a given filepath.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public File GetFile(string filePath)
        {
            List<Dictionary<string, string>> list = dataManager.GetFileByFilePath(filePath);
            File f = null;
            foreach (Dictionary<string, string> d in list)
            {
                f = new File(
                    Convert.ToInt32(d["FILEID"]),
                    Convert.ToInt32(d["ACCOUNTID"]),
                    Convert.ToDateTime(d["DATETIMEFILE"]),
                    d["TITEL"],
                    d["FILEPATH"],
                    Convert.ToInt32(d["NUMBEROFLIKES"]),
                    Convert.ToInt32(d["NUMBEROFFLAGS"])

                    );
            }
            // Set currenFile in the postManager.
            postManager.CurrentFile = f;

            return f;
        }

        /// <summary>
        /// Delete file from both the shared folder and the database.
        /// </summary>
        /// <param name="fileID"></param>
        /// <param name="filePath"></param>
        public void DeleteFile(int fileID, string filePath)
        {
            // Delete file from the shared folder:
            System.IO.File.Delete(filePath);
            // Delete file from the database:
            foreach(Comment c in postManager.Comments)
            {
                dataManager.DeleteComment(c.PostID);
            }
            dataManager.DeleteFile(fileID);

        }

        /// <summary>
        /// Delete comment and its potential child comments from the database.
        /// </summary>
        /// <param name="commentID"></param>
        public void DeleteComment(int commentID)
        {
            dataManager.DeleteComment(commentID);

            // Temporary list with comments that need to be deleted:
            List<Comment> temp = new List<Comment>();

            foreach (Comment c in postManager.Comments)
            {
                if (c.PostID == commentID || c.ParentID == commentID)
                {
                    temp.Add(c);
                }
            }

            // Delete comments from main list:
            foreach (Comment c in temp)
            {
                if (postManager.Comments.Contains(c))
                {
                    postManager.Comments.Remove(c);
                }
            }
        }

        /// <summary>
        /// Return a string with accountName based on a ID. 
        /// Used for displaying account names in the form.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetAccountName(int id)
        {
            List<Dictionary<string, string>> list = dataManager.GetAccountName(id);
            string name = "noname";
            foreach (Dictionary<string, string> d in list)
            {
                name = d["FULLNAME"];
            }

            return name;
        }

        /// <summary>
        /// Add a file to the database and copy it to the shared folder.
        /// </summary>
        /// <param name="fileID"></param>
        /// <param name="accountID"></param>
        /// <param name="categoryID"></param>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="filePath"></param>
        /// <param name="sourcePath"></param>
        public void AddFile(int fileID, int accountID, int categoryID, DateTime date, string title, string filePath, string sourcePath)
        {
            // If filepath already exist, create a new unique filepath.
            // For example: test.txt becomes test(1).txt.
            string fp = filePath;
            string[] split = filePath.Split('.');
            int i = 0;

            while (GetFile(fp) != null)
            {
                i++;
                fp = split[0] + String.Format("({0})", i) + '.' + split[1];
            }

            // Build list with properties for the database querry:
            List<string> list = new List<string>();

            list.Add(Convert.ToString(fileID));
            list.Add(Convert.ToString(accountID));
            list.Add(date.ToString());
            list.Add(title);
            list.Add(fp);
            list.Add("0"); // Amount of likes
            list.Add("0"); // Amount of flags

            dataManager.SetFile(list);

            // Copy file to the shared folder from the source path:
            System.IO.File.Copy(sourcePath, fp, true);
        }

        /// <summary>
        /// Add comment to the database and the main Comment list in postManager.
        /// </summary>
        /// <param name="commentID"></param>
        /// <param name="fileID"></param>
        /// <param name="accountID"></param>
        /// <param name="parentID"></param>
        /// <param name="date"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        public void AddComment(int commentID, int fileID, int accountID, int parentID, DateTime date, string title, string message)
        {
            List<string> list = new List<string>();

            list.Add(Convert.ToString(commentID));
            list.Add(Convert.ToString(fileID));
            list.Add(Convert.ToString(accountID));
            list.Add(parentID == 0 ? "null" : Convert.ToString(parentID));
            list.Add(Convert.ToString(date));
            list.Add(title);
            list.Add(message);
            list.Add("0");
            list.Add("0");

            dataManager.SetComment(list);
            postManager.Comments.Add(new Comment(commentID, accountID, fileID, parentID, date, title, 0, 0, message));
        }

        /// <summary>
        /// Get all the comments that belong to a certain file.
        /// </summary>
        /// <param name="fileID"></param>
        /// <returns></returns>
        public List<Comment> GetFileComments(int fileID)
        {
            postManager.Comments.Clear();

            List<Dictionary<string, string>> list = dataManager.GetComment(Convert.ToString(fileID));

            Comment c = null;
            foreach (Dictionary<string, string> d in list)
            {
                c = new Comment(
                    Convert.ToInt32(d["COMMENTID"]),
                    Convert.ToInt32(d["FILEID"]),
                    Convert.ToInt32(d["ACCOUNTID"]),
                    d["COMMENTRECU"] == "" ? 0 : Convert.ToInt32(d["COMMENTRECU"]),
                    Convert.ToDateTime(d["DATETIMECOMMENT"]),
                    d["TITEL"],
                    Convert.ToInt32(d["NUMBEROFLIKES"]),
                    Convert.ToInt32(d["NUMBEROFFLAGS"]),
                    d["MESSAGE"]
                    );

                postManager.Comments.Add(c);
            }
            return postManager.Comments;
        }
    }
}
