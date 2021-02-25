using Datos;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CarCenter.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CarCenterController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ClienteTO> Get()
        {
            List<ClienteTO> clientes = new List<ClienteTO>();
            using( CarCenterEntities _context = new CarCenterEntities())
            {
                clientes = _context.Clientes
                                        .ToList()
                                        .ConvertAll(r => new ClienteTO
                                        {
                                            Celular = r.Celular,
                                            ClienteId = r.ClienteId,
                                            Direccion = r.Direccion,
                                            Documento = r.Documento,
                                            Email = r.Email,
                                            PrimerApellido = r.PrimerApellido,
                                            PrimerNombre = r.PrimerNombre,
                                            SegundoApellido = r.SegundoApellido,
                                            SegundoNombre = r.SegundoNombre,
                                            TipoDocumento = r.TipoDocumento
                                        });
            }

            return clientes;
        }

        // GET api/<controller>/5
        public ClienteTO Get(int id)
        {
            ClienteTO cliente = new ClienteTO();

            using (CarCenterEntities _context = new CarCenterEntities())
            {
                var r = _context.Clientes.Find(id);
                 cliente = new ClienteTO
                 {
                     Celular = r.Celular,
                     ClienteId = r.ClienteId,
                     Direccion = r.Direccion,
                     Documento = r.Documento,
                     Email = r.Email,
                     PrimerApellido = r.PrimerApellido,
                     PrimerNombre = r.PrimerNombre,
                     SegundoApellido = r.SegundoApellido,
                     SegundoNombre = r.SegundoNombre,
                     TipoDocumento = r.TipoDocumento
                 };
            }

            return cliente;
        }

        // POST api/<controller>
        public void Post([FromBody] Cliente pCliente)
        {
            using (CarCenterEntities _context = new CarCenterEntities())
            {
                _context.Clientes.Add(pCliente);
                _context.SaveChanges();
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Cliente pCliente)
        {
            using (CarCenterEntities _context = new CarCenterEntities())
            {
                Cliente cliente = _context.Clientes.Find(id);

                if ( cliente != null)
                {
                    cliente.Celular = pCliente.Celular;
                    cliente.Direccion = pCliente.Direccion;
                    cliente.Documento = pCliente.Documento;
                    cliente.Email = pCliente.Email;
                    cliente.PrimerApellido = pCliente.PrimerApellido;
                    cliente.PrimerNombre = pCliente.PrimerNombre;
                    cliente.SegundoApellido = pCliente.SegundoApellido;
                    cliente.SegundoNombre = pCliente.SegundoNombre;
                    cliente.TipoDocumento = pCliente.TipoDocumento;

                    _context.SaveChanges();
                }
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            using (CarCenterEntities _context = new CarCenterEntities())
            {
                Cliente cliente = _context.Clientes.Find(id);

                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}