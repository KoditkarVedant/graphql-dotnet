#nullable enable

using System;

namespace GraphQL.Language.AST
{
    /// <summary>
    /// Represents a variable name and value tuple that has been gathered from the document and attached <see cref="Inputs"/>.
    /// </summary>
    public class Variable
    {
        [Obsolete]
        public Variable() : this(null!)
        {
        }

        public Variable(string name)
        {
#pragma warning disable CS0612 // Type or member is obsolete
            Name = name;
#pragma warning restore CS0612 // Type or member is obsolete
        }

        /// <summary>
        /// Gets or sets the name of the variable.
        /// </summary>
        public string Name
        {
            get;
            [Obsolete]
            set;
        }

        private object? _value;
        /// <summary>
        /// Gets or sets the value of the variable.
        /// </summary>
        public object? Value
        {
            get => _value;
            set
            {
                _value = value;
                ValueSpecified = true;
            }
        }

        /// <summary>
        /// Indicates if the variable value has been set.
        /// </summary>
        public bool ValueSpecified { get; private set; }

        /// <summary>
        /// Indicates if the variable's value is the variable's configured default value.
        /// </summary>
        public bool IsDefault { get; set; }
    }
}
