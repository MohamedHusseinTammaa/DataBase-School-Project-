using System;
using System.Collections.Generic;

namespace E_learning_Platform.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public int CourseId { get; set; }

    public string QuestionInfo { get; set; } = null!;

    public string QuestionAnswer { get; set; } = null!;

    public int QuestionPoints { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<ExamsQuestion> ExamsQuestions { get; set; } = new List<ExamsQuestion>();
}
