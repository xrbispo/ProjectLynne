import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { HVManagerModule } from "../HVManager/hvmanager.module"

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, NgbModule, HVManagerModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
