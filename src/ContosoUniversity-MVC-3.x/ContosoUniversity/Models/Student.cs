using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required, Display(Name = "Last Name")]
        [StringLength(50), RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string LastName { get; set; }
        [Required, Column("FirstName"), Display(Name = "First Name")]
        [StringLength(50), RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date), Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        public string FullName => $"{LastName} {FirstMidName}";
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
