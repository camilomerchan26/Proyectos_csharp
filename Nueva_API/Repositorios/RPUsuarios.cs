using Nueva_API.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;



namespace Nueva_API.Controllers
{
    public class RPUsuarios
    {
        public static List<Usuario> _listaUsuario = new List<Usuario>()
        {
            new Usuario() {  Saludo = "Hola Sr" ,Id = 1, Nombre = "Difunto" , Apellido = "Vera" },
            new Usuario() { Saludo = "Hola Sr" , Id = 2, Nombre = "Rodrigo" , Apellido = "Alternancia" },
            new Usuario() { Saludo = "Hola Sr" , Id = 3, Nombre = "jhon garzon" , Apellido = "vibrador" }
        };

        public IEnumerable<Usuario> ObtenerClientes()
        {
            return _listaUsuario;
        }

        public Usuario ObtenerCliente(int id)
        {
            var Usuario = _listaUsuario.Where(cli => cli.Id == id);

            return Usuario.FirstOrDefault();
        }

        public void Agregar(Usuario nuevoUsuario)
        {
            _listaUsuario.Add(nuevoUsuario);
        }

    }
}