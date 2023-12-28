using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InterviewTask.Models
{

    public class UserDetail
    {
        [Key]
        public int UserId {  get; set; }
        public string? UserName { get; set; }
        public string? Role {  get; set; }
        public DateTime? LastLogin { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Department { get; set; }
        public DateTime? DOJ { get; set; }
        public int? MgrId { get; set; }
        [Range(0,9.99)]
        public double? Seniority { get; set; }
        public string? EmpCode {  get; set; }
    }
}
