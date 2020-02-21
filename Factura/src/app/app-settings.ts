import { HttpHeaders } from "@angular/common/http";
import { environment } from 'src/environments/environment';

export class AppSettings {
    public static API_ENDPOINT = environment.apiUrl;

    public static API_HEADER = { headers: new HttpHeaders({
        'Content-Type': 'application/json'
      } 
    )};
}