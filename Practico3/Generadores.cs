using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    class Generadores
    {
        public List<Double> distUniforme(Double cant, Double a, Double b)
        { 
            List<Double> lista = new List<Double>();
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                Double nro = Convert.ToDouble(rnd.NextDouble());//random del lenguaje
                Double nroAleat = a + (nro * (b - a));// nro dist uniforme q se agrega a la lista
                lista.Add(Math.Round(nroAleat,6));

            }
            
            return lista;
        }

        public List<Double> distNormal(Double cant, Double media, Double desviacion)
        {
            List<Double> lista = new List<Double>();
            //Método de convolución
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                
                Double suma = 0;
                for (int j = 0; j < 12; j++)
                {
                    
                    Double aleat = Math.Round(Convert.ToDouble(rnd.NextDouble()),6);
                    suma = suma + aleat;
                }
                Double z = ((suma - 6) * desviacion) + media;
                lista.Add(Convert.ToDouble(z));
            }
            return lista;
        }


        public List<Double> distExponencial(Double cant, Double media) 
        {
            List<Double> lista = new List<Double>();
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                Double nro = Convert.ToDouble(rnd.NextDouble());//random del lenguaje
                Double lambda = 1 / media;
                Double log= Convert.ToDouble(Math.Log(Convert.ToDouble(1-nro)));
                Double nroAleat = (-1 / lambda) * log;

                lista.Add(Math.Round(nroAleat,6));
            }


            return lista;
        }
        public List<Double> distPoisson(Double cant, Double lambda) 
        {
            List<Double> lista = new List<Double>();
            Random rnd=new Random();

            for (int j=0; j < cant; j++)
            {
                Double a= Math.Pow((Math.E), Convert.ToDouble(-lambda));

                Double p = 1;
                Double x = -1;
                do
                {
                    Double xi = rnd.NextDouble();
                    p = p * xi;
                    x = x + 1;
                    
                } while (p>=a);
                lista.Add(x);
            }
                return lista;
        }

    }
}
