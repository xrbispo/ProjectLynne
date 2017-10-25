import { Component } from "@angular/core";
import { Http, Response } from "@angular/http";
import "rxjs/add/operator/map";

@Component({
    selector: "HVManager",
    moduleId: module.id,
    templateUrl: "hvmanager.component.html"
})

export class HVManagerComponent {

  private apiUrlHost = 'http://localhost:55596/api/HostManager'

    dataHost: any = [];

    constructor(private http: Http) {
      this.getHosts();
    }

    getHosts() {
        return this.http.get(this.apiUrlHost)
            .map((res: Response) => res.json())
            .subscribe(dataHost => {
                this.dataHost = dataHost;
                console.log(this.dataHost);
            })
    }


}
