using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class VLan
    {
        public int VlanId { get; set; }
        public int? VlanLimit { get; set; }
        public string VlanSegment { get; set; }
        public string VlanType { get; set; }
        public int? VlanEnable { get; set; }
    }
}
