using System;
using System.Collections.Generic;

namespace ReactCrudDemo.Models
{
    public partial class ComputeNode
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string HostId { get; set; }
        public string Hostname { get; set; }
        public string HostType { get; set; }
        public string GroupName { get; set; }
        public int? Vcpus { get; set; }
        public int? MemoryMb { get; set; }
        public int? LocalGb { get; set; }
        public double? ExclusionRate { get; set; }
        public string CpuVendor { get; set; }
        public string HostVendor { get; set; }
        public string Mac1dev { get; set; }
        public string Mac2dev { get; set; }
        public string IpaddressExt { get; set; }
        public int? VlanExt { get; set; }
        public string GwExt { get; set; }
        public string IpaddressMg { get; set; }
        public int? VlanMg { get; set; }
        public string IpaddressSt { get; set; }
        public int? VlanSt { get; set; }
        public int? VlanVm { get; set; }
        public string DhcpStart { get; set; }
        public string DhcpEnd { get; set; }
        public string VnicStart { get; set; }
        public string VnicEnd { get; set; }
        public string RougeBase { get; set; }
        public string ImageBase { get; set; }
        public int? RemoteFx { get; set; }
        public int? VramMb { get; set; }
        public string Region { get; set; }
        public int? Deleted { get; set; }
        public int? Enabled { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public string Comment4 { get; set; }
        public string Comment5 { get; set; }
        public int? Init { get; set; }
        public int? Locked { get; set; }
    }
}
