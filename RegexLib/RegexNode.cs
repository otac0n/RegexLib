//-----------------------------------------------------------------------
// <copyright file="RegexNode.cs" company="(none)">
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
    using System.Collections.Generic;

    public abstract class RegexNode : IEquatable<RegexNode>
    {
        public static bool operator ==(RegexNode nodeA, RegexNode nodeB)
        {
            return object.Equals(nodeA, nodeB);
        }

        public static bool operator !=(RegexNode nodeA, RegexNode nodeB)
        {
            return !object.Equals(nodeA, nodeB);
        }

        public abstract bool Equals(RegexNode other);

        public override bool Equals(object obj)
        {
            return this.Equals(obj as RegexNode);
        }

        public abstract override int GetHashCode();

        public abstract IEnumerable<RegexMatch> GetMatches(string subject, int index);
    }
}
