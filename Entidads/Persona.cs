using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidads
{
    public class Persona
    {
        #region Atributos
        private string Nombre;
        private int DNI;
        private DateTime FechaNac;
        #endregion

        #region Props
        public string NombreProp {
            get { return Nombre;}
            set { Nombre = value;}
        }
        public int DNIProp {
            get { return DNI;}
            set {DNI = value;} 
        }
        public DateTime FechaNacProp { 
            get { return FechaNac;} 
            set {FechaNac=value;} 
        }

        #endregion

        #region Constructores
        public Persona(){ }

        public Persona(string NombreIngr, int DNIIngr, DateTime FechaNacIngr)
        {
            this.Nombre = NombreIngr;
            this.DNI = DNIIngr;
            this.FechaNac = FechaNacIngr;
        }
        #endregion

        #region Metodos
        public int devolverEdad()
        {
            int Edad;
           int mesActual = DateTime.Now.Month;
           int mesFechaNac = FechaNac.Month;
            if (mesActual < mesFechaNac)
            {
                Edad = (DateTime.Now.Year - FechaNac.Year) - 1;
            }
            else 
            { 
                Edad = DateTime.Now.Year - FechaNac.Year; 
            }
           return Edad;
        }
        #endregion
    }
}
