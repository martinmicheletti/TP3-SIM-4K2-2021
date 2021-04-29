using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico3
{
    class Generadores
    {
        public List<Decimal> distUniforme(Decimal cant, Decimal a, Decimal b)
        { 
            List<Decimal> lista = new List<Decimal>();
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                Decimal nro = Convert.ToDecimal(rnd.NextDouble());//random del lenguaje
                Decimal nroAleat = a + (nro * (b - a));// nro dist uniforme q se agrega a la lista
                lista.Add(Math.Round(nroAleat,6));

            }
            
            return lista;
        }

        public List<Decimal> distNormal(Decimal cant, Decimal media, Decimal desviacion)
        {
            List<Decimal> lista = new List<Decimal>();
            //Método de convolución
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                
                Decimal suma = 0;
                for (int j = 0; j < 12; j++)
                {
                    
                    Decimal aleat = Math.Round(Convert.ToDecimal(rnd.NextDouble()),6);
                    suma = suma + aleat;
                }
                Decimal z = ((suma - 6) * desviacion) + media;
                lista.Add(Convert.ToDecimal(z));
            }
            return lista;
        }


        public List<Decimal> distExponencial(Decimal cant, Decimal media) 
        {
            List<Decimal> lista = new List<Decimal>();
            Random rnd = new Random();
            for (int i = 0; i < cant; i++)
            {
                Decimal nro = Convert.ToDecimal(rnd.NextDouble());//random del lenguaje
                Decimal lambda = 1 / media;
                Decimal log= Convert.ToDecimal(Math.Log(Convert.ToDouble(1-nro)));
                Decimal nroAleat = (-1 / lambda) * log;

                lista.Add(Math.Round(nroAleat,6));
            }


            return lista;
        }
        public List<Decimal> distPoisson(Decimal cant, Decimal lambda) 
        {
            List<Decimal> lista = new List<Decimal>();
            Random rnd=new Random();
            for (int j=0; j < cant; j++)
            {
                Double a= Math.Pow((Math.E), Convert.ToDouble(-lambda));
                Double b = 1;
                Decimal i = -1;
                do
                {
                    Double xi = rnd.NextDouble();
                    b = b * xi;
                    i = i + 1;/////ver
                    
                } while (b>a);
                lista.Add(i);
            }
                return lista;
        }

    }
}
