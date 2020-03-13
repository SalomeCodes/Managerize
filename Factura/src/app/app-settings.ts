import { HttpHeaders } from "@angular/common/http";
import { environment } from 'src/environments/environment';

export class AppSettings {
    public static INVOICE_SERVICE_ENDPOINT = environment.INVOICE_SERVICE_ENDPOINT;

    public static INVOICE_SERVICE_HEADER = { headers: new HttpHeaders({
        'Content-Type': 'application/json'
      } 
    )};
}