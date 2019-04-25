using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class Account
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string OnamaeId { get; set; }
        public string UserId { get; set; }
        public string AccountName { get; set; }
        public string InstanceId { get; set; }
        public string Status { get; set; }
        public string StopStatus { get; set; }
        public string KioskSelect { get; set; }
        public string Region { get; set; }
        public int Deleted { get; set; }
    }
}
