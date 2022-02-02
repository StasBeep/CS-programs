using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorywork5Variant27
{
    class branching
    {
        // входные данные (public - для того, чтобы видели другие пространства)
        public double c, y, x, z, l;

        // открытый метод (public)
        public double systemSolution(double c, double y, double x, double z)
        {
            // возвращаемое значение (третье условие выполняется автоматически)
            double l = 15;

            // Условия
            if (y * z > 0 && x > 0)
            {
                double max = Math.Sqrt(x);

                if (max < c * y)
                {
                    max = c * y;
                }

                double min = y;

                if (min > max)
                {
                    min = max;
                }
                if (min > z)
                {
                    min = z;
                }

                l = min;
            }
            else if (y * z < 0 && x > 0)
            {
                double min = Math.Tan(x);

                if (min > Math.Pow(z, 3))
                {
                    min = Math.Pow(z, 3);
                }

                l = min;
            }

            return l;
        }
    }
}
