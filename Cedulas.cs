using System.Collections.Generic;

namespace Test
{
    public class Cedula
    {
        public static Dictionary<int, int> Process(int valorSaque)
        {
            int[] cedula = new int[]
            {
                100, 50, 20, 10, 5, 2
            };

            var qty = new Dictionary<int, int>()
            {
            { 100, 0 },
            { 50, 0 },
            { 20, 0 },
            { 10, 0 },
            { 5, 0 },
            { 2, 0 },
            };

            var index = 0;
            foreach(var moeda in cedula)
            {
                var temp = valorSaque / moeda;

                var val = valorSaque - moeda;

                var nextCedulaIndex = 0;
                if (index + 1 <= cedula.Length - 1)
                {
                    nextCedulaIndex = index + 1;
                }

                var valueToNextInteration = val - cedula[nextCedulaIndex];

                while (valorSaque >= moeda && valueToNextInteration != 1)
                {
                    if (temp >= 0)
                    {
                        valorSaque = valorSaque - moeda;

                        qty[moeda] = qty[moeda] + 1;
                    } else 
                    {
                        break;
                    }
                }

                index++;
            }

            return qty;
        }
    }
}
