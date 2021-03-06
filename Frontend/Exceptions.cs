﻿using System;
using System.Runtime.Serialization;

namespace Frontend
{
    [Serializable]
    public class ExcessiveImageFilesizeException : Exception
    {
        public ExcessiveImageFilesizeException()
        {
        }

        public ExcessiveImageFilesizeException(string message) : base(message)
        {
        }

        public ExcessiveImageFilesizeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        //public ExcessiveImageFilesizeException(string imageName, long imageSize)
        //{
        //    throw new NotImplementedException();
        //}

        protected ExcessiveImageFilesizeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class TweetTooLongException : Exception
    {
        public TweetTooLongException()
        {
        }

        public TweetTooLongException(string message) : base(message)
        {
        }

        public TweetTooLongException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TweetTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    public class NoPhotosException : Exception
    {
        public NoPhotosException()
        {
        }

        public NoPhotosException(string message) : base(message)
        {
        }

        public NoPhotosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoPhotosException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}