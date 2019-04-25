using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class Kiosk
    {
        public string InstanceId { get; set; }
        public int? UserLimit { get; set; }
        public int? UserEnable { get; set; }
    }
}
