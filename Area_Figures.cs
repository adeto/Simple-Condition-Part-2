using System;
namespace _14.Area_Of_Figures
{
    class Area_Figures
    {
        static void Main()
        {
            string figure = Console.ReadLine().ToLower();
            var num = double.Parse(Console.ReadLine());

            if (figure == "square")
            {
                var areaSquare = num * num;
                Console.WriteLine(areaSquare);
            }
            else if (figure == "rectangle")
            {
                var h = double.Parse(Console.ReadLine());
                var areaRectangle = num * h;
                Console.WriteLine(areaRectangle);
            }
            else if (figure == "circle")
            {
                var r = num * num;
                var result = r * Math.PI;
                var areaCircle = result;
                Console.WriteLine(areaCircle);
            }
            else if (figure == "triangle")
            {
                var b = double.Parse(Console.ReadLine());
                var areaTriangle = (num * b) / 2;
                Console.WriteLine(areaTriangle);

            }
        }
    }
}
