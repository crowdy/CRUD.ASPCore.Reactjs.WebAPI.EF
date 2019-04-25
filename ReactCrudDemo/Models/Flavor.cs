using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class Flavor
    {
        public string FlavorId { get; set; }
        public string FlavorType { get; set; }
        public string FlavorName { get; set; }
        public int Vcpus { get; set; }
        public int MemoryMb { get; set; }
        public int DiskGb { get; set; }
        public int VramMb { get; set; }
        public int Iops { get; set; }
        public int SwapdisksizeMb { get; set; }
        public int GlobalEnable { get; set; }
        public int UserLimit { get; set; }
    }
}
