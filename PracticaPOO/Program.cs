using System;

namespace PracticaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar clase o crear objeto con valor new
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();
            Circle circle3 = new Circle();
            Console.WriteLine($"El área del círculo es: {circle1.calcularArea(5)}");
            Console.WriteLine($"El área del círculo es: {circle2.calcularArea(10)}");
            Console.WriteLine($"El área del círculo es: {circle3.calcularArea(8)}");

        }
    }

    class Circle
    {
        // propiedad o campo de clase. MUY MALA PRÁCTICA SI SE QUIERE CAMBIAR EN UN OBJETO.DEBE SER PRIVADO. POR DEFECTO ES PRIVADO
        const double PI = 3.1416;  

        /// <summary>
        /// Método para calcular el área de un círculo
        /// </summary>
        /// <param name="radio">Se pide el radio como entero o con decimal</param>
        /// <returns>Devuelve el área del círculo</returns>
        public double calcularArea(double radio)
        {
            return PI * radio * radio;
        }
    }
}
