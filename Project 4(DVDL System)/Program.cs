using Project_4_DVDL_System_;
using Project_4_DVDL_System_.Application;
using Project_4_DVDL_System_.Application.Application_Types;
using Project_4_DVDL_System_.Application.Local_Application;
using Project_4_DVDL_System_.Application.Renew_Local_License;
using Project_4_DVDL_System_.Drivers;
using Project_4_DVDL_System_.Login;
using Project_4_DVDL_System_.Person;
using Project_4_DVDL_System_.Tests.TestTypes;
using Project_4_DVDL_System_.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmLogin());
    }
}