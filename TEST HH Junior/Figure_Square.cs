

namespace TEST_HH_Junior
{
    public static class Figure_Square
    {
        
        const double Pi =3.14;

        //S = π × r2
        public static double Circle_Radius(double radius)
        {
          
            
           return  Pi * (radius*radius);

        }

        //S=sqrt{p*(p-a)*(p-b)*(p-c)}
        public static double Triangle_Side(double side1,double side2,double side3)
        {

            double halfperim = (side1 + side2 + side3) / 2;

            double x = Math.Sqrt(halfperim * (halfperim - side1) * (halfperim - side2) * (halfperim - side3));

            return Math.Round(x,2);
        }




    }


}