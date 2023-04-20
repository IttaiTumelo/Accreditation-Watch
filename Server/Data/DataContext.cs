global using Accreditation_Watch.Shared.General;
using Accreditation_Watch.Server.Controllers;

namespace Accreditation_Watch.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccrediteStatus>().HasData(
                 new AccrediteStatus { Id = 1, Name = "CAD_REJECTED" },
                 new AccrediteStatus { Id = 2, Name = "SENATE_REJECTED" },
                 new AccrediteStatus { Id = 3, Name = "REVISION_REQUIRED" },
                 new AccrediteStatus { Id = 4, Name = "UNDER_REVIEW" },
                 new AccrediteStatus { Id = 5, Name = "CAD_APPROVED" },
                 new AccrediteStatus { Id = 6, Name = "PENDING" },
                 new AccrediteStatus { Id = 7, Name = "HEA_APPROVED" },
                 new AccrediteStatus { Id = 8, Name = "HEA_REJECTED" },
                 new AccrediteStatus { Id = 9, Name = "CAD_APPROVED_WITH_CONDITIONS" },
                 new AccrediteStatus { Id = 10, Name = "CAD_APPROVED_WITH_CONDITIONS_AND_REVISIONS" },
                 new AccrediteStatus { Id = 11, Name = "SUBMITTED" },
                 new AccrediteStatus { Id = 12, Name = "ACCREDITED" },
                 new AccrediteStatus { Id = 13, Name = "DENIED" },
                 new AccrediteStatus { Id = 14, Name = "NOT_APPLICABLE" },
                 new AccrediteStatus { Id = 15, Name = "UNDER_INTERNAL_EVALUATION" },
                 new AccrediteStatus { Id = 16, Name = "EVALUATED" }
            );

            modelBuilder.Entity<AccrediteType>().HasData(
                new AccrediteType { Id = 1, Name = "Accredited" },
                new AccrediteType { Id = 2, Name = "Provisional" },
                new AccrediteType { Id = 3, Name = "Denied" },
                new AccrediteType { Id = 4, Name = "Withdrawn" },
                new AccrediteType { Id = 5, Name = "NotApplicable" }
                 );
            modelBuilder.Entity<School>().HasData(
                new School { Id = 1, Name = "School of Business" },
                new School { Id = 2, Name = "School of Education" },
                new School { Id = 3, Name = "School of Engineering" },
                new School { Id = 4, Name = "School of Health Sciences" },
                new School { Id = 5, Name = "School of Humanities and Social Sciences" },
                new School { Id = 6, Name = "School of Natural Sciences" },
                new School { Id = 7, Name = "School of Nursing" },
                new School { Id = 8, Name = "School of Pharmacy" },
                new School { Id = 9, Name = "School of Public Health" },
                new School { Id = 10, Name = "School of Social Work" }
                );

            // modelBuilder.Entity<Department>().HasData(
            //     new Department { Id = 1, Name = "Computer Science", SchoolId = 1 },
            //     new Department { Id = 2, Name = "Mathematics", SchoolId = 1 },
            //     new Department { Id = 3, Name = "Physics", SchoolId = 1 },
            //     new Department { Id = 4, Name = "Chemistry", SchoolId = 1 },
            //     new Department { Id = 5, Name = "Biology", SchoolId = 1 },
            //     new Department { Id = 6, Name = "English", SchoolId = 1 },
            //     new Department { Id = 7, Name = "History", SchoolId = 1 },
            //     new Department { Id = 8, Name = "Philosophy", SchoolId = 1 },
            //     new Department { Id = 9, Name = "Psychology", SchoolId = 1 },
            //     new Department { Id = 10, Name = "Sociology", SchoolId = 1 },
            //     new Department { Id = 11, Name = "Economics", SchoolId = 1 },
            //     new Department { Id = 12, Name = "Finance", SchoolId = 1 },
            //     new Department { Id = 13, Name = "Management", SchoolId = 1 },
            //     new Department { Id = 14, Name = "Marketing", SchoolId = 1 },
            //     new Department { Id = 15, Name = "Accounting", SchoolId = 1 },
            //     new Department { Id = 16, Name = "Mechanical Engineering", SchoolId = 1 },
            //     new Department { Id = 17, Name = "Electrical Engineering", SchoolId = 1 },
            //     new Department { Id = 18, Name = "Civil Engineering", SchoolId = 1 },
            //     new Department { Id = 19, Name = "Chemical Engineering", SchoolId = 1 },
            //     new Department { Id = 20, Name = "Computer Engineering", SchoolId = 1 },
            //     new Department { Id = 21, Name = "Nursing", SchoolId = 1 },
            //     new Department { Id = 22, Name = "Health Science", SchoolId = 1 },
            //     new Department { Id = 23, Name = "Health Administration", SchoolId = 1 }
            //     );

           // modelBuilder.Entity<AWProgram>().HasData(
           //     new AWProgram { Id = 1, Name = "Biology", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null },
           //     new AWProgram { Id = 2, Name = "Chemistry", StatusId = 2, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 3, Name = "Computer Science", StatusId = 3, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 4, Name = "Mathematics", StatusId = 3, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 5, Name = "Physics", StatusId = 3, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 6, Name = "Psychology", StatusId = 2, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 7, Name = "Sociology", StatusId = 3, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 8, Name = "Statistics", StatusId = 4, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 9, Name = "Theatre", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 10, Name = "Visual Arts", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 11, Name = "World Languages", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  },
           //     new AWProgram { Id = 12, Name = "African American Studies", StatusId = 2, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 13, Name = "American Studies", StatusId = 3, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 14, Name = "Anthropology", StatusId = 4, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 15, Name = "Art History", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 16, Name = "Asian Studies", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 17, Name = "Classics", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 18, Name = "Communication", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 19, Name = "Economics", StatusId = 1, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 20, Name = "English", StatusId = 2, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 21, Name = "Environmental Studies", StatusId = 2, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 22, Name = "European Studies", StatusId = 2, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true , Accredite = null },
           //     new AWProgram { Id = 23, Name = "Film Studies", StatusId = 3, ValidFrom = DateTime.Now, DepartmentId = 1, ValidTo = DateTime.Now, IsAccredited = true, Accredite = null  }
           //);
            modelBuilder.Entity<ResultType>().HasData(
                new ResultType { Id = 1, Name = "Pass" },
                new ResultType { Id = 2, Name = "Fail" },
                new ResultType { Id = 3, Name = "Not_Applicable" }
                 ); 
            
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Basic" },
                new Role { Id = 2, Name = "Secondary" },
                new Role { Id = 3, Name = "Directors" },
                new Role { Id = 4, Name = "Developer" }
                 );

            modelBuilder.Entity<TaskType>().HasData(
                new TaskType { Id = 1, Name = "Accreditation" },
                new TaskType { Id = 2, Name = "Internal_Audit" },
                new TaskType { Id = 3, Name = "External_Audit" },
                new TaskType { Id = 4, Name = "Reaccreditation" }
                 );
            
        }
        public DbSet<Accredite> Accredites { get; set; }
        public DbSet<AccrediteStatus> AccrediteStatuses { get; set; }
        public DbSet<AccrediteType> AccrediteTypes { get; set; }
        public DbSet<AWDocument> AWDocuments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<AWProgram> Programs { get; set; }
        public DbSet<ResultType> ResultTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<AWTask> AWTask { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<PendingImplimentation> PendingImplimentations { get; set; }
        public DbSet<Problem> Problems { get; set; }

    }
}
