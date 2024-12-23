using System;
using System.Collections.Generic;

namespace E_learning_Platform.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[] Email { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public decimal Level { get; set; }
}
