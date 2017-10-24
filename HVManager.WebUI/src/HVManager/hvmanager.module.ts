import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HVManagerComponent } from "./hvmanager.component";
import { HttpModule } from "@angular/http";
import { RouterModule } from "@angular/router";
import { HostEditorComponent } from "../admin/hosteditor.component";

@NgModule({
    imports: [ BrowserModule, FormsModule, HttpModule, RouterModule],
    declarations: [HVManagerComponent, HostEditorComponent],
    exports: [HVManagerComponent, HostEditorComponent]
})

export class HVManagerModule { }
