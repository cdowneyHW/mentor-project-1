import React, { Component } from 'react';
import { CreateUser } from './CreateUser';

export class User extends Component {
    constructor(props) {
        super(props);
        this.state = { fName: 'First', lName: 'Last' };
        this.handleFChange = this.handleFChange.bind(this);
        this.handleLChange = this.handleLChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleFChange = event => {
        this.setState({ fName: event.target.value })
    }

    handleLChange = event => {
        this.setState({ lName: event.target.value })
    }

    handleSubmit = event => {
        event.preventDefault();
        //const response = <CreateUser fName={this.state.fName} lName={this.state.lName} />;
        const response = fetch('https://localhost:44386/api/user/', {
            method: "POST",
            mode: "cors",
            cache: "no-cache",
            headers: {
              "Content-Type": "application/json"
            },
            body: JSON.stringify({firstName: this.state.fName, lastName: this.state.lName})
          });
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <div>
                    <h1>User</h1>
                    <p>Create User Here:</p>
                    <input type="text" value={this.state.fName} onChange={this.handleFChange} />
                    <input type="text" value={this.state.lName} onChange={this.handleLChange} />
                    <button className="btn btn-primary" type="submit" value="Submit" label="Submit" />
                </div>
            </form>
        )
    }
}