﻿using System;
using System.Runtime.Serialization;

namespace ADT
{
    [Serializable]
    internal class StackEmptyException : Exception
    {
        public StackEmptyException()
        {
        }

        public StackEmptyException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

        public StackEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StackEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}