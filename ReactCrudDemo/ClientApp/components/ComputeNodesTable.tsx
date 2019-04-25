import * as React from 'react';
import '../css/dataTables.jqueryui.min.css' // from https://cdn.datatables.net/
import {
    Badge,
    Button,
    Card,
    CardHeader,
    CardFooter,
    DropdownMenu,
    DropdownItem,
    DropdownToggle,
    UncontrolledDropdown,
    Media,
    Pagination,
    PaginationItem,
    PaginationLink,
    Progress,
    Table,
    Container,
    Row,
    Col,
    UncontrolledTooltip
} from "reactstrap";

import * as $ from 'jquery';
// const $ = require('jquery');
import 'DataTables.net';

import { RouteComponentProps } from 'react-router';

export class ComputeNodesTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                ajax: {
                    url: '/api/ComputeNode/Index',
                    type: 'GET',
                },
                columns: [
                    {title: "updatedAt", data: "updatedAt"},
                    {title: "deletedAt", data: "deletedAt"},
                    {title: "hostId", data: "hostId"},
                    {title: "hostname", data: "hostname"},
                    {title: "hostType", data: "hostType"},
                    {title: "groupName", data: "groupName"},
                    {title: "vcpus", data: "vcpus"},
                    {title: "memoryMb", data: "memoryMb"},
                    {title: "localGb", data: "localGb"},
                    {title: "exclusionRate", data: "exclusionRate"},
                    {title: "cpuVendor", data: "cpuVendor"},
                    {title: "hostVendor", data: "hostVendor"},
                    {title: "mac1dev", data: "mac1dev"},
                    {title: "mac2dev", data: "mac2dev"},
                    {title: "ipaddressExt", data: "ipaddressExt"},
                    {title: "vlanExt", data: "vlanExt"},
                    {title: "gwExt", data: "gwExt"},
                    {title: "ipaddressMg", data: "ipaddressMg"},
                    {title: "vlanMg", data: "vlanMg"},
                    {title: "ipaddressSt", data: "ipaddressSt"},
                    {title: "vlanSt", data: "vlanSt"},
                    {title: "vlanVm", data: "vlanVm"},
                    {title: "dhcpStart", data: "dhcpStart"},
                    {title: "dhcpEnd", data: "dhcpEnd"},
                    {title: "vnicStart", data: "vnicStart"},
                    {title: "vnicEnd", data: "vnicEnd"},
                    {title: "rougeBase", data: "rougeBase"},
                    {title: "imageBase", data: "imageBase"},
                    {title: "remoteFx", data: "remoteFx"},
                    {title: "vramMb", data: "vramMb"},
                    {title: "region", data: "region"},
                    {title: "deleted", data: "deleted"},
                    {title: "enabled", data: "enabled"},
                    {title: "comment1", data: "comment1"},
                    {title: "comment2", data: "comment2"},
                    {title: "comment3", data: "comment3"},
                    {title: "comment4", data: "comment4"},
                    {title: "comment5", data: "comment5"},
                    {title: "init", data: "init"},
                    {title: "locked", data: "locked"}
                ],
                ordering: false
            }
        );
    }

    public componentWillMount() {

    }
    
    public componentWillUnmount() {
        $('.data-table-wrapper').find('table').DataTable().destroy(true);
    }

    public render() {
       return <div>
           <table className="display" ref="mytable">
           </table>
       </div>;
    }
}

export class AccountData {
    createdAt: string = "";
    updatedAt: string = "";
    deletedAt: string = "";
    hostId: string = "";
    hostname: string = "";
    hostType: string = "";
    groupName: string = "";
    vcpus: number = 0;
    memoryMb: number = 0;
    localGb: number = 0;
    exclusionRate: number = 0.0;
    cpuVendor: string = "";
    hostVendor: string = "";
    mac1dev: string = "";
    mac2dev: string = "";
    ipaddressExt: number = 0;
    vlanExt: number = 0;
    gwExt: string = "";
    ipaddressMg: string = "";
    vlanMg: number = 0;
    ipaddressSt: string = "";
    vlanSt: number = 0;
    vlanVm: number = 0;
    dhcpStart: string = "";
    dhcpEnd: string = "";
    vnicStart: string = "";
    vnicEnd: string = "";
    rougeBase: string = "";
    imageBase: string = "";
    remoteFx: number = 0;
    vramMb: number = 0;
    region: string = "";
    deleted: number = 0;
    enabled: number = 0;
    comment1: string = "";
    comment2: string = "";
    comment3: string = "";
    comment4: string = "";
    comment5: string = "";
    init: number = 0;
    locked: number = 0;
}

/*

http://localhost:5000/api/ComputeNode/Index
        
{
	"createdAt": "2019-01-23T12:01:00",
	"updatedAt": null,
	"deletedAt": null,
	"hostId": "1",
	"hostname": "dev-rn-a1100101",
	"hostType": "DTC2",
	"groupName": "dev-rn-a1100101",
	"vcpus": 48,
	"memoryMb": 250000,
	"localGb": 6963,
	"exclusionRate": 0.0,
	"cpuVendor": "AMD",
	"hostVendor": "DELL PowerEdge R6415",
	"mac1dev": null,
	"mac2dev": null,
	"ipaddressExt": "163.44.186.21",
	"vlanExt": 1000,
	"gwExt": "203.189.103.1",
	"ipaddressMg": "172.28.42.101",
	"vlanMg": 1005,
	"ipaddressSt": "172.28.43.101",
	"vlanSt": 1006,
	"vlanVm": 1007,
	"dhcpStart": "10.10.0.10",
	"dhcpEnd": "10.10.0.254",
	"vnicStart": "FC:F2:01:00:00:00",
	"vnicEnd": "FC:F2:01:FF:FF:FF",
	"rougeBase": null,
	"imageBase": null,
	"remoteFx": 0,
	"vramMb": 0,
	"region": "SZY",
	"deleted": 0,
	"enabled": 0,
	"comment1": "Enable不可",
	"comment2": null,
	"comment3": null,
	"comment4": null,
	"comment5": null,
	"init": 0,
	"locked": 0
}
 */