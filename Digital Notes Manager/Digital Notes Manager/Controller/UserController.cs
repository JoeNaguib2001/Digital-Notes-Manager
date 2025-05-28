using Digital_Notes_Manager.moduels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Digital_Notes_Manager.Controller
{
    public class UserController
    {
        private readonly ManageNoteContext context;

        public UserController()
        {
            context = new ManageNoteContext();
        }

        public List<User> ViewAllUsers()
        {
            return context.Users.ToList();
        }

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

        public User? GetUserByUserName(string userName)
        {
            var found = context.Users.FirstOrDefault(u => u.Username == userName);
            if (found != null)
                return found;

            return null;
        }


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
        public bool ValidateUserName(string userName)
        {
            if (userName != null || userName != "")
            {
                return true;
            }
            return false;
        }

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
