using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Model;
using System.Data.Entity;

namespace Clinic.DBContext
{
    class ClinicDBContext : DbContext
    {

        public ClinicDBContext() : base(@"Data source=MASTER-PC\SQLEXPRESS;initial catalog=Clinic; integrated security = True;")
        { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Model.Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Persone> Persones { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<AppointmentType> AppointmentTypes { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }





    }

}
