using System;
using System.Runtime.Serialization;

namespace Backend
{
    [Serializable]
    internal class IncorrectNumberOfAffectedRows : Exception
    {
        private readonly int _actualAffectedRows;
        private readonly int _expectedAffectedRows;

        public IncorrectNumberOfAffectedRows(int actualAffectedRows, int expectedAffectedRows)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        public IncorrectNumberOfAffectedRows(string message, int actualAffectedRows, int expectedAffectedRows)
            : base(message)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        public IncorrectNumberOfAffectedRows(string message, Exception innerException, int actualAffectedRows,
            int expectedAffectedRows) : base(message, innerException)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        protected IncorrectNumberOfAffectedRows(SerializationInfo info, StreamingContext context, int actualAffectedRows,
            int expectedAffectedRows) : base(info, context)
        {
            _actualAffectedRows = actualAffectedRows;
            _expectedAffectedRows = expectedAffectedRows;
        }

        public override string Message
            => $"Expected to have effected {_expectedAffectedRows} rows but affected {_actualAffectedRows}";
    }
}
