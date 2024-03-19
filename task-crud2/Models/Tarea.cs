using System;
using System.Collections.Generic;

namespace task_crud2.Models;

public partial class Tarea
{
    public int IdTask { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }
}
