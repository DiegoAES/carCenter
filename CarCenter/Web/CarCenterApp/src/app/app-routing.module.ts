import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ClienteComponent } from './Cliente/cliente/cliente.component';


const routes: Routes = [{
  path:'',
  redirectTo: '/Cliente',
  pathMatch: 'full'
},
{
  path:'Cliente', component: ClienteComponent 
}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
