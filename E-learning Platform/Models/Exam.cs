﻿using System;
using System.Collections.Generic;

namespace E_learning_Platform.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public int CourseId { get; set; }

    public int TeacherId { get; set; }

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public int ExamTime { get; set; }

    public int TotalPoints { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<ExamsQuestion> ExamsQuestions { get; set; } = new List<ExamsQuestion>();

    public virtual ICollection<StudentExam> StudentExams { get; set; } = new List<StudentExam>();

    public virtual User Teacher { get; set; } = null!;
}
