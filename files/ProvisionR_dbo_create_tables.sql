create table M_flavors
(
	flavor_id varchar(36) not null
		constraint PK_M_flavors
			primary key,
	flavor_type varchar(255) not null,
	flavor_name varchar(255) not null,
	vcpus int not null,
	memory_mb int not null,
	disk_gb int not null,
	vram_mb int not null,
	iops int constraint DF_M_flavors_iops default 0 not null,
	swapdisksize_mb int constraint DF_M_flavors_EphemeralDiskSize default 0 not null,
	global_enable int constraint DF_M_flavors_global_enable default 0 not null,
	user_limit int constraint DF_M_flavors_user_limit default 1 not null
)
go

create table M_images
(
	image_id varchar(36) not null
		constraint PK_M_image
			primary key,
	image_vname nvarchar(50) not null,
	image_name varchar(255) not null,
	image_type varchar(255) constraint DF_M_images_kiosk_enabled default 0 not null,
	image_app varchar(255) not null
)
go

create table T_accounts
(
	created_at datetime,
	updated_at datetime,
	deleted_at datetime,
	onamae_id varchar(255),
	user_id varchar(36) not null
		constraint PK_T_accounts
			primary key,
	account_name varchar(255),
	instance_id varchar(36),
	status varchar(255) constraint DF_T_accounts_Enabled default 1,
	stop_status varchar(255),
	kiosk_select varchar(255),
	region varchar(255),
	deleted int constraint DF_T_accounts_deleted default 0 not null
)
go

create table T_compute_nodes
(
	created_at datetime,
	updated_at datetime,
	deleted_at datetime,
	host_id varchar(36) not null
		constraint PK_T_compute_nodes
			primary key,
	hostname varchar(255),
	host_type varchar(255),
	group_name varchar(255),
	vcpus int constraint DF_T_compute_nodes_vcpus default 0,
	memory_mb int constraint DF_T_compute_nodes_memory_mb default 0,
	local_gb int constraint DF_T_compute_nodes_local_gb default 0,
	exclusion_rate float constraint DF_T_compute_nodes_exclusion_rate default 0,
	CPU_vendor varchar(255),
	host_vendor varchar(255),
	mac1dev varchar(255),
	mac2dev varchar(255),
	ipaddress_ext varchar(39),
	vlan_ext int,
	gw_ext varchar(39),
	ipaddress_mg varchar(39),
	vlan_mg int,
	ipaddress_st varchar(39),
	vlan_st int,
	vlan_vm int,
	dhcp_start varchar(39),
	dhcp_end varchar(39),
	vnic_start varchar(255),
	vnic_end varchar(255),
	rouge_base varchar(255),
	image_base varchar(255),
	remote_FX int constraint DF_T_compute_nodes_remote_FX default 0,
	VRAM_mb int constraint DF_T_compute_nodes_VRAM_USED default 0,
	region varchar(255),
	deleted int constraint DF_compute_nodes_deleted default 0,
	Enabled int constraint DF_T_compute_nodes_Enabled default 1,
	comment1 nvarchar(max),
	comment2 nvarchar(max),
	comment3 nvarchar(max),
	comment4 nvarchar(max),
	comment5 nvarchar(max),
	init int constraint DF_T_compute_nodes_init default 1,
	locked int constraint DF_T_compute_nodes_locked default 0
)
go

create table T_instances
(
	created_at datetime,
	updated_at datetime,
	deleted_at datetime,
	instance_id varchar(36) not null
		constraint PK_T_instances
			primary key,
	vm_name varchar(255),
	image_id varchar(36),
	flavor_id varchar(36),
	vcpus int,
	memory_mb int,
	disk_gb int,
	vram_mb int constraint DF_T_instances_vram_mb default 0,
	host_id varchar(36),
	power_state varchar(255),
	iops int constraint DF_T_instances_iops default 0,
	vlan_id int,
	vm_type varchar(255),
	locked int constraint DF_T_instances_locked default 0,
	deleted int constraint DF_T_instances_deleted default 0,
	vm_status varchar(255)
)
go

create table T_jobs
(
	created_at datetime,
	onamae_id varchar(255),
	user_id varchar(36) not null,
	user_name varchar(255),
	user_pass varchar(255),
	flavor_id varchar(36),
	image_id varchar(36),
	process_name varchar(255),
	process_id varchar(8),
	process_type varchar(255) not null,
	region varchar(255) not null,
	constraint PK_T_jobs_1
		primary key (user_id, process_type, region)
)
go

create table T_kiosk
(
	instance_id varchar(36) not null
		constraint PK_T_kiosk
			primary key,
	user_limit int,
	user_enable int constraint DF_T_kiosk_user_enable default 0
)
go

create table T_resource
(
	host_id varchar(36) not null
		constraint PK_T_resource
			primary key,
	vcpus_used int constraint DF_T_resource_vcpus_used default 0 not null,
	vcpu_oc_rate float constraint DF_T_resource_vcpu_oc_rate default 0 not null,
	memory_mb_used int constraint DF_T_resource_memory_mb_used default 0 not null,
	memory_oc_rate float constraint DF_T_resource_memory_oc_rate default 0 not null,
	local_gb_limit int constraint DF_T_resource_local_gb_limit default 0 not null,
	local_gb_agree int constraint DF_T_resource_local_gb_agree default 0 not null,
	local_gb_used int constraint DF_T_resource_local_gb_used default 0 not null,
	local_gb_oc_rate float constraint DF_T_resource_local_gb_oc_rate default 0 not null,
	local_e_limit int constraint DF_T_resource_local_e_limit default 0 not null,
	local_e_used int constraint DF_T_resource_local_e_used default 0 not null,
	local_e_oc_rate float constraint DF_T_resource_local_e_oc_rate default 0 not null,
	running_vms int constraint DF_T_resource_running_vms default 0 not null,
	max_running_vms int constraint DF_T_resource_max_running_vms default 0 not null,
	vram_used int constraint DF_T_resource_vram_used default 0 not null
)
go

create table T_vlan
(
	vlan_id int not null
		constraint PK_T_vlan
			primary key,
	vlan_limit int,
	vlan_segment varchar(255),
	vlan_type varchar(255),
	vlan_enable int
)
go
