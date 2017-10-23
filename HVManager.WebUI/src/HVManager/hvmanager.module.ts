import { NgModule } from "@angular/core";
import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { HVManagerComponent } from "./hvmanager.component";

@NgModule({
    imports: [ BrowserModule, FormsModule],
    declarations: [HVManagerComponent],
    exports: [HVManagerComponent]
})

export class HVManagerModule { }
