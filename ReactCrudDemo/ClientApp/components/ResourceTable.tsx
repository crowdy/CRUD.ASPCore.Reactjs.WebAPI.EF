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

export class ResourceTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Resource/Index",
                columns: [
                    {title: "hostId", data:"hostId"},
                    {title: "vcpusUsed", data:"vcpusUsed"},
                    {title: "vcpuOcRate", data:"vcpuOcRate"},
                    {title: "memoryMbUsed", data:"memoryMbUsed"},
                    {title: "memoryOcRate", data:"memoryOcRate"},
                    {title: "localGbLimit", data:"localGbLimit"},
                    {title: "localGbAgree", data:"localGbAgree"},
                    {title: "localGbUsed", data:"localGbUsed"},
                    {title: "localGbOcRate", data:"localGbOcRate"},
                    {title: "localELimit", data:"localELimit"},
                    {title: "localEUsed", data:"localEUsed"},
                    {title: "localEOcRate", data:"localEOcRate"},
                    {title: "runningVms", data:"runningVms"},
                    {title: "maxRunningVms", data:"maxRunningVms"},
                    {title: "vramUsed", data:"vramUsed"},
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

export class ResourceData {
    hostId: string = "";
    vcpusUsed: number = 0;
    vcpuOcRate: number = 0;
    memoryMbUsed: number = 0;
    memoryOcRate: number = 0;
    localGbLimit: number = 0;
    localGbAgree: number = 0;
    localGbUsed: number = 0;
    localGbOcRate: number = 0;
    localELimit: number = 0;
    localEUsed: number = 0;
    localEOcRate: number = 0;
    runningVms: number = 0;
    maxRunningVms: number = 0;
    vramUsed: number = 0;
}

/*

http://localhost:5000/api/Resource/Index
        
{
	"hostId": "1",
	"vcpusUsed": 36,
	"vcpuOcRate": 6.5,
	"memoryMbUsed": 57344,
	"memoryOcRate": 0.9,
	"localGbLimit": 6144,
	"localGbAgree": 1828,
	"localGbUsed": 1339,
	"localGbOcRate": 1.5,
	"localELimit": 0,
	"localEUsed": 0,
	"localEOcRate": 0.85,
	"runningVms": 13,
	"maxRunningVms": 200,
	"vramUsed": 0
}
 */