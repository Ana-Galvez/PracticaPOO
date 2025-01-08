using System;

namespace PracticaPOO
{
    class Punto
    {
        private int x;
        private int y;
        public Punto(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public Punto()
        {
            this.x = 0;
            this.y = 0;
        }

        public double DistanciaEntrePuntos(Punto punto2)
        {
            int xDif = this.x - punto2.x;
            int yDif = this.y - punto2.y;

            double DistanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return DistanciaPuntos;
        }


    }
}
