import React, { Component } from 'react';
import { CreateBlog } from './CreateBlog';

export class Blog extends Component {
    constructor(props) {
        super(props);
        this.state = { urlValue: '', output: 'URL should be here' };
        this.handleChange = this.handleChange.bind(this);
        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleChange = event => {
        this.setState({ urlValue: event.target.value })
    }

    handleSubmit = event => {
        event.preventDefault();
        //<CreateBlog url={this.state.urlValue} />;
        
        const response = fetch('https://localhost:44386/api/blog/', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                url: this.state.urlValue
            })
        });
        //return response.json().data;
       
      //this.setState({output: response});
    };

    render() {
        return (
            <form onSubmit={this.handleSubmit}>
                <div>
                    <h1>Blog</h1>
                    <p>Create Blog here:</p>
                    <input type="text" value={this.state.urlValue} onChange={this.handleChange} />
                    <button className="btn btn-primary" type="submit" value="Submit" label="Submit" />
                </div>
                <div>
                    <p>
                        Output:
                        {this.state.output}
                    </p>
                </div>
            </form>
        )
    }
}