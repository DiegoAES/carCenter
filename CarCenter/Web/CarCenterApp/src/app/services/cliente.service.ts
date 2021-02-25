import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  constructor( private httpClient: HttpClient ) { }

  listarClientes(){
    return this.httpClient.get<any[]>('http://localhost:59366/api/CarCenter');
  }

  guardarCliente( cliente ){
    return this.httpClient.post('http://localhost:59366/api/CarCenter', cliente);
  }

  ModificarCliente( id, cliente ){
    return this.httpClient.put(`http://localhost:59366/api/CarCenter/${id}`, cliente);
  }

  EliminarCliente( id){
    return this.httpClient.delete(`http://localhost:59366/api/CarCenter/${id}`);
  }
  
  BuscarCliente( id){
    return this.httpClient.get(`http://localhost:59366/api/CarCenter/${id}`);
  }

}
