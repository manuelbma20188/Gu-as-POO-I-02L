using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class Customer
    {
        //atributes
        private string dui;
        private string names;
        private string lastname;
        private string typeAccount;
        private string nit;
        private string accountNumb;
        private double amount;
        private string place;

        public string Dui { get => dui; set => dui = value; }
        public string Names { get => names; set => names = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string TypeAccount { get => typeAccount; set => typeAccount = value; }
        public string Nit { get => nit; set => nit = value; }
        public string AccountNumb { get => accountNumb; set => accountNumb = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Place { get => place; set => place = value; }
    }
}
