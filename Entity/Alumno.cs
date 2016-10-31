using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alberti.Entity
{
    public class Alumno
    {
        #region atributos
        private string _ApellidoNombre;
        private string _Dni;
        private int _Edad;
        private DateTime _FechaNacimiento;
        private int _Id;
        private double _NotaPromedio;
        #endregion

        #region Propiedades
        public string ApellidoNombre
        {
            get { return _ApellidoNombre; }
            set { _ApellidoNombre = value; }
        }
        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }
        public int Edad
        {
            get { return CalcularEdad(_FechaNacimiento); }
        }
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public double NotaPromedio
        {
            get { return _NotaPromedio; }
            set { _NotaPromedio = value; }
        }
        #endregion

        #region Overloads   
        public Alumno(string VarApellidoNombre,string varDni,DateTime varFechaNacimiento,int varId, double varNotaPromedio)
        {
            ApellidoNombre = VarApellidoNombre;
            Dni = varDni;
            FechaNacimiento = varFechaNacimiento;
            Id = varId;
            NotaPromedio = varNotaPromedio;            
                
        }
        public Alumno()
        {

        }
        #endregion

        #region metodos
        
        private int CalcularEdad(DateTime FechaNac)
        {
            int edad;
            DateTime Hoy = DateTime.Today;

            edad = Hoy.Year - FechaNac.Year - 1;
            if (FechaNac.Month <= Hoy.Month)
            {
                if (FechaNac.Day <= Hoy.Day)
                {
                    edad = edad + 1;
                }
            }

            return edad;
        }

        #endregion

    }
}
