import React, { Component } from 'react';

export class Blog extends Component {
    constructor(props) {
        super(props);
        this.state = { urlValue: '' };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange = event => {
        this.setState({ urlValue: event.target.value })
    }

    handleSubmit = event => {
        event.preventDefault();

        fetch('https://localhost:44386/api/blog/', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                url: this.state.urlValue
            })
        })
    }

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <div>
                    <h1>Blog</h1>
                    <input type="text" value={this.state.urlValue} onChange={this.handleChange} />
                    <button className="btn btn-primary" type="submit" value="Submit" />
                </div>
            </form>
        )
    }
}