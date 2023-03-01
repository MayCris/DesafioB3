import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { FormularioCdbComponent } from './formulario-cdb/formulario-cdb.component';
import { AppService } from './services/app.service';

@NgModule({
  declarations: [
    AppComponent,
    FormularioCdbComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [HttpClientModule, AppService],
  bootstrap: [AppComponent]
})
export class AppModule { }
