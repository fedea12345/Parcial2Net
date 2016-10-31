using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using Datos;
using Alberti.Entity;


namespace Datos
{
    public class Alumno : Adapter
    {
        List<Alberti.Entity.Alumno> LisAlumnos = new List<Alberti.Entity.Alumno>();

        public List<Alberti.Entity.Alumno> RecuperarTodos()
        {


            using (SqlConnection con = new SqlConnection("Data Source=FEDE-PC\\SQLEXPRESS;Initial Catalog=Parcial;Integrated Security=True"))
            {
                con.Open();
                string sqlString = "select * from Alumno";
                
                SqlCommand comand = new SqlCommand(sqlString, con);
                SqlDataReader Alumnos = comand.ExecuteReader();

                while (Alumnos.Read())
                {
                    Alberti.Entity.Alumno Alum = new Alberti.Entity.Alumno();
                    Alum.ApellidoNombre = (string)Alumnos["NombreApellido"];
                    Alum.Dni = (string)Alumnos["Dni"];
                    Alum.FechaNacimiento = (DateTime)Alumnos["FechaNacimiento"];
                    Alum.Id = (int)Alumnos["Id"];
                    Alum.NotaPromedio = (double)Alumnos["NotaPromedio"];
                    LisAlumnos.Add(Alum);
                }
                return LisAlumnos;
            }
              
            
        }

        public Alberti.Entity.Alumno getOne(int varid)
        {
            Alberti.Entity.Alumno alumno = new Alberti.Entity.Alumno();
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=FEDE-PC\\SQLEXPRESS;Initial Catalog=Parcial;Integrated Security=True"))
                {
                    con.Open();
                    string sqlstring = System.String.Format("select * from Alumno where id={0}", varid.ToString());
                    SqlCommand cmdUsuarios = new SqlCommand(sqlstring, con);
                    SqlDataReader busqalum = cmdUsuarios.ExecuteReader();
                    if (busqalum.Read())
                    {
                        alumno.ApellidoNombre = (string)busqalum["NombreApellido"];
                        alumno.Dni = (string)busqalum["Dni"];
                        alumno.FechaNacimiento = (DateTime)busqalum["FechaNacimiento"];
                        alumno.Id = (int)busqalum["Id"];
                        alumno.NotaPromedio = (double)busqalum["NotaPromedio"];
                    }
                    return alumno;
                }
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del alumno", Ex);
                throw ExcepcionManejada;
            }

            
        }
        }    
}

