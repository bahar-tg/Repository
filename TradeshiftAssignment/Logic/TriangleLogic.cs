using Domain;

namespace Logic
{
    public static class TriangleLogic
    {
        /// <summary>
        /// Given the lenghts of sides a, b, and c, determine and return
        /// what type of triangle the lengths describe, or whether
        /// the input lenghts do not create a triangle
        /// </summary>
        /// <param name="a">lenght of side a</param>
        /// <param name="b">lenght of side b</param>
        /// <param name="c">lenght of side c</param>
        /// <returns>The triangle type</returns>
        public static TriangleType GetTriangleType(int a, int b, int c)
        {
            if (!(a + b > c && a + c > b && b + c > a))
                return TriangleType.NoTriangle;
            if (a == b && b == c)
                return TriangleType.Equilateral;

            if (a == b || a == c || b == c)
                return TriangleType.Isosceles;

            return TriangleType.Scalene;
        }
    }
}