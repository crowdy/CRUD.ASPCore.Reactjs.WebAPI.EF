using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class Job
    {
        public DateTime? CreatedAt { get; set; }
        public string OnamaeId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string FlavorId { get; set; }
        public string ImageId { get; set; }
        public string ProcessName { get; set; }
        public string ProcessId { get; set; }
        public string ProcessType { get; set; }
        public string Region { get; set; }
    }
}
