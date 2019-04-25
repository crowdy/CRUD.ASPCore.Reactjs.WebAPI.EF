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

export class ImagesTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Image/Index",
                columns: [
                    {title: "imageId", data:"imageId" },
                    {title: "imageVname", data:"imageVname" },
                    {title: "imageName", data:"imageName" },
                    {title: "imageType", data:"imageType" },
                    {title: "imageApp", data:"imageApp" },
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
    imageId: string = "";
    imageVname: string = "";
    imageName: string = "";
    imageType: string = "";
    imageApp: string = "";
}

/*

http://localhost:5000/api/Image/Index
        
{
	"imageId": "0ae5b422-9950-4433-8466-4d7a85b0bbd1",
	"imageVname": "for MT4 windows2019",
	"imageName": "Win2019",
	"imageType": "MT4",
	"imageApp": "1001"
}
 */