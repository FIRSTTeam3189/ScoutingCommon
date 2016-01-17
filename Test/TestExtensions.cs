using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;

namespace ScoutingModels.Test
{
    public static class TestExtensions
    {
        /// <summary>
        /// Assertion test to check if an object is not null
        /// </summary>
        /// <param name="obj">Object to test</param>
        /// <returns>Object its self</returns>
        public static object IsNotNull(this object obj)
        {
            Contract.Requires(obj != null);
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            Contract.EndContractBlock();
            
            return obj;
        }

        /// <summary>
        /// Assertion test to check if an object of type T is not null
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="obj">Object to test</param>
        /// <returns>The object its self</returns>
        public static T IsNotNull<T>(this T obj) where T : class
        {
            Contract.Requires(obj != null);
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));
            Contract.EndContractBlock();

            return obj;
        }

        /// <summary>
        /// Ensures that the stream is readable
        /// </summary>
        /// <typeparam name="T">Type of stream</typeparam>
        /// <param name="obj">Stream to test</param>
        /// <returns>Stream its self</returns>
        public static T IsReadableStream<T>(this T obj) where T : Stream
        {
            Contract.Requires(obj.CanRead);
            if (!obj.CanRead)
                throw new ArgumentException("Cannot read from stream", nameof(obj));
            Contract.EndContractBlock();

            return obj;
        }

        /// <summary>
        /// Ensures that the stream is writable
        /// </summary>
        /// <typeparam name="T">Type of stream</typeparam>
        /// <param name="obj">Stream to test</param>
        /// <returns>Stream its self</returns>
        public static T IsWritableStream<T>(this T obj) where T : Stream
        {
            Contract.Requires(obj.CanWrite);
            if (!obj.CanWrite)
                throw new ArgumentException("Cannot write to stream", nameof(obj));
            Contract.EndContractBlock();

            return obj;
        }
    }
}
