import { Component } from "@angular/core";
import { Http, Response } from "@angular/http";
import "rxjs/add/operator/map";

@Component({
    templateUrl: "hosteditor.component.html"
})

export class HostEditorComponent {
    
    private apiUrlOS = 'http://localhost:55596/api/OSManager'
    private apiUrlProduct = 'http://localhost:55596/api/ProductManager'
    private apiUrlClient = 'http://localhost:55596/api/ClientManager'
    private apiUrlTeam = 'http://localhost:55596/api/TeamManager'
    private apiUrlDatacenter = 'http://localhost:55596/api/DatacenterManager'
       
    dataOS: any = [];
    dataProduct: any = [];
    dataClient: any = [];
    dataTeam: any = [];
    dataDatacenter: any = [];
    
    
    constructor(private http: Http) {
        this.getOS();
        this.getProduct();
        this.getClient();
        this.getTeam();
        this.getDatacenter();
      }
  
    getOS() {
        return this.http.get(this.apiUrlOS)
          .map((res: Response) => res.json())
          .subscribe(dataOS => {
            this.dataOS = dataOS;
          })
      }

      getDatacenter() {
        return this.http.get(this.apiUrlDatacenter)
          .map((res: Response) => res.json())
          .subscribe(dataDatacenter => {
            this.dataDatacenter = dataDatacenter;
          })
      }

      getProduct() {
        return this.http.get(this.apiUrlProduct)
          .map((res: Response) => res.json())
          .subscribe(dataProduct => {
            this.dataProduct = dataProduct;
          })
      }
      
      getClient() {
        return this.http.get(this.apiUrlClient)
          .map((res: Response) => res.json())
          .subscribe(dataClient => {
            this.dataClient = dataClient;
          })
      } 
      
      getTeam() {
        return this.http.get(this.apiUrlTeam)
          .map((res: Response) => res.json())
          .subscribe(dataTeam => {
            this.dataTeam = dataTeam;
          })
      }
      
 }
