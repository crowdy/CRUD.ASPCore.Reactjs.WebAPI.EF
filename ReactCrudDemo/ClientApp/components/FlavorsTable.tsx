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

export class FlavorsTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Flavor/Index",
                columns: [
                    {title: "flavorId", data:"flavorId" },
                    {title: "flavorType", data:"flavorType" },
                    {title: "flavorName", data:"flavorName" },
                    {title: "vcpus", data:"vcpus" },
                    {title: "memoryMb", data:"memoryMb" },
                    {title: "diskGb", data:"diskGb" },
                    {title: "vramMb", data:"vramMb" },
                    {title: "iops", data:"iops" },
                    {title: "swapdisksizeMb", data:"swapdisksizeMb" },
                    {title: "globalEnable", data:"globalEnable" },
                    {title: "userLimit", data:"userLimit" },
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
    flavorId: string = "";
    flavorType: string = "";
    flavorName: string = "";
    vcpus: number = 0;
    memoryMb: number = 0;
    diskGb: number = 0;
    vramMb: number = 0;
    iops: number = 0;
    swapdisksizeMb: number = 0;
    globalEnable: number = 0;
    userLimit: number = 0;
}

/*

http://localhost:5000/api/Flavor/Index
        
{
	"flavorId": "31d26b23-eb2f-414f-9418-9c1725a36fd4",
	"flavorType": "STD",
	"flavorName": "C8M8",
	"vcpus": 8,
	"memoryMb": 8192,
	"diskGb": 200,
	"vramMb": 0,
	"iops": 0,
	"swapdisksizeMb": 0,
	"globalEnable": 0,
	"userLimit": 1
}
 */