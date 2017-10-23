import { Component } from "@angular/core";
import { Http, Response } from "@angular/http";
import "rxjs/add/operator/map";

@Component({
    selector: "HVManager",
    moduleId: module.id,
    templateUrl: "hvmanager.component.html"
})

export class HVManagerComponent {

    private apiUrl = 'http://localhost:55596/api/HostManager'
    data: any = [];

    constructor(private http: Http) {
        this.getHosts();
    }

    getHosts() {
        return this.http.get(this.apiUrl)
            .map((res: Response) => res.json())
            .subscribe(data => {
                this.data = data;
                console.log(this.data);
            })
    }
}
