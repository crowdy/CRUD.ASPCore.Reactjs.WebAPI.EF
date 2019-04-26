import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <div className='main-nav'>
            <div className='navbar navbar-inverse'>
                <div className='navbar-header'>
                    <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                        <span className='sr-only'>Toggle navigation</span>
                        <span className='icon-bar'/>
                        <span className='icon-bar'/>
                        <span className='icon-bar'/>
                    </button>
                    <Link className='navbar-brand' to={'/'}>ReactCrudDemo</Link>
                </div>
                <div className='clearfix'/>
                <div className='navbar-collapse collapse'>
                    <ul className='nav navbar-nav'>
                        <li>
                            <NavLink to={'/'} exact activeClassName='active'>
                                <span className='glyphicon glyphicon-home'/> Home
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/fetchemployee'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Fetch employee
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/simpletable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Simple Table
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/accountstable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Accounts
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/computenodestable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> ComputeNodes
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/flavorstable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Flavors
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/imagestable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Images
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/instancestable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Instances
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/jobstable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Jobs
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/kiosktable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Kiosk
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/resourcetable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> Resource
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/vlantable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'/> vlan
                            </NavLink>
                        </li>
                    </ul>
                </div>
            </div>
        </div>;
    }
}
