﻿using System;
using System.Runtime.Serialization;

namespace semana16_1.Controllers
{
    [Serializable]
    internal class DbUpdateConcurrencyException : Exception
    {
        public DbUpdateConcurrencyException()
        {
        }

        public DbUpdateConcurrencyException(string message) : base(message)
        {
        }

        public DbUpdateConcurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DbUpdateConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}