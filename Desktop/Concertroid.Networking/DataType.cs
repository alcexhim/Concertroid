using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking
{
    public enum DataType : byte
    {
        /// <summary>
        /// The data type is unknown.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The data type is a single-byte Boolean value.
        /// </summary>
        Boolean,
        /// <summary>
        /// The data type is a single byte.
        /// </summary>
        Byte,
        /// <summary>
        /// The data type is a multi-byte Unicode character.
        /// </summary>
        Char,
        /// <summary>
        /// The data type is an 8-byte integer read as a DateTime.
        /// </summary>
        DateTime,
        /// <summary>
        /// The data type is a 4-byte decimal value.
        /// </summary>
        Decimal,
        /// <summary>
        /// The data type is an 8-byte double-precision floating point value.
        /// </summary>
        Double,
        /// <summary>
        /// The data type is a 16-byte Globally Unique Identifier (GUID) value.
        /// </summary>
        Guid,
        /// <summary>
        /// The data type is a 2-byte signed (short) integer.
        /// </summary>
        Int16,
        /// <summary>
        /// The data type is a 4-byte signed (int) integer.
        /// </summary>
        Int32,
        /// <summary>
        /// The data type is an 8-byte signed (long) integer.
        /// </summary>
        Int64,
        /// <summary>
        /// The data type is an unsigned byte.
        /// </summary>
        SByte,
        /// <summary>
        /// The data type is a 4-byte single-precision floating point value.
        /// </summary>
        Single,
        /// <summary>
        /// The data type is a null-terminated (C-style) string.
        /// </summary>
        String,
        /// <summary>
        /// The data type is a 2-byte unsigned (ushort) integer.
        /// </summary>
        UInt16,
        /// <summary>
        /// The data type is a 4-byte unsigned (uint) integer.
        /// </summary>
        UInt32,
        /// <summary>
        /// The data type is an 8-byte unsigned (ulong) integer.
        /// </summary>
        UInt64,
        /// <summary>
        /// The data type is a 16-byte Version value (a series of four Int32 values).
        /// </summary>
        Version,
        /// <summary>
        /// Array data type. There is an additional Int32 length parameter as well
        /// as another byte for the type of items in array, followed by the actual array.
        /// </summary>
        Array = 255
    }
}
