import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchEmployee } from './components/FetchEmployee';
import { AddEmployee } from './components/AddEmployee';
import { SimpleTable } from './components/SimpleTable';
import {AccountsTable} from "./components/AccountsTable";
import {ComputeNodesTable} from "./components/ComputeNodesTable";
import {FlavorsTable} from "./components/FlavorsTable";
import {ImagesTable} from "./components/ImagesTable";
import {InstancesTable} from "./components/InstancesTable";
import {JobsTable} from "./components/JobsTable";
import {KioskTable} from "./components/KioskTable";
import {ResourceTable} from "./components/ResourceTable";
import {VLanTable} from "./components/VLanTable";

export const routes = <Layout>
    <Route exact path='/' component={Home} />
    <Route path='/fetchemployee' component={FetchEmployee} />
    <Route path='/addemployee' component={AddEmployee} />
    <Route path='/employee/edit/:empid' component={AddEmployee} />
    <Route path='/employee/edit/:empid' component={AddEmployee} />
    <Route path='/simpletable' component={SimpleTable} />
    <Route path='/accountstable' component={AccountsTable} />
    <Route path='/computenodestable' component={ComputeNodesTable} />
    <Route path='/flavorstable' component={FlavorsTable} />
    <Route path='/imagestable' component={ImagesTable} />
    <Route path='/instancestable' component={InstancesTable} />
    <Route path='/jobstable' component={JobsTable} />
    <Route path='/kiosktable' component={KioskTable} />
    <Route path='/resourcetable' component={ResourceTable} />
    <Route path='/vlantable' component={VLanTable} />
</Layout>;