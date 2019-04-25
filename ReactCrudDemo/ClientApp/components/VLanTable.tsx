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

export class VLanTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/VLan/Index",
                columns: [
                    {title: "vlanId", data:"vlanId" },
                    {title: "vlanLimit", data:"vlanLimit" },
                    {title: "vlanSegment", data:"vlanSegment" },
                    {title: "vlanType", data:"vlanType" }, 
                    {title: "vlanEnable", data:"vlanEnable" }
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

export class VLanData {
    vlanId: number = 0;
    vlanLimit: number = 0;
    vlanSegment: string = "";
    vlanType: string = "";
    vlanEnable: number = 0;
}

/*

http://localhost:5000/api/VLan/Index
        
{
	"vlanId": 1111,
	"vlanLimit": 200,
	"vlanSegment": "192.168.0.1/23",
	"vlanType": "SZY",
	"vlanEnable": 0
}
 */