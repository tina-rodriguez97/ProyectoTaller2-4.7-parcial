﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoTaller2.C_Datos;

namespace ProyectoTaller2.C_Logica
{
    internal class Usuarios
    {

        public Usuarios() { }

        public bool guardarUsuario(string nombre, string apellido, string dni, string telefono, string direccion, string usuario, string contrasena,int rol_id)
        {
            try
            {
                int idni = Int32.Parse(dni);

                using (TALLER2CSEntities2 db = new TALLER2CSEntities2())
                {
                    usuarios nuevo = new usuarios();
                    nuevo.nombre = nombre;
                    nuevo.apellido = apellido;
                    nuevo.dni = idni;
                    nuevo.telefono = telefono;
                    nuevo.direccion = direccion;
                    nuevo.usuario = usuario;
                    nuevo.contrasena = contrasena;
                    nuevo.rol_id = rol_id;
                    nuevo.fecha_alta = DateTime.Now;

                    db.usuarios.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                return false;
            }
            

           
        }
    }
}
