import { Component, OnInit } from '@angular/core';
import { AppService } from '../services/app.service'
import { CalculoCdb } from '../models/calculo-cdb'
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-formulario-cdb',
  templateUrl: './formulario-cdb.component.html',
  styleUrls: ['./formulario-cdb.component.css']
})
export class FormularioCdbComponent implements OnInit {

  valorAplicacao: number = 0;
  meses: number = 0;
  vlrBruto: any;
  vlrLiquido: any;
  dados!: CalculoCdb;

  constructor(private appService: AppService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {}

  calcularCdb() {
    this.appService.getCalculoCDB(this.valorAplicacao, this.meses).subscribe((calculoCdb: any) => {
      this.dados = calculoCdb;
      this.vlrBruto = this.dados.valorBruto;
      this.vlrLiquido = this.dados.valorLiquido;

    })
  }
}
