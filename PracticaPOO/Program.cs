﻿using System;

namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // POO
            // Paradigma de programación que se basa en objetos de la vida real
            // Se puede reutilizar al ser modular gracias a las clases y permite trabajar las excepciones y gracias a las clases
            // si una parte no funciona, las otras seguirán funcionando
            // 1- Encapsulamiento: cada clase bloquea su código hacia afuera
            // 2- Herencia o inheritance
            // 3- Polimorfismo
            // 4- Clase: Plantilla o molde donde se muestran las características comunes de un grupo de objetos
            // 5- Objetos: son ejemplares de una clase
            //      5.1- Propiedades o atributos = variables
            //      5.2- Métodos: funciones
            //Instanciar clase o crear objeto con valor new
            //Circle circle1 = new Circle();
            //Circle circle2 = new Circle();
            //Circle circle3 = new Circle();
            //Console.WriteLine($"El área del círculo es: {circle1.CalcularArea(5)}");
            //Console.WriteLine($"El área del círculo es: {circle2.CalcularArea(10)}");
            //Console.WriteLine($"El área del círculo es: {circle3.CalcularArea(8)}");
            //ConvertirEuroADolar convertir1 = new ConvertirEuroADolar();
            //convertir1.CambiarValorEuro();
            //Console.WriteLine(convertir1.Convertir(100));
            //Coche coche1 = new Coche();
            //coche1.GetInfoCoche();
            //Coche coche2 = new Coche(2050.5,1600);
            //coche2.SetExtrasCoche(true,false);
            //coche2.GetInfoCoche();
            CrearPunto();
            // CLASE ANÓNIMA: solo propiedades (no se pueden crear métodos)
            var nombre1 = new { Nombre = "Ana", Edad = 42 };
            Console.WriteLine(nombre1.Nombre);

            var nombre2 = new { Nombre = "tatin", Edad = 40 };
            nombre1 = nombre2;

        }

        static void CrearPunto()
        {
            Punto punto1 = new Punto();
            Punto punto2 = new Punto(128,80);
            Punto punto3 = new Punto(128,80);
            Punto punto4 = new Punto(128,80);
            Console.WriteLine(punto1.DistanciaEntrePuntos(punto2));
            Console.WriteLine(Punto.ContarObjetosCreados());
        }
    }

    class Circle
    {
        // propiedad o campo de clase. MUY MALA PRÁCTICA SI SE QUIERE CAMBIAR EN UN OBJETO.DEBE SER PRIVADO. POR DEFECTO ES PRIVADO
        const double PI = Math.PI;  

        /// <summary>
        /// Método para calcular el área de un círculo
        /// </summary>
        /// <returns>Devuelve el área del círculo</returns>
        public double CalcularArea(double radio) // métodos con public con PascalCase, sino con camelCase
        {
            Console.WriteLine(PI);
            return PI * Math.Pow(radio,2);
        }
    }

    class ConvertirEuroADolar
    {
        private double euro = 1.03;

        public double Convertir(double value)
        {
            return euro * value;
        }

        public double CambiarValorEuro()
        {
            Console.WriteLine("Escriba a cuánto cotiza el euro");
            try
            {
            euro = Convert.ToDouble(Console.ReadLine());
                if (euro <= 0) Console.WriteLine("El importe debe ser mayor a 0");
                return euro=0;
            }
            catch(FormatException)
            {
                Console.WriteLine("Ingreso inválido. Verifique solo ingresar números con punto para el decimal");
                return euro = 0;
            }
        }
    }


    // división de la clase con la palabra partial
    partial class Coche
    {

        private byte ruedas;
        private double largo;
        private double ancho;
        private bool aire;
        private bool gnc;

        // Constructor: método con el mismo nombre que la clase donde se ponen los estados iniciales para los objetos
        // Si no se crea el constructor sin parámetros, C# internamente lo crea.
        // public más nombre, sin tipo de datos que retorne
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 1500;
        }

        // sobrecarga de constructores
        public Coche(double largo,double ancho)
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
        }
     }

    // la otra parte de la clase Coche
     partial class Coche
     {
        // método setter para setear propiedades
        public void SetExtrasCoche(bool aire, bool gnc)
        {
            this.aire = aire;
            this.gnc = gnc;

            // TODO sirve para saber donde seguir y vs en ver lista de tarea lo muestra
            //TODO:
        }

        /// <summary>
        /// Muestra cantidad de ruedas, largo y ancho del coche
        /// </summary>
        // Método getter para mostrar info
        public void GetInfoCoche()
        {
            Console.WriteLine("Los datos del coche son: \nRuedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho + "\nAire: "+ aire + "\nGNC: "+ gnc);
        }
    }
    /*HERENCIA: es como el árbol genealógico de clases. Es poder usar métodos y/o propiedades de una clase en otra clase
     (reutilización). Se puede usar el principio de diseño de herencia "es un". Ej: un jefe es un empleado: sí, entonces jefe hereda de empleado
      Ver propiedades y métodos comunes*/
}
