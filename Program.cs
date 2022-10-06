namespace linecomparision
{
    public static class LineComparision
    {
        public static void Main()
        {
            int x1 = 2,x2 = 3,y1 = 4,y2 = 5;
            int x3 = 11, x4 = 5, y3 = 18, y4 = 1;
            double LengthofLine1=Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            double LengthofLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2)) + Math.Sqrt(Math.Pow(y4 - y3, 2));
            Console.WriteLine("\n the Length of Line = " + LengthofLine1);
            Console.WriteLine("\n the Length of Line =" + LengthofLine2);
            int compare = LengthofLine1.CompareTo(LengthofLine2);
            Console.WriteLine(compare);
            if (compare > 0)
            {
                Console.WriteLine("line 1 is greater");
            }
            else if (compare < 0)
            {
                Console.WriteLine("line 2 is greater");
            }
            else
            {
                Console.WriteLine("both are equal");
            }
        }
    }
}