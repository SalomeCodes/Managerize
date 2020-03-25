import { Component, Input } from '@angular/core';
import pdfMake from 'pdfmake/build/pdfmake';
import pdfFonts from 'pdfmake/build/vfs_fonts';
import { Invoice } from 'src/app/models/Invoice';
import { Customer } from 'src/app/models/Customer';
import { InvoiceLine } from 'src/app/models/InvoiceLine';
import { CurrencyPipe } from '@angular/common';
import { faFilePdf } from '@fortawesome/free-solid-svg-icons';

pdfMake.vfs = pdfFonts.pdfMake.vfs;

@Component({
  selector: 'app-pdfmaker',
  templateUrl: './pdfmaker.component.html',
  styleUrls: ['./pdfmaker.component.scss']
})
export class PdfmakerComponent {
  faFilePdf = faFilePdf;

  @Input() invoice: Invoice;
  @Input() buttonText: string;

  constructor(private readonly currencyPipe: CurrencyPipe) { }
  
  generateInvoicePdf() {
    if (this.invoice.invoiceNumber) {

      const invoice = this.invoice;
      const totalePrijsExcl = this.calculateTotalPriceExcl(
        invoice.invoiceLines
      );
      const totalePrijsIncl = this.calculateTotalPriceIncl(
        invoice.invoiceLines
      );

      const documentDefinition = {
        footer: [
          {
            alignment: 'center',
            text: `U wordt verzocht binnen 30 dagen ${this.currencyPipe.transform(totalePrijsIncl, 'EUR')} ` +
              `over te maken naar rekeningnummer: NL75 ABNA 00058 54051 onder vermelding van factuurnummer: ${invoice.invoiceNumber}`,
            margin: [30, 0]
          }
        ],
        content: [
          {
            columns: this.generateBedrijfsgegevens()
          },
          [this.generateAfleverAdres(invoice.customer)],
          {
            text: 'Factuur',
            margin: [0, 40, 0, 0],
            fontSize: 22,
            bold: true
          },
          {
            columns: [
              {
                width: 100,
                text: 'Factuurdatum : '
              },
              {
                text: new Date(invoice.creationDate).toLocaleDateString('nl-NL')
              }
            ]
          },
          {
            columns: [
              {
                width: 100,
                text: 'Factuurnummer : '
              },
              {
                text: invoice.invoiceNumber
              }
            ]
          },

          [
            {
              margin: [0, 40, 0, 0],
              layout: 'noBorders',
              table: {
                headerRows: 1,
                widths: [250, 50, 100, 80],

                body: this.generateFactuurRegels(invoice.invoiceLines)
              }
            }
          ],
          {
            columns: [
              { text: ' ' },
              {
                fontSize: 10,
                width: 100,
                margin: [0, 10, 0, 0],
                text: 'Subtotaal'
              },
              {
                fontSize: 10,
                width: 50,
                margin: [0, 10, 0, 0],
                text: ': €'
              },
              {
                fontSize: 10,
                width: 100,
                margin: [0, 10, 10, 0],
                alignment: 'right',
                text: `${this.currencyPipe.transform(totalePrijsExcl, ' ')}`
              }
            ]
          },
          {
            columns: [
              { text: ' ' },
              {
                fontSize: 10,
                width: 100,
                margin: [0, 0, 0, 0],
                text: 'BTW 21%'
              },
              {
                fontSize: 10,
                width: 50,
                margin: [0, 0, 0, 0],
                text: ': €'
              },
              {
                fontSize: 10,
                width: 100,
                margin: [0, 0, 10, 0],
                alignment: 'right',
                text: `${this.currencyPipe.transform(totalePrijsExcl * 0.21, ' ')}`
              }
            ]
          },
          {
            columns: [
              { text: ' ' },
              {
                width: 100,
                margin: [0, 30, 0, 0],
                text: 'Totaal te voldoen',
                bold: true
              },
              {
                width: 50,
                margin: [0, 30, 0, 0],
                text: ': €'
              },
              {
                width: 100,
                margin: [0, 30, 10, 0],
                text: `${this.currencyPipe.transform(totalePrijsIncl, ' ')}`,
                alignment: 'right'
              }
            ]
          },

        ]
      };
      pdfMake.createPdf(documentDefinition).open();
    }
  }

