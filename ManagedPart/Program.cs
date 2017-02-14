using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ManagedPart
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] vertices = new Point[1];
            vertices[0].x = 12;

            int count = 0;
            MyGetArray(ref vertices, ref count);

            Console.WriteLine();
            Console.WriteLine("In C# code: " + vertices[3].x);
            Console.ReadLine();
        }

        public struct Point
        {
            public double x;
            public double y;
        }

        [DllImport("NativePart.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MyGetArray([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref Point[] vertices, ref int count);
    }
}
