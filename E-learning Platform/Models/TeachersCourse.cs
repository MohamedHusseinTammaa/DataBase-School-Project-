using System;
using System.Collections.Generic;

namespace E_learning_Platform.Models;

public partial class TeachersCourse
{
    public int Id { get; set; }

    public int TeacherId { get; set; }

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual User Teacher { get; set; } = null!;
}
