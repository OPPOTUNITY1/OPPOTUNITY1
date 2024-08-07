using System;
using System.Collections.Generic;

namespace _18_NguyenDucTrung_Lab01_AutomobileLibrary.DataAccess;

public partial class Car
{
    public int CarId { get; set; }

    public string CarName { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public decimal Price { get; set; }

    public int ReleasedYear { get; set; }
}
