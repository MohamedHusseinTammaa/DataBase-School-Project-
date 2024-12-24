using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_learning_Platform.Models;

public partial class Answer
{
    [Required]
    public int ResultId { get; set; }

    [Required]
    public int QuestionId { get; set; }

    [Required]
    public int StudentId { get; set; }

    [Required]
    [StringLength(1000, ErrorMessage = "The answer must be less than 1000 characters.")]
    public string StudentAwnser { get; set; } = null!;

    [Required]
    public int ExamId { get; set; }

    [Required]
    public virtual Exam Exam { get; set; } = null!;

    [Required]
    public virtual Question Question { get; set; } = null!;

    [Required]
    public virtual User Student { get; set; } = null!;
}
