using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Diagnostics;
using System.IO;

namespace Relativity_Account_Disable
{
    public partial class frmMain : Form
    {
        // Assigned to this on the frmMain(string user, string pass) 
        static string username, password;

        // This will set which OUs to look inside of when running account disablement
        string container = Program.container;

        string domain = Program.domain;

        // Domain group to skip when stripping groups from users
        string group_to_skip = "CLIENT USERS";

        public frmMain(string user, string pass)
        {
            InitializeComponent();

            username = user;
            password = pass;
        }

        // Closing: if the user hit cancel
        private void btnMainCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Closing: if the user hit the x button
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Submit: When the user clicks the submit button call Submit()
        private void btnMainSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        // This will run
        // 1) Scan the text file into an array list (userList)
        // 2) Iterate through the user list (within a principalcontext) using a foreach loop
        // 3) foreach user it'll disable, and strip all groups except group_to_skip
        // 4) It'll then disable the user account
        // 5) Any users it can't find in the group_to_skip OU will export into a text file
        private void Submit()
        {
            // Read relativity user text file
            var userList = new List<string>();

            try
            {
                string[] reader = File.ReadAllLines($@"{txtMainPath.Text}");
                                
                // Save each user into a user list<string> variable
                foreach (string item in reader)
                {
                    string user = item.Substring(0, item.IndexOf('@'));
                    userList.Add(user);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Path is invalid, contains either only white space or invalid characters.", "Invalid Exception");
                return;
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("The requested path is too long.", "Path Length Exception");
                return;
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("The path was not found!", "Invalid Path");
                return;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Permission denied to read relativity user list file!", "Permission Denied");
                return;
            }
            catch
            {
                MessageBox.Show("Given path isn't supported.", "Invalid Exception");
                return;
            }

            // Run Account disable actions
            var failedUserList = new List<string>();

            PrincipalContext topLevelDirectory = new PrincipalContext(ContextType.Domain, domain);

            // holds number of iterations
            int count = 0;

            using (PrincipalContext directory = new PrincipalContext(ContextType.Domain, domain, container, username, password))
            {
                foreach (string user in userList)
                {
                    try
                    {
                        // Find user by samaccount name
                        UserPrincipal userAccount = UserPrincipal.FindByIdentity(directory, IdentityType.SamAccountName, user);

                        if (userAccount != null)
                        {
                            if (userAccount.Enabled == false)
                            {
                                count += 1;
                                continue; // skip this user iteration.
                            }

                            userAccount.Enabled = false;
                            userAccount.Save();

                            PrincipalSearchResult<Principal> groups = userAccount.GetGroups();

                            // for each group a user is apart of remove the group.
                            foreach (Principal result in groups)
                            {
                                if (result.Name.ToLower() == group_to_skip.ToLower())
                                    continue; // skip this iteration

                                GroupPrincipal groupTemp = GroupPrincipal.FindByIdentity(topLevelDirectory, result.Name);
                                groupTemp.Members.Remove(directory, IdentityType.SamAccountName, userAccount.SamAccountName);
                                groupTemp.Save();
                                groupTemp.Dispose();
                            }

                            userAccount.Dispose();

                            count += 1;

                            txtMainOutput.AppendText(Environment.NewLine + $"{user} was successfully disabled from AD.");
                            //Debug.WriteLine(user + " was successfully removed from AD.");
                        }
                        else
                        {
                            Debug.WriteLine("User not found: " + user);
                            failedUserList.Add(user);
                        }
                    }
                    catch
                    {
                        Debug.WriteLine(user + " * (exception) has failed to be disabled.");
                        failedUserList.Add(user);
                    }
                }
            }

            Debug.WriteLine(count + " number of users affected.");

            if (failedUserList.Count < 1)
            {
                MessageBox.Show("All users have been successfully disabled.", "Success");
                return;
            }

            // Export failed users into a text file.  Display path to the user.
            foreach (string item in failedUserList)
            {
                txtMainOutput.Text += Environment.NewLine + item + " has failed to be disabled.";
            }
        }
    }
}
