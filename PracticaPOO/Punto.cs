using System;

namespace PracticaPOO
{
    class Punto
    {
        private int x;
        private int y;
        private static int contadorObjetos = 0;
        //LAS CONSTANTES EN CLASE SE CONSIDERAN STATIC
        public Punto(int x,int y)
        {
            this.x = x;
            this.y = y;
            contadorObjetos++;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorObjetos++;
        }

        public double DistanciaEntrePuntos(Punto punto2)
        {
            int xDif = this.x - punto2.x;
            int yDif = this.y - punto2.y;

            double DistanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return DistanciaPuntos;
        }

        public static int ContarObjetosCreados()
        {
            return contadorObjetos;
        }

    }
}
