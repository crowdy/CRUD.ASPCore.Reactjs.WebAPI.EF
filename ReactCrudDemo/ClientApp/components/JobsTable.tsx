import * as React from 'react';
import '../css/dataTables.jqueryui.min.css' // from https://cdn.datatables.net/

import * as $ from 'jquery';
// const $ = require('jquery');
import 'DataTables.net';

import { RouteComponentProps } from 'react-router';

export class JobsTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Job/Index",
                columns: [
                    {title: "createdAt", data:"" },
                    {title: "updatedAt", data:"" },
                    {title: "deletedAt", data:"" },
                    {title: "onamaeId", data:"" },
                    {title: "userId", data:"" },
                    {title: "accountName", data:"" },
                    {title: "instanceId", data:"" },
                    {title: "status", data:"" },
                    {title: "stopStatus", data:"" },
                    {title: "kioskSelect", data:"" },
                    {title: "region", data:"" },
                    {title: "deleted", data:"" },
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

export class JobData {
    jobId: string = "";
}

/*

http://localhost:5000/api/Job/Index
        
[]
 */