using Clinic.DAL;
using Clinic.DBContext;
using Clinic.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Database.SetInitializer<ClinicDBContext>(new DropCreateDatabaseIfModelChanges<ClinicDBContext>());
            //DoctorRepository doctor = new DoctorRepository();
            //Doctor doctor1 = new Doctor();
            //doctor1.FullName = "ali";
            //doctor.Add(doctor1);
            //doctor.save();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
