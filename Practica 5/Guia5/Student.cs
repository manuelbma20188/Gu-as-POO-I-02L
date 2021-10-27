using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Guia5
{
    class Student
    {
        //atts
        private string id;
        private string name;
        private DateTime bornDate;
        private string email;
        private string responsable;
        
        public string Id
        {
            get { return id; }
            set
            {
                //regular expression; format xample: bm1921921
                Regex regexCarnet = new Regex(@"^(([a-zA-Z]){2}([0-9]){6})$");

                id = value;
                //comparing entrance with isMatch
                if (!regexCarnet.IsMatch(id))
                {
                    throw new Exception("Formato de carné no valido");
                }                    
            }
        }
        
        public string Name
        {
            get { return name; }
            set
            {
                //regular expression for a name, including special letters
                //1, means more than one word-letter
                Regex regexNombre = new Regex(@"[a-zA-ZÁÉÍÓÚñáéíóúÑ]{1,}");

                name = value;
                //same logig
                if (!regexNombre.IsMatch(name))
                {
                    throw new Exception("Formato de nombre no valido");
                }                    
            }
        }

        public DateTime BorDate
        {            
            get { return bornDate; }
            set { bornDate = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                //regular expression for emil
                Regex regexCorreo = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");
                email = value;                
                if (!regexCorreo.IsMatch(email))
                {
                    throw new Exception("Formato de correo no válido");
                }                    
            }
        }

        public string Responsable
        {
            get { return responsable; }
            set
            {
                //regular expresion, same as name expression
                Regex regexResponsable = new Regex(@"[a-zA-ZÁÉÍÓÚñáéíóúÑ]{1,}");
                responsable = value;                
                if (!regexResponsable.IsMatch(responsable))
                {
                    throw new Exception("Formato del nombre del responsable no valido");
                }
                    
            }
        }
    }
}
