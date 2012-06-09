﻿//-----------------------------------------------------------------------
// <copyright file="RegexParser.cs" company="(none)">
//  Copyright © 2012 John Gietzen.
//
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in
//  all copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//  THE SOFTWARE.
// </copyright>
// <author>John Gietzen</author>
//-----------------------------------------------------------------------

namespace RegexLib
{
    using System;

    public enum RegexFlavor
    {
        JavaScript,
    }

    public enum RegexOptions
    {
        None = 0,
    }

    public static class RegexParser
    {
        public static RegexNode Parse(string pattern, RegexFlavor flavor, RegexOptions options)
        {
            if (pattern == null)
            {
                throw new ArgumentNullException("pattern");
            }

            switch (flavor)
            {
                case RegexFlavor.JavaScript:
                    return JavaScriptParser.Parse(pattern, options);

                default:
                    throw new NotImplementedException();
            }
        }

        private static class JavaScriptParser
        {
            public static RegexNode Parse(string regexString, RegexOptions options)
            {
                var scanner = new RegexLib.Parsers.JavaScript.Scanner();
                scanner.SetSource(regexString, 0);
                var parser = new RegexLib.Parsers.JavaScript.Parser(scanner);
                if (!parser.Parse())
                {
                }

                return parser.RootNode;
            }
        }
    }
}