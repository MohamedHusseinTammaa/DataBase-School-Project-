using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learning_Platform.Models;

public partial class Course
{
    [Required]
    [Key]
    public int CourseId { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Course name must be less than 100 characters.")]
    public string CourseName { get; set; } = null!;

    [StringLength(1000, ErrorMessage = "Description must be less than 1000 characters.")]
    public string? Description { get; set; }

 
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();
    
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
   
    public virtual ICollection<StudentsCourse> StudentsCourses { get; set; } = new List<StudentsCourse>();

    public virtual ICollection<TeachersCourse> TeachersCourses { get; set; } = new List<TeachersCourse>();
}
