using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class Resource
    {
        public string HostId { get; set; }
        public int VcpusUsed { get; set; }
        public double VcpuOcRate { get; set; }
        public int MemoryMbUsed { get; set; }
        public double MemoryOcRate { get; set; }
        public int LocalGbLimit { get; set; }
        public int LocalGbAgree { get; set; }
        public int LocalGbUsed { get; set; }
        public double LocalGbOcRate { get; set; }
        public int LocalELimit { get; set; }
        public int LocalEUsed { get; set; }
        public double LocalEOcRate { get; set; }
        public int RunningVms { get; set; }
        public int MaxRunningVms { get; set; }
        public int VramUsed { get; set; }
    }
}
