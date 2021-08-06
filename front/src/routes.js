import { BrowserRouter, Route, Switch } from "react-router-dom";

import Home from '../src/pages/home'

export default function Routes() {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={Home} />
            </Switch>
        </BrowserRouter>
    )
}