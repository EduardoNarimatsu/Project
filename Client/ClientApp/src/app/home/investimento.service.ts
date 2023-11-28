import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CalculaModel } from '../calcula.model';

@Injectable({
  providedIn: 'root'
})
export class InvestimentoService {

  private apiUrl = 'https://localhost:7247/api/investimento';
  constructor(private http: HttpClient) { }

  public calcular(valorInicial: number, prazoMes: number): Observable<CalculaModel> {
    const payload = {
      valorInicial,
      prazoMes
    };

    return this.http.post<CalculaModel>(`${this.apiUrl}/calcular`, payload);
  }
}
