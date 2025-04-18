﻿using System;
using System.Collections.Generic;

namespace Angular_and_Core_API.Server.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryDesc { get; set; }
}
