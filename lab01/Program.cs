using System;

namespace exer1
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine($"Byte\tMin:{byte.MinValue}\tMax:{byte.MaxValue}");
            Console.WriteLine($"Sbyte\tMin:{sbyte.MinValue}\tMax:{sbyte.MaxValue}");
            Console.WriteLine($"Char\tMin:{char.MinValue}\tMax:{char.MaxValue}");
            Console.WriteLine($"Float\tMin:{float.MinValue}\tMax:{float.MaxValue}");
            Console.WriteLine($"Double\tMin:{double.MinValue}\tMax:{double.MaxValue}");
            Console.WriteLine($"Int\tMin:{int.MinValue}\tMax:{int.MaxValue}");
            Console.WriteLine($"Uint\tMin:{uint.MinValue}\tMax:{uint.MaxValue}");
            Console.WriteLine($"Ulong\tMin:{ulong.MinValue}\tMax:{ulong.MaxValue}");
            Console.WriteLine($"Long\tMin:{long.MinValue}\tMax:{long.MaxValue}");
            Console.WriteLine($"Ushort\tMin:{ushort.MinValue}\tMax:{ushort.MaxValue}");
            Console.WriteLine($"Short\tMin:{short.MinValue}\tMax:{short.MaxValue}");
            Console.WriteLine($"Decimal\tMin:{decimal.MinValue}\tMax:{decimal.MaxValue}");
            Console.WriteLine($"Bool\tMin:{bool.FalseString}\tMax:{bool.TrueString}");

            Console.ReadLine();
        }
    }
}