// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Demo
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var node = RegexParser.Parse(@"\d{3}-\d{3}-\d{4}", RegexFlavor.JavaScript, RegexOptions.None);

            var rand = new Random();
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(node.GenerateString(rand));
            }

            Console.WriteLine(new string('=', 70));

            foreach (var str in node.Take(20))
            {
                Console.WriteLine(str);
            }

            Console.ReadKey(true);
        }
    }
}
