using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekartSystPoint1
{
    public class Points
    {
         public double X { get; set; }
         public double Y { get; set; }

         public Points(double x, double y)
         {
            X = x;
            Y = y;
         }
        // Метод для визначення чверті
         public string WhereIs()
         {
            if (X > 0 && Y > 0)
                return "у першій чверті.";
            if (X < 0 && Y > 0)
                return "у другій чверті.";
            if (X < 0 && Y < 0)
                return "у третій чверті.";
            if (X > 0 && Y < 0)
                return "у четвертій чверті.";
            if (X == 0 && Y == 0)
                return "на початку координат.";
            if (X == 0)
                return "на осі Y.";
            if (Y == 0)
                return "на осі X.";

            return "Помилка.";
            
         }
    }
}
