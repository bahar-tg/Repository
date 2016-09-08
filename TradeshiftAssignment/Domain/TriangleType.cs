namespace Domain
{
    /// <summary>
    /// Enumaration of Triangle Type 
    /// </summary>
    public enum TriangleType
    {
        NoTriangle = 0,//Given lenghts cannot creat a triangle
        Scalene = 1,// none of the sides are the same length
        Isosceles = 2,// two sides are the same length and one differs
        Equilateral = 3 // all sides are the same length
    }
}