using SAT.DATA.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class CourseMetadata
    {
        
        public int CourseId { get; set; }

        [Required (ErrorMessage = "*Required")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Required (ErrorMessage = "*Required")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; } = null!;

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }

        [StringLength(250, ErrorMessage = "Max 250 characters")]
        public string? Curriculum { get; set; }

        [StringLength(250, ErrorMessage = "Max 250 characters")]
        public string? Notes { get; set; }

        [Display(Name = "Active")]
        public bool? IsActive { get; set; }

    }

    public class EnrollmentMetadata
    {

        public int EnrollmentId { get; set; }


        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

    }

    public class ScheduledClassMetadata
    {

        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }


        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [StringLength(40, ErrorMessage = "Max 40 characters")]
        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Instructor")]
        public string InstructorName { get; set; } = null!;

        [Required(ErrorMessage = "*Required")]
        [StringLength(20, ErrorMessage = "Max 20 characters")]
        public string Location { get; set; } = null!;
        public int Scsid { get; set; }

    }

    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required(ErrorMessage = "*Required")]
        [Display(Name = "Scheduled Class Status")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Scsname { get; set; } = null!;

    }

    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "*Required")]
        [StringLength(20, ErrorMessage = "Max 20 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "*Required")]
        [StringLength(20, ErrorMessage = "Max 20 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [StringLength(20, ErrorMessage = "Max 20 characters")]
        public string? Major { get; set; }

        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string? Adress { get; set; }

        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string? City { get; set; }

        [StringLength(15, ErrorMessage = "Max 15 characters")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Max 10 characters")]
        [Display(Name = "Zip")]
        public string? ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(13, ErrorMessage = "Max 13 characters")]
        public string? Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [StringLength(60, ErrorMessage = "Max 60 characters")]
        public string Email { get; set; } = null!;

        [StringLength(175, ErrorMessage = "Max 175 characters")]
        [Display(Name = "Photo")]
        public string? PhotoUrl { get; set; }
        public int Ssid { get; set; }

    }

    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [Required(ErrorMessage = "*Required")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        [Display(Name = "Student Status")]
        public string Ssname { get; set; } = null!;

        [StringLength(250, ErrorMessage = "Max 250 characters")]
        [Display(Name = "Status Description")]
        public string? Ssdescription { get; set; }

    }

}
