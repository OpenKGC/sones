﻿using System;
using sones.Library.ErrorHandling;

namespace sones.GraphQL.ErrorHandling
{
    /// <summary>
    /// Missing grouped argument in a selection with aggregates 
    /// </summary>
    public sealed class NoGroupingArgumentException : AGraphQLSelectException
    {

        public String Selection { get; private set; }

        /// <summary>
        /// Creates a new NoGroupingArgumentException exception
        /// </summary>
        /// <param name="mySelection">The selection</param>
        public NoGroupingArgumentException(String mySelection)
        {
            Selection = mySelection;
        }

        public override string ToString()
        {
            return "A selection with aggregates must be grouped. Missing for selection " + Selection;
        }

    }
}