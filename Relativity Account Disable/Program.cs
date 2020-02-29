/*
 * Author: Timothy Eggers
 * Purpose: We needed to be able to mass disable accounts at the end of the month that were inactive in an application called Relativity
 * In Relativity we would filter by last activity and pull a report into a text file, which could then be parsed in here and have accounts disabled.
 * People using this tool have a front end user interface (in our system administrator team) so wouldnt need to have coding knowledge ot use this 
 * very specific-purpose tool. 
 * 
 * Also editted and modified some things so I could put this on github, but editting the right variables should allow usage.
 * 
 * Will throw an exception on run if domain/container is not reachable.
 * 
 * How to use:
 * Usage of Mass Account Disable tool
 * 1) Create text file with users seperated by a new line
 * 2) Save the file, and open it up in this tool.  Once the text file is loaded in the tool click Run
 * 3) If any user accounts failed to pop up, it'll notify you of each one and will require manual cleanup
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace Relativity_Account_Disable
{
    class Program
    {
        // This will set which OUs to look for
        // i.e. OU=Target,DC=domain,DC=local
        // sub OU's are reversed, so OU=SUB,OU=ROOT
        public static string container = "OU=Target,DC=domain,DC=local";

        public static string domain = "domain.local";

        // enum ContextOptions.Negotiate will either uset NTLM or Kerberos.  In our login form it'll use kerberos to auth.
        // We can't pass contextoptions.seal (kerberos) directly until calling negotiate first.
        // Check out the link below for more auth options, but for our specific we use kerberos
        // https://docs.microsoft.com/en-us/dotnet/api/system.directoryservices.accountmanagement.contextoptions?redirectedfrom=MSDN&view=netframework-4.8
        public static PrincipalContext directory = new PrincipalContext(ContextType.Domain, domain, container, ContextOptions.Negotiate);


        // Entry point
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var credentials = new frmLogin();
            credentials.Show();
            Application.Run();
        }

        // Once credentials have been validated in form_login.cs, this method will call and
        // initiate a new instance of Form_Main.cs
        // We also want to dispose of form_login, which is done in form_login.cs
        public static void OnAuthenticate(string user, string pass)
        {
            var mainForm = new frmMain(user, pass);
            mainForm.Show();
        }
    }
}
