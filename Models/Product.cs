using System;
using System.Collections.Generic;

namespace Crud_MVC_Web_Application.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }
}
