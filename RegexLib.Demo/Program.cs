// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Demo
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var node = RegexParser.Parse("[0-9]{3}-[0-9]{3}-[0-9]{4}", RegexFlavor.JavaScript, RegexOptions.None);

            var rand = new Random();
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(node.GenerateString(rand));
            }

            Console.ReadKey(true);
        }
    }
}
