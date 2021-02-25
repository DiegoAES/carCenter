import { listLazyRoutes } from '@angular/compiler/src/aot/lazy_routes';
import { Component, OnInit } from '@angular/core';
import { ClienteService } from 'src/app/services/cliente.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {

  clientes: any[];
  cliente:any={};

  constructor( private clienteService: ClienteService ) { }

  ngOnInit(): void {
    this.cargarLista();
  }

  cargarLista(){
    this.clientes = [];

    this.clienteService.listarClientes()
      .subscribe( respuesta => {
        this.clientes = respuesta;
      });
  }

  seleccionar(id){
    this.clienteService.BuscarCliente( id )
          .subscribe( cliente => {
            this.cliente = cliente;
          })
  }

  Guardar(){
    this.clienteService.guardarCliente( this.cliente )
          .subscribe( () => {
              this.cargarLista();
              this.cliente = {}
          })

  }

  Eliminar(id){
    this.clienteService.EliminarCliente( id )
          .subscribe( () => {
              this.cargarLista();
          })
  }

  Cancelar(){
    this.cliente = {}
  }

  Editar(){
    this.clienteService.ModificarCliente(this.cliente.ClienteId, this.cliente )
          .subscribe( () => {
            console.log( 'exitoso' )
            this.cargarLista();
            this.cliente = {}
          })
  }

}
