import * as React from 'react';
import '../css/dataTables.jqueryui.min.css' // from https://cdn.datatables.net/

import * as $ from 'jquery';
// const $ = require('jquery');
import 'DataTables.net';

import { RouteComponentProps } from 'react-router';

export class KioskTable extends React.Component<RouteComponentProps<{}>, {}> {

    constructor(props) {
        super(props);
    }

    public componentDidMount() {
        $(this.refs.mytable).DataTable(
            {
                dom: '<"data-table-wrapper"t>',
                processing: true,
                serverSide: true,
                ajax: "/api/Kiosk/Index",
                columns: [
                    {title: "instanceId", data: "instanceId"}, 
                    {title: "userLimit", data: "userLimit"},
                    {title: "userEnable", data: "userEnable"},
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

export class KioskData {
    instanceId: string = "";
    userLimit: number = 0;
    userEnable: number = 0;
}

/*

http://localhost:5000/api/Kiosk/Index
        
{
	"instanceId": "192ba7a5-204a-459e-883e-691a65a76c3c",
	"userLimit": 4,
	"userEnable": 1
}
 */