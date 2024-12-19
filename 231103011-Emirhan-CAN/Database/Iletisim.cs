using System;
using System.Collections.Generic;

namespace _231103011_Emirhan_CAN.Database;

public partial class Iletisim
{
    public int Id { get; set; }

    public string Adres { get; set; } = null!;

    public string Telno { get; set; } = null!;

    public string Konum { get; set; } = null!;
}
