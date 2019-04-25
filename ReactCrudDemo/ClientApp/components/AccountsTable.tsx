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

interface FetchAccountDataState {
    accountList: AccountData[];
    loading: boolean;
}

export class AccountsTable extends React.Component<RouteComponentProps<{}>, FetchAccountDataState> {

    constructor(props) {
        super(props);
        this.state = { accountList: [], loading: true };

        fetch('api/Account/Index')
            .then(response => response.json() as Promise<AccountData[]>)
            .then(data => {
                this.setState({ accountList: data, loading: false });
            });

        // This binding is necessary to make "this" work in the callback
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Account/Index",
                pagingType: 'full_numbers',
                lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]],
                lengthChange: true,
                columns: [
                    {data: "createdAt"},
                    {data: "updatedAt" },
                    {data: "deletedAt" },
                    {data: "onamaeId" },
                    {data: "userId" },
                    {data: "accountName" },
                    {data: "instanceId" },
                    {data: "status" },
                    {data: "stopStatus" },
                    {data: "kioskSelect" },
                    {data: "region" },
                    {data: "deleted" }
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
               <thead>
               <tr>
                   <th>createdAt</th>
                   <th>updatedAt</th>
                   <th>deletedAt</th>
                   <th>onamaeId</th>
                   <th>userId</th>
                   <th>accountName</th>
                   <th>instanceId</th>
                   <th>status</th>
                   <th>stopStatus</th>
                   <th>kioskSelect</th>
                   <th>region</th>
                   <th>deleted</th>
               </tr>
               </thead>
           </table>
       </div>;
    }

    // Handle Delete request for an account
    private handleDelete(id: string) {
        if (!confirm("Do you want to delete account with Id: " + id))
            return;
        else {
            fetch('api/Account/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        accountList: this.state.accountList.filter((rec) => {
                            return (rec.userId != id);
                        })
                    });
            });
        }
    }

    private handleEdit(id: number) {
        this.props.history.push("/account/edit/" + id);
    }
}

export class AccountData {
    createdAt: string = "";
    updatedAt: string = "";
    deletedAt: string = "";
    onamaeId: string = "";
    userId: string = "";
    accountName: string = "";
    instanceId: string = "";
    status: string = "";
    stopStatus: string = "";
    kioskSelect: string = "";
    region: string = "";
    deleted: number = 0;
}

/*

http://localhost:5000/api/Account/Index
        
{
	"createdAt": "2019-04-16T13:10:03",
	"updatedAt": "2019-04-16T13:10:03",
	"deletedAt": null,
	"onamaeId": "1483386",
	"userId": "0cc4f5a9-e60e-49ed-a71f-f7e788343bdf",
	"accountName": null,
	"instanceId": "2e79d2c0-abce-455f-a371-4e82eec2882c",
	"status": "assigned",
	"stopStatus": null,
	"kioskSelect": null,
	"region": "SZY",
	"deleted": 0
}
 */