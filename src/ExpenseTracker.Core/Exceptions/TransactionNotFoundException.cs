using System;
using System.Runtime.Serialization;

namespace ExpenseTracker.Core.Exceptions
{
    [Serializable]
    public class TransactionNotFoundException : Exception
    {
        public TransactionNotFoundException() : base("Transaction not found.")
        {
        }
        
        public TransactionNotFoundException(long transactionId,string message ="") : base(string.IsNullOrEmpty(message) ? $"Transaction with id : {transactionId} not found.": message)
        {
        }

        public TransactionNotFoundException(string message) : base(message)
        {
        }

        public TransactionNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }

        protected TransactionNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}