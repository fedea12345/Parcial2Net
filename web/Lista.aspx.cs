using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Alberti.Entity;

namespace web
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Alberti.Entity.Alumno> LisAlumnos = new List<Alberti.Entity.Alumno>();
            Datos.Alumno recupAlum = new Datos.Alumno();
            LisAlumnos = recupAlum.RecuperarTodos();
            GridView1.DataSource= LisAlumnos;
            GridView1.DataBind();
        }
    }
}