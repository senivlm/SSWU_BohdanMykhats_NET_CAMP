using System.Text;

namespace SpiralNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of class Spiral
            Spiral spiral = new();
            //Call BuildSpiral method to form a matrix
            spiral.BuildSpiral();
            //Call ToString() to return class representation
            Console.WriteLine(spiral);
        }
    }
}