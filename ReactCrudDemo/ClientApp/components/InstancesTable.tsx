import * as React from 'react';
import '../css/dataTables.jqueryui.min.css' // from https://cdn.datatables.net/

import * as $ from 'jquery';
// const $ = require('jquery');
import 'DataTables.net';

import { RouteComponentProps } from 'react-router';

export class InstancesTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Instance/Index",
                columns: [
                    {title: "createdAt", data:"createdAt" },
                    {title: "updatedAt", data:"updatedAt" },
                    {title: "deletedAt", data:"deletedAt" },
                    {title: "instanceId", data:"instanceId" },
                    {title: "vmName", data:"vmName" },
                    {title: "imageId", data:"imageId" },
                    {title: "flavorId", data:"flavorId" },
                    {title: "vcpus", data:"vcpus" },
                    {title: "memoryMb", data:"memoryMb" },
                    {title: "diskGb", data:"diskGb" },
                    {title: "hostId", data:"hostId" },
                    {title: "powerState", data:"powerState" },
                    {title: "iops", data:"iops" },
                    {title: "vlanId", data:"vlanId" },
                    {title: "vmType", data:"vmType" },
                    {title: "locked", data:"locked" },
                    {title: "deleted", data:"deleted" },
                    {title: "vmStatus", data:"vmStatus" },
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

export class InstancesData {
    createdAt: string = "";
    updatedAt: string = "";
    deletedAt: string = "";
    instanceId: string = "";
    vmName: string = "";
    imageId: string = "";
    flavorId: string = "";
    vcpus: number = 0;
    memoryMb: number = 0;
    diskGb: number = 0;
    hostId: string = "";
    powerState: string = "";
    iops: number = 0;
    vlanId: number = 0;
    vmType: string = "";
    locked: number = 0;
    deleted: number = 0;
    vmStatus: string = "";
}

/*

http://localhost:5000/api/Instance/Index
        
{
	"createdAt": "2019-03-28T16:03:21",
	"updatedAt": "2019-03-28T16:03:21",
	"deletedAt": null,
	"instanceId": "015606e8-63d3-4044-9971-67485c6d5e78",
	"vmName": "SDC197488201",
	"imageId": "ae875b05-2537-4ec0-b33f-41054825f2b5",
	"flavorId": "7d550c90-c2b1-4401-8c4f-3e4fab2ebb0f",
	"vcpus": 1,
	"memoryMb": 1024,
	"diskGb": 50,
	"vramMb": 0,
	"hostId": "2",
	"powerState": "OFF",
	"iops": 0,
	"vlanId": 0,
	"vmType": "STOCK_BIZ_Win2019",
	"locked": 0,
	"deleted": 0,
	"vmStatus": "active"
}
 */