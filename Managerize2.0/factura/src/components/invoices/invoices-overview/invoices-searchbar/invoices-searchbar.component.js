import React from 'react';
import './invoices-searchbar.component.css'

export class InvoiceSearchbarComponent extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            searchInput: ''
        };

        // This binding is necessary to make `this` work in the callback
        this.handleClick = this.handleClick.bind(this);
        this.handleChange = this.handleChange.bind(this);
    }

    handleChange(e) {
        this.setState({ searchInput: e.target.value });
    }

    handleClick() {
        console.log(this.state.searchInput);
    }

    render() {
        return (
            <div className="searchbar">
                <input type="text" onChange={this.handleChange}></input>
                <button onClick={this.handleClick}>Zoek</button>
            </div>
        )
    }
}

export default InvoiceSearchbarComponent;
