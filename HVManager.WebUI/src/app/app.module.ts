import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { HVManagerModule } from "../HVManager/hvmanager.module"
import { HVManagerComponent } from "../HVManager/hvmanager.component"
import { HostEditorComponent } from "../admin/hosteditor.component";

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule, NgbModule, HVManagerModule,
    RouterModule.forRoot([
      { path: "admin/host",component: HostEditorComponent },
      { path: "**", component: HVManagerComponent}   
      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
