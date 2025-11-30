using System;
using System.Collections.Generic;

namespace SimpleTaskTrackerAppAPI.Models;

public partial class TaskItem
{
    public int TaskId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsComplete { get; set; }
}
