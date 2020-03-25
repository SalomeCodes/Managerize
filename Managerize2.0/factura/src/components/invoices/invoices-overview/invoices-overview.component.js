import React from 'react';
import './invoices-overview.component.css'
import InvoiceSearchbarComponent from './invoices-searchbar/invoices-searchbar.component';
import InvoiceService from '../../../services/invoice.service'

class InvoicesOverviewComponent extends React.Component {

    constructor(props) {
        super(props);
        this.invoiceService = new InvoiceService();

        this.state = {
            invoices: [],
            isLoaded: false
        }
    }

    componentDidMount() {
        this.invoiceService.retrieveItems().then(invoices => {
            // this.setState({
            //     invoices: invoices
            // })
            console.log(invoices)
        })
    }

    render() {
        const { invoices } = this.state;
        return (
            <div className="table-container">
                <h1>Invoices overview</h1>
                <InvoiceSearchbarComponent></InvoiceSearchbarComponent>
                <table>
                    <thead>
                        <tr>
                            <th className="table-cell-invoicenumber">Invoice number</th>
                            <th className="table-cell-customer">Customername</th>
                            <th className="table-cell-invoiceprice">Total price</th>
                        </tr>
                    </thead>
                    <tbody>
                        {invoices.map(i => (
                            <tr>
                                <td className="table-cell-invoicenumber">{i.invoiceNumber}</td>
                                <td className="table-cell-customer">{i.customer.name} {i.customer.prefix} {i.customer.surname}</td>
                                <td className="table-cell-invoiceprice">€ {i.totalPrice.toFixed(2)}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        );
    }

}
export default InvoicesOverviewComponent;