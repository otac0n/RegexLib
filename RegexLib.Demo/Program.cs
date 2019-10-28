// Copyright © John Gietzen. All Rights Reserved. This source is subject to the MIT license. Please see license.md for more information.

namespace RegexLib.Demo
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var node =
                new ConcatenationNode(
                    new RepetitionNode(new CharacterClassNode('0', '9'), 3, 3, true),
                    new ConcatenationNode(
                        new CharacterClassNode('-'),
                        new ConcatenationNode(
                            new RepetitionNode(new CharacterClassNode('0', '9'), 3, 3, true),
                            new ConcatenationNode(
                                new CharacterClassNode('-'),
                                new RepetitionNode(new CharacterClassNode('0', '9'), 4, 4, true)))));

            var rand = new Random();
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine(node.GenerateString(rand));
            }

            Console.ReadKey(true);
        }
    }
}
