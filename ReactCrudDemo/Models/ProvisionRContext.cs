using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReactCrudDemo.Models
{
    public partial class ProvisionRContext : DbContext
    {
        public ProvisionRContext()
        {
        }

        public ProvisionRContext(DbContextOptions<ProvisionRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Flavor> MFlavors { get; set; }
        public virtual DbSet<Image> MImages { get; set; }
        public virtual DbSet<Account> TAccounts { get; set; }
        public virtual DbSet<ComputeNode> TComputeNodes { get; set; }
        public virtual DbSet<Instance> TInstances { get; set; }
        public virtual DbSet<Job> TJobs { get; set; }
        public virtual DbSet<Kiosk> TKiosk { get; set; }
        public virtual DbSet<Resource> TResource { get; set; }
        public virtual DbSet<VLan> TVLan { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=150.95.32.19;Database=ProvisionR;persist security info=True;user id=sa;password=GsV@!y4QML2y9;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flavor>(entity =>
            {
                entity.HasKey(e => e.FlavorId);

                entity.ToTable("M_flavors");

                entity.Property(e => e.FlavorId)
                    .HasColumnName("flavor_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DiskGb).HasColumnName("disk_gb");

                entity.Property(e => e.FlavorName)
                    .IsRequired()
                    .HasColumnName("flavor_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlavorType)
                    .IsRequired()
                    .HasColumnName("flavor_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalEnable).HasColumnName("global_enable");

                entity.Property(e => e.Iops).HasColumnName("iops");

                entity.Property(e => e.MemoryMb).HasColumnName("memory_mb");

                entity.Property(e => e.SwapdisksizeMb).HasColumnName("swapdisksize_mb");

                entity.Property(e => e.UserLimit)
                    .HasColumnName("user_limit")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Vcpus).HasColumnName("vcpus");

                entity.Property(e => e.VramMb).HasColumnName("vram_mb");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.ImageId);

                entity.ToTable("M_images");

                entity.Property(e => e.ImageId)
                    .HasColumnName("image_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ImageApp)
                    .IsRequired()
                    .HasColumnName("image_app")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .IsRequired()
                    .HasColumnName("image_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageType)
                    .IsRequired()
                    .HasColumnName("image_type")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageVname)
                    .IsRequired()
                    .HasColumnName("image_vname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("T_accounts");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instance_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.KioskSelect)
                    .HasColumnName("kiosk_select")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OnamaeId)
                    .HasColumnName("onamae_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StopStatus)
                    .HasColumnName("stop_status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ComputeNode>(entity =>
            {
                entity.HasKey(e => e.HostId);

                entity.ToTable("T_compute_nodes");

                entity.Property(e => e.HostId)
                    .HasColumnName("host_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Comment1).HasColumnName("comment1");

                entity.Property(e => e.Comment2).HasColumnName("comment2");

                entity.Property(e => e.Comment3).HasColumnName("comment3");

                entity.Property(e => e.Comment4).HasColumnName("comment4");

                entity.Property(e => e.Comment5).HasColumnName("comment5");

                entity.Property(e => e.CpuVendor)
                    .HasColumnName("CPU_vendor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DhcpEnd)
                    .HasColumnName("dhcp_end")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.DhcpStart)
                    .HasColumnName("dhcp_start")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExclusionRate)
                    .HasColumnName("exclusion_rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GwExt)
                    .HasColumnName("gw_ext")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.HostType)
                    .HasColumnName("host_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HostVendor)
                    .HasColumnName("host_vendor")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .HasColumnName("hostname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageBase)
                    .HasColumnName("image_base")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Init)
                    .HasColumnName("init")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IpaddressExt)
                    .HasColumnName("ipaddress_ext")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.IpaddressMg)
                    .HasColumnName("ipaddress_mg")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.IpaddressSt)
                    .HasColumnName("ipaddress_st")
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.LocalGb)
                    .HasColumnName("local_gb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mac1dev)
                    .HasColumnName("mac1dev")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mac2dev)
                    .HasColumnName("mac2dev")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MemoryMb)
                    .HasColumnName("memory_mb")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteFx)
                    .HasColumnName("remote_FX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RougeBase)
                    .HasColumnName("rouge_base")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Vcpus)
                    .HasColumnName("vcpus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VlanExt).HasColumnName("vlan_ext");

                entity.Property(e => e.VlanMg).HasColumnName("vlan_mg");

                entity.Property(e => e.VlanSt).HasColumnName("vlan_st");

                entity.Property(e => e.VlanVm).HasColumnName("vlan_vm");

                entity.Property(e => e.VnicEnd)
                    .HasColumnName("vnic_end")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VnicStart)
                    .HasColumnName("vnic_start")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VramMb)
                    .HasColumnName("VRAM_mb")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Instance>(entity =>
            {
                entity.HasKey(e => e.InstanceId);

                entity.ToTable("T_instances");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instance_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeletedAt)
                    .HasColumnName("deleted_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiskGb).HasColumnName("disk_gb");

                entity.Property(e => e.FlavorId)
                    .HasColumnName("flavor_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.HostId)
                    .HasColumnName("host_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId)
                    .HasColumnName("image_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Iops)
                    .HasColumnName("iops")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Locked)
                    .HasColumnName("locked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MemoryMb).HasColumnName("memory_mb");

                entity.Property(e => e.PowerState)
                    .HasColumnName("power_state")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Vcpus).HasColumnName("vcpus");

                entity.Property(e => e.VlanId).HasColumnName("vlan_id");

                entity.Property(e => e.VmName)
                    .HasColumnName("vm_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VmStatus)
                    .HasColumnName("vm_status")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VmType)
                    .HasColumnName("vm_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VramMb)
                    .HasColumnName("vram_mb")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ProcessType, e.Region });

                entity.ToTable("T_jobs");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessType)
                    .HasColumnName("process_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlavorId)
                    .HasColumnName("flavor_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ImageId)
                    .HasColumnName("image_id")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.OnamaeId)
                    .HasColumnName("onamae_id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("process_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessName)
                    .HasColumnName("process_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .HasColumnName("user_pass")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kiosk>(entity =>
            {
                entity.HasKey(e => e.InstanceId);

                entity.ToTable("T_kiosk");

                entity.Property(e => e.InstanceId)
                    .HasColumnName("instance_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.UserEnable)
                    .HasColumnName("user_enable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserLimit).HasColumnName("user_limit");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.HostId);

                entity.ToTable("T_resource");

                entity.Property(e => e.HostId)
                    .HasColumnName("host_id")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LocalELimit).HasColumnName("local_e_limit");

                entity.Property(e => e.LocalEOcRate).HasColumnName("local_e_oc_rate");

                entity.Property(e => e.LocalEUsed).HasColumnName("local_e_used");

                entity.Property(e => e.LocalGbAgree).HasColumnName("local_gb_agree");

                entity.Property(e => e.LocalGbLimit).HasColumnName("local_gb_limit");

                entity.Property(e => e.LocalGbOcRate).HasColumnName("local_gb_oc_rate");

                entity.Property(e => e.LocalGbUsed).HasColumnName("local_gb_used");

                entity.Property(e => e.MaxRunningVms).HasColumnName("max_running_vms");

                entity.Property(e => e.MemoryMbUsed).HasColumnName("memory_mb_used");

                entity.Property(e => e.MemoryOcRate).HasColumnName("memory_oc_rate");

                entity.Property(e => e.RunningVms).HasColumnName("running_vms");

                entity.Property(e => e.VcpuOcRate).HasColumnName("vcpu_oc_rate");

                entity.Property(e => e.VcpusUsed).HasColumnName("vcpus_used");

                entity.Property(e => e.VramUsed).HasColumnName("vram_used");
            });

            modelBuilder.Entity<VLan>(entity =>
            {
                entity.HasKey(e => e.VlanId);

                entity.ToTable("T_vlan");

                entity.Property(e => e.VlanId)
                    .HasColumnName("vlan_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.VlanEnable).HasColumnName("vlan_enable");

                entity.Property(e => e.VlanLimit).HasColumnName("vlan_limit");

                entity.Property(e => e.VlanSegment)
                    .HasColumnName("vlan_segment")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VlanType)
                    .HasColumnName("vlan_type")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
