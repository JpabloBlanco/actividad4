using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoX.Domain
{
    public class User
    {
        // Propiedades básicas
        public int Id { get; set; } // Clave primaria de la tabla
        public string Cedula { get; set; } // Cédula del usuario
        public string Password { get; set; } // Contraseña encriptada
        public string Nombre { get; set; } // Nombre del usuario
        public string Apellidos { get; set; } // Apellidos del usuario
        public string Rol { get; set; } // Rol del usuario (ej.: Admin, Usuario)
        public string Email { get; set; } // Correo electrónico del usuario
        public string Telefono { get; set; } // Teléfono del usuario
        public string Estado { get; set; } = "activo"; // Estado (activo/inactivo)
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow; // Fecha de registro

        // Constructor sin parámetros
        //         public User() { }

        //         // Constructor parametrizado
        //         public User(int id, string cedula, string password, string nombre, string apellidos, string rol, string email, string telefono, string estado, DateTime fechaRegistro)
        //         {
        //             Id = id;
        //             Cedula = cedula;
        //             Password = password;
        //             Nombre = nombre;
        //             Apellidos = apellidos;
        //             Rol = rol;
        //             Email = email;
        //             Telefono = telefono;
        //             Estado = estado;
        //             FechaRegistro = fechaRegistro;
        //         }

        //         // Método opcional para representación del usuario
        //         public override string ToString()
        //         {
        //             return $"ID: {Id}, Nombre: {Nombre} {Apellidos}, Rol: {Rol}, Email: {Email}, Teléfono: {Telefono}, Estado: {Estado}, Fecha de Registro: {FechaRegistro}";
        //         }

        //         // Método para cambiar el estado del usuario
        //         public void CambiarEstado(string nuevoEstado)
        //         {
        //             Estado = nuevoEstado;
        //         }

        //         // Método para actualizar el rol
        //         public void ActualizarRol(string nuevoRol)
        //         {
        //             Rol = nuevoRol;
        //         }
    }
}
