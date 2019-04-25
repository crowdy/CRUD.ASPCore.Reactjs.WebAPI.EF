using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class Instance
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string InstanceId { get; set; }
        public string VmName { get; set; }
        public string ImageId { get; set; }
        public string FlavorId { get; set; }
        public int? Vcpus { get; set; }
        public int? MemoryMb { get; set; }
        public int? DiskGb { get; set; }
        public int? VramMb { get; set; }
        public string HostId { get; set; }
        public string PowerState { get; set; }
        public int? Iops { get; set; }
        public int? VlanId { get; set; }
        public string VmType { get; set; }
        public int? Locked { get; set; }
        public int? Deleted { get; set; }
        public string VmStatus { get; set; }
    }
}
