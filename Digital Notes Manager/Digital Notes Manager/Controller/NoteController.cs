using Digital_Notes_Manager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Digital_Notes_Manager.Controller
{
    public class NoteController
    {
        private readonly ManageNoteContext context;

        public NoteController()
        {
            context = new ManageNoteContext();
        }

        //==================== View All Notes ======================================

        /// <summary>
        /// This Function to View All Notes 
        /// in The Notes Table to Specific user
        /// </summary>
        /// <returns>All Notes</returns>
        public List<Note> ViewAllNotes()
        {
            return context.Notes.ToList();
        }

        //==================== Get User ======================================

        /// <summary>
        /// To Get User By his ID
        /// </summary>
        /// <param name="id">UserID</param>
        /// <returns>User Object</returns>
        public User? GetUserById(int id)
        {
            try
            {
                return context.Users.FirstOrDefault(u => u.UserID == id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        ///  To Get User By his UserName
        /// </summary>
        /// <param name="userName">UserName</param>
        /// <returns>User Object</returns>
        public User? GetUserByUserName(string userName)
        {
            var found = context.Users.FirstOrDefault(u => u.Username == userName);
            if (found != null)
                return found;

            return null;
        }

        //==================== Add New User ======================================

        /// <summary>
        /// To Create a New User 
        /// first,  Search if user found or not
        /// if not => Create new user
        /// </summary>
        /// <param name="user">User Object from form inputs</param>
        public void AddUser(User user)
        {
            var found = context.Users.Any(u => u.Username == user.Username);
            if (!found)
            {
                bool validUserName = ValidateUserName(user.Username);
                bool validPassword = ValidatePassword(user.Password);

                if (validUserName && validPassword)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
            }
        }

        //==================== Update User ======================================

        //public bool UpdateUser(User user)
        //{
        //    bool validUserName = ValidateUserName(user.Username);
        //    bool validPassword = ValidatePassword(user.Password);

        //    if (validUserName && validPassword)
        //    {
        //        context.Users.Attach(user);
        //        context.Entry(user).State = EntityState.Modified;
        //        context.SaveChanges();

        //        return true;
        //    }
        //    return false;
        //}

        /// <summary>
        /// Update User if he is Login and can Edit 
        /// his Fields
        /// </summary>
        /// <param name="user">User Object from form inputs</param>
        /// <returns>bool</returns>
        public bool UpdateUserLogged(User user)
        {
            bool validUserName = ValidateUserName(user.Username);
            bool validPassword = ValidatePassword(user.Password);

            if (validUserName && validPassword)
            {
                var found = context.Users.AsTracking().FirstOrDefault(u => u.Username == user.Username);
                if (found != null)
                {
                    found.Username = user.Username;
                    found.Password = user.Password;

                    try
                    {
                        context.SaveChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Update Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return false;
        }

        //==================== Delete User ======================================

        ///<summary>
        /// Delete User by ID if he Found
        /// </summary>
        /// <param name="id">UserID</param>
        /// <returns>bool</returns>
        public bool RemoveUser(int id)
        {
            var found = context.Users.AsTracking().FirstOrDefault(u => u.UserID == id);
            if (found != null)
            {
                context.Users.Remove(found);

                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }


        //==================== Validate ======================================

        /// <summary>
        /// Validates the specified user name to ensure it is not null or empty.
        /// </summary>
        /// <param name="userName">The user name to validate.</param>
        /// <returns><see langword="true"/> if the <paramref name="userName"/> is not null or empty;  otherwise, <see
        /// langword="false"/>. </returns>
        public bool ValidateUserName(string userName)
        {
            if (userName != null || userName != "")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates whether the provided password meets basic non-null and non-empty criteria.
        /// </summary>
        /// <param name="password">The password to validate. Cannot be null or an empty string.</param>
        /// <returns><see langword="true"/> if the password is not null or empty; otherwise, <see langword="false"/>.</returns>
        public bool ValidatePassword(string password)
        {
            if (password != null || password != "")
            {
                return true;
            }
            return false;
        }


    }
}
