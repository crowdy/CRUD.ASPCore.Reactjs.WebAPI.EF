import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <div className='main-nav'>
            <div className='navbar navbar-inverse'>
                <div className='navbar-header'>
                    <button type='button' className='navbar-toggle' data-toggle='collapse' data-target='.navbar-collapse'>
                        <span className='sr-only'>Toggle navigation</span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                        <span className='icon-bar'></span>
                    </button>
                    <Link className='navbar-brand' to={'/'}>ReactCrudDemo</Link>
                </div>
                <div className='clearfix'></div>
                <div className='navbar-collapse collapse'>
                    <ul className='nav navbar-nav'>
                        <li>
                            <NavLink to={'/'} exact activeClassName='active'>
                                <span className='glyphicon glyphicon-home'></span> Home
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/fetchemployee'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Fetch employee
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/simpletable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Simple Table
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/accountstable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Accounts
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/computenodestable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> ComputeNodes
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/flavorstable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Flavors
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/imagestable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Images
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/instancestable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Instances
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/jobstable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Jobs
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/kiosktable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Kiosk
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/resourcetable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> Resource
                            </NavLink>
                        </li>
                        <li>
                            <NavLink to={'/vlantable'} activeClassName='active'>
                                <span className='glyphicon glyphicon-th-list'></span> vlan
                            </NavLink>
                        </li>
                    </ul>
                </div>
            </div>
        </div>;
    }
}