  generateBedrijfsgegevens(): any {
    return [
      {
        width: 150,
        stack: [
          {
            image:
              'data:image/png;base64,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',
            width: 150
          }
        ]
      },
      {
        width: 270,
        alignment: 'right',
        fontSize: 8,
        color: 'gray',
        margin: [0, 0, 10, 0],
        stack: [
          { text: ' ' },
          { text: ' ' },
          { text: 'Adres:' },
          { text: ' ' },
          { text: ' ' },
          { text: ' ' },
          { text: 'KvK nr:' },
          { text: 'BTW nr:' },
          { text: ' ' },
          { text: 'IBAN: ' },
          { text: ' ' },
          { text: 'Tel: ' },
          { text: 'Email: ' }
        ]
      },
      {
        width: '*',
        alignment: 'left',
        fontSize: 8,
        color: 'gray',
        stack: [
          { text: 'Continsoft - software engineering' },
          { text: ' ' },
          { text: 'Booglaan 29' },
          { text: '4027 KL Heerenveen' },
          { text: 'Nederland' },
          { text: ' ' },
          { text: '9037 1829' },
          { text: 'NL75.33.217.2890' },
          { text: ' ' },
          { text: 'NL75 ABNA 00058 54051' },
          { text: ' ' },
          { text: '+31 618 551729' },
          { text: 'info@continsoft.nl' }
        ]
      }
    ];
  }

  generateAfleverAdres(customer: Customer): any {
    return [
      { text: `${customer.name}${customer.prefix == ' ' ? ' ' : ` ${customer.prefix} `}${customer.surname}`, margin: [90, 20, 0, 0] },
      { text: `${customer.street} ${customer.houseNumber}`, margin: [90, 0, 0, 0] },
      { text: `${customer.zipCode} ${customer.place}`, margin: [90, 0, 0, 50] }
    ];
  }

  generateFactuurRegels(invoiceLines: InvoiceLine[]): any {
    const mainArray = [];
    const headerRow = [];
    headerRow.push(
      { text: 'Omschrijving', bold: true, margin: [0, 0, 0, 0] },
      { text: 'Aantal', bold: true, alignment: 'right', margin: [0, 0, 0, 0] },
      {
        text: 'Stukprijs',
        bold: true,
        alignment: 'right',
        margin: [0, 0, 0, 0]
      },
      {
        text: 'Totaal',
        bold: true,
        alignment: 'right',
        margin: [0, 0, 0, 0]
      }
    );

    mainArray.push(headerRow);

    for (const line of invoiceLines) {
      const invoiceLine = [];

      invoiceLine.push(
        { text: line.item.name },
        { text: line.amount, alignment: 'right' },
        { text: this.currencyPipe.transform(line.item.price, 'EUR'), alignment: 'right' },
        { text: this.currencyPipe.transform(line.item.price * line.amount, 'EUR'), alignment: 'right' }
      );

      mainArray.push(invoiceLine);
    }

    return mainArray;
  }

  calculateTotalPriceExcl(invoiceLines: InvoiceLine[]): number {
    let totaleprijs = 0;

    for (const line of invoiceLines) {
      const regelPrijsExclBtw = Math.round(parseFloat(line.item.price * line.amount + 'e+2')) + 'e-2';
      totaleprijs += parseFloat(regelPrijsExclBtw);
    }

    return totaleprijs;
  }

  calculateTotalPriceIncl(invoiceLines: InvoiceLine[]): number {
    let totaalPrijsIncl = 0;

    for (const line of invoiceLines) {
      const prijsToAdd =
        this.calculateStuksPriceIncl(line.item.price) * line.amount;
      totaalPrijsIncl += prijsToAdd;
    }

    return totaalPrijsIncl;
  }

  calculateStuksPriceIncl(prijsExclBtw: number) {
    const btwTarief = 1.21;

    const prijsInclBtw = Math.round(parseFloat(prijsExclBtw * btwTarief + 'e+2')) + 'e-2';
    return parseFloat(prijsInclBtw);
  }

  generateAdres() {
    const customer = this.invoice.customer;

    const documentDefinition = {
      content: [
        {
          margin: [-40, -40],
          table: {
            widths: [300, 100],
            body: [
              [
                {
                  text: customer.name,
                  fontSize: 16,
                  border: [true, true, true, false]
                }
              ],
              [
                {
                  text: customer.street,
                  fontSize: 16,
                  border: [true, false, true, false]
                }
              ],
              [
                {
                  text: `${customer.zipCode} ${customer.place}`,
                  fontSize: 16,
                  border: [true, false, true, false]
                }
              ],
              [
                {
                  text: 'Nederland',
                  fontSize: 16,
                  border: [true, false, true, true]
                }
              ]
            ]
          }
        }
      ]
    };

    pdfMake.createPdf(documentDefinition).open();
  }
}
