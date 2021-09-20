using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_3
{
    class Student
    {
        Student[] students;
        //attributes
        string carnet;
        public string Carnet
        {
            get
            {
                return carnet;
            }
            set
            {
                carnet = value;
            }
        }
        string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        string apellido;
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        string materia;
        public string Materia
        {
            get
            {
                return materia;
            }
            set
            {
                materia = value;
            }
        }

        double nota1;
        public double Nota1
        {
            get
            {
                return  nota1;
            }
            set
            {
                nota1 = value;
            }
        }

        double nota2;
        public double Nota2
        {
            get
            {
                return nota2;
            }
            set
            {
                nota2 = value;
            }
        }

        double nota3;
        public double Nota3
        {
            get
            {
                return nota3;
            }
            set
            {
                nota3 = value;
            }
        }        

        //metodos

        //metodo para ingresar datos de registro
        public void IngresarDatos()
        {
            carnet = Interaction.InputBox("Ingrese el carnet del estudiante");
            nombre = Interaction.InputBox("Ingrese el nombre del estudiante");
            apellido = Interaction.InputBox("Ingrese el apellido del estudiante");
            materia = Interaction.InputBox("Ingrese la materia del estudiante");
            nota1 = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 1 del estudiante"));
            nota2 = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 2 del estudiante"));
            nota3 = Convert.ToDouble(Interaction.InputBox("Ingrese la nota 3 del estudiante"));                      
        }

        //metodo para llenado de datos del vector
        int tamvec;
        public void Llenado(NumericUpDown numericUpDown)
        {                                  
            tamvec = Convert.ToInt32(numericUpDown.Value);
            students = new Student[tamvec]; //declaro y lleno vector   
            //valido en caso de dejarse vacío el numeric up down            
            if (numericUpDown.Text.Trim() != "")
            {
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = new Student();
                    students[i].IngresarDatos();
                }
            }
            else
            {
                MessageBox.Show("Verifica que hayas ingresado una cantidad correcta!");                
            }
        }

        //metodo para imprimir resultados
        public void mostrar(ListBox lista)
        {
            if (students !=null) {  //se valida en caso de estar vacío el arreglo
            for (int j = 0; j < students.Length; j++)
            {
            lista.Items.Add("El alumno: " + students[j].Nombre + " " + students[j].Apellido + " con carnet " + students[j].Carnet
                + " Está cursando la materia " + students[j].Materia + "\n Sus notas en esta asignatura son: ");
            lista.Items.Add(students[j].Nota1 + ", " + students[j].Nota2 + ", " + students[j].Nota3);
            double promedio = Math.Round(((students[j].Nota1 + students[j].Nota2 + students[j].Nota3) / 3),2);
            lista.Items.Add("\n Y su promedio es: " + promedio);
            lista.Items.Add("\n");
            } //fin for

            } //fin if
            else
            {
                MessageBox.Show("Asegurate de haber ingresado previamente la respectiva información!");
            }
        }
        
        //metodo para mostrar datos de estudiante
        public void listado(ListBox lista)
        {
            if (students != null)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    lista.Items.Add("Estudiante númmero " + (i + 1) + ": ");
                    lista.Items.Add(students[i].Nombre + " " + students[i].Apellido);
                    lista.Items.Add("\n");
                }
            }
            else
            {
                MessageBox.Show("Asegurate de haber ingresado previamente la respectiva información!");
            }
        }
    }
}
