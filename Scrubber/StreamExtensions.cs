using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ScoutingModels.Test;

namespace ScoutingModels.Scrubber
{
    public static class StreamExtensions
    {
        /// <summary>
        /// Loads a JArray from a stream object
        /// </summary>
        /// <param name="stream">Stream to load from</param>
        /// <returns>The JArray</returns>
        public static JArray JArrayFromStream(this Stream stream)
        {
            // Assert that the stream is not null
            stream.IsNotNull().IsReadableStream();

            using (var streamReader = new StreamReader(stream, Encoding.UTF8))
                using (var reader = new JsonTextReader(streamReader))
                    return JArray.Load(reader);
            
        }

        /// <summary>
        /// Loads a JArray from a stream object
        /// </summary>
        /// <param name="stream">Stream to load from</param>
        /// <param name="encoding">Encoding to use</param>
        /// <returns>The JArray</returns>
        public static JArray JArrayFromStream(this Stream stream, Encoding encoding)
        {
            // Assert that the stream is not null and readable
            stream.IsNotNull().IsReadableStream();

            using (var streamReader = new StreamReader(stream, encoding))
                using (var reader = new JsonTextReader(streamReader))
                    return JArray.Load(reader);
        }
    }
}
