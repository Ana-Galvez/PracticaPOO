using System;

namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Coche coche1 = new Coche();
            coche1.getInfoCoche();
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

    class Coche
    {

        private byte ruedas;
        private double largo;
        private double ancho;
        private bool aire;

        // Constructor: método con el mismo nombre que la clase donde se ponen los estados iniciales para los objetos
        // public más nombre, sin tipo de datos que retorne
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 1500;
        }


        /// <summary>
        /// Muestra cantidad de ruedas, largo y ancho del coche
        /// </summary>
        // Método getter para mostrar info
        public void getInfoCoche()
        {
            Console.WriteLine("Los datos del conche son: \nRuedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho);
        }
    }
}
