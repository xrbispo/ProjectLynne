import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HVManagerComponent } from "./hvmanager.component";
import { HttpModule } from "@angular/http";

@NgModule({
    imports: [ BrowserModule, FormsModule, HttpModule],
    declarations: [HVManagerComponent],
    exports: [HVManagerComponent]
})

export class HVManagerModule { }
