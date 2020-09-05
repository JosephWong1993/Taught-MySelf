using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Common.Linq
{
    public static class StreamReaderEnumerable
    {
        /// <summary>
        /// Lines查询操作发，用来从StreamReader对象中逐一返回文本行
        /// </summary>
        /// <param name="source">StreamReader对象</param>
        /// <returns>文本行序列</returns>
        public static IEnumerable<String> Lines(this StreamReader source)
        {
            string line;

            if (source == null)
                throw new ArgumentNullException("source");

            while ((line = source.ReadLine()) != null)
            {
                yield return line;
            }
        }
    }
}
