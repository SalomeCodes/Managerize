
class InvoicesService {

    constructor() {
        this.invoices = [];
    }

    async retrieveItems() {
        fetch("http://daphneprojects.nl:4001/invoices")
            .then(res => res.json())
            .then(
                (result) => {
                    this.invoices = result;
                    console.log(result);
                },
                (error) => {
                    return error;
                }
            )
        console.log(this.invoices)
        return Promise.resolve(this.invoices);
    }
}
export default InvoicesService;