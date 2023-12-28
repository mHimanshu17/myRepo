using InterviewTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace InterviewTask.Entity
{
    public class UserContext: DbContext
    {
        public DbSet<UserDetail> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDetail>().ToTable("tbl_users");
            //modelBuilder.Entity<UserDetail>().HasNoKey();

            //seeding                                                                        
            modelBuilder.Entity<UserDetail>().HasData(
                new UserDetail() { UserId = 105, UserName = "Acc0185", Role = "A/C", LastLogin = DateTime.ParseExact("2016-05-02 14:25:34", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), FirstName = "Sanjay", LastName = "Agarwal", Department = "Accounts", DOJ = DateTime.ParseExact("2018-05-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), MgrId = 78, Seniority = 5.08, EmpCode = "ACC0034" },
                new UserDetail() { UserId = 106, UserName = "Acc0567", Role = "Asst.", FirstName = "Amit", LastName = "Sharma", Department = "Accounts", DOJ = DateTime.ParseExact("2020-09-16 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), MgrId = 105, Seniority = 8.15, EmpCode = "ACC0598" },
                new UserDetail() { UserId = 428, UserName = "Dev0476", Role = "VP", LastLogin = DateTime.ParseExact("2020-09-19 10:45:12", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), FirstName = "Lokesh", LastName = "Kumar", Department = "Development", DOJ = DateTime.ParseExact("2018-02-12 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), Seniority = 1.05, EmpCode = "DEV0833" },
                new UserDetail() { UserId = 568, UserName = "ADM6633", Role = "Exec", FirstName = "Naresh", Department = "Admin", DOJ = DateTime.ParseExact("2018-05-20 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), MgrId = 78, Seniority = 9.01, EmpCode = "ADM0048" }

                );
        }

        public List<UserDetail> sp_GetUsers(string userName)
        {
            return Users.FromSqlRaw("EXECUTE [dbo].[GetUserByUserName] @UserName = {0}", userName).ToList();
        }
    }
}
