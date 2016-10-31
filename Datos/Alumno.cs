using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alberti.Entity;
using Datos;
using System.Data;
using System.Data.SqlClient;



namespace Datos 
{
    public class Alumno : Adapter
    {
        List<Alberti.Entity.Alumno> LisAlumnos = new List<Alberti.Entity.Alumno>();

        public List<Alberti.Entity.Alumno> RecuperarTodos() {
            try
            {
                using (SqlConnection con = new SqlConnection("DataSource = FEDE-PC/SQLEXPRESS;Database=Parcial ;Trusted_Connection=True;Integral Security = true"))
                {
                    con.Open();
                    string sqlString = "select * from Alumnos";
                    Alberti.Entity.Alumno Alum = new Alberti.Entity.Alumno();
                    SqlCommand comand = new SqlCommand(sqlString, con);
                    SqlDataReader Alumnos = comand.ExecuteReader();

                    while (Alumnos.Read())
                    {
                        Alum.ApellidoNombre = (string)Alumnos["NombreApellido"];
                        Alum.Dni = (string)Alumnos["Dni"];
                        Alum.FechaNacimiento = (DateTime)Alumnos["FechaDeNAcimiento"];
                        Alum.Id = (int)Alumnos["Id"];
                        Alum.NotaPromedio = (int)Alumnos["NotaPromedio"];
                        LisAlumnos.Add(Alum);
                    }
                    return LisAlumnos;
                }
            }
            catch(Exception e)
            {
                throw new Exception("NO ANDA");
            }
        }

        public Alberti.Entity.Alumno getOne(int varid)
        {
            Alberti.Entity.Alumno alumno = new Alberti.Entity.Alumno();
            try
            {
                this.OpenConnection();
                string sqlstring = System.String.Format("select * from alumnos where id={0}", varid.ToString());
                SqlCommand cmdUsuarios = new SqlCommand(sqlstring, sqlConn);
                SqlDataReader busqalum = cmdUsuarios.ExecuteReader();
                if (busqalum.Read())
                {
                    alumno.ApellidoNombre = (string)busqalum["NombreApellido"];
                    alumno.Dni = (string)busqalum["Dni"];
                    alumno.FechaNacimiento = (DateTime)busqalum["FechaDeNAcimiento"];
                    alumno.Id = (int)busqalum["Id"];
                    alumno.NotaPromedio = (int)busqalum["NotaPromedio"];                 
                }
                busqalum.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumno;
        }
        }    
}
