using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Shared.Models
{
    public partial class TestArrangement
    {
        public int Id { get; set; }
        public int? ReaderWriter { get; set; }
        public int? Test { get; set; }

        public virtual SupportStaff ReaderWriterNavigation { get; set; }
        public virtual Test TestNavigation { get; set; }
    }
}
