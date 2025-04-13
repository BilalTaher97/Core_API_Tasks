using System;
using System.Collections.Generic;

namespace Angular_and_Core_API.Server.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductDesc { get; set; }
}
