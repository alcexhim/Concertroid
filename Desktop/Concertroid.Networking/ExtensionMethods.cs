﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor.IO;

namespace Concertroid.Networking
{
    public static class ExtensionMethods
    {
        public static object ReadObject(this BinaryReader br, DataType type)
        {
            switch (type)
            {
                case DataType.Array:
                {
                    object[] array = null;
                    uint arrayLength = br.ReadUInt32();
                    DataType arrayType = (DataType)br.ReadByte();
                    for (uint i = 0; i < arrayLength; i++)
                    {
                        object arrayValue = ReadObject(br, arrayType);
                        array.SetValue(arrayValue, (long)i);
                    }
                    return array;
                }
                case DataType.Boolean: return br.ReadBoolean();
                case DataType.Byte: return br.ReadByte();
                case DataType.Char: return br.ReadChar();
                case DataType.DateTime: return br.ReadDateTime();
                case DataType.Decimal: return br.ReadDecimal();
                case DataType.Double: return br.ReadDouble();
                case DataType.Guid: return br.ReadGuid();
                case DataType.Int16: return br.ReadInt16();
                case DataType.Int32: return br.ReadInt32();
                case DataType.Int64: return br.ReadInt64();
                case DataType.SByte: return br.ReadSByte();
                case DataType.Single: return br.ReadSingle();
                case DataType.String: return br.ReadNullTerminatedString();
                case DataType.UInt16: return br.ReadUInt16();
                case DataType.UInt32: return br.ReadUInt32();
                case DataType.UInt64: return br.ReadUInt64();
                case DataType.Version: return br.ReadVersion();
            }
            throw new InvalidOperationException();
        }
        public static void WriteObject(this BinaryWriter bw, object value, DataType type)
        {
            switch (type)
            {
                case DataType.Array:
                {
                    object[] array = (value as object[]);
                    bw.Write((uint)array.LongLength);

                    DataType dataType = array.GetType().ToDataType();
                    bw.Write(dataType);
                    for (uint i = 0; i < (uint)array.LongLength; i++)
                    {
                        WriteObject(bw, array.GetValue((long)i), dataType);
                    }
                    break;
                }
                case DataType.Boolean: bw.Write((Boolean)value); break;
                case DataType.Byte: bw.Write((Byte)value); break;
                case DataType.Char: bw.Write((Char)value); break;
                case DataType.DateTime: bw.Write((DateTime)value); break;
                case DataType.Decimal: bw.Write((Decimal)value); break;
                case DataType.Double: bw.Write((Double)value); break;
                case DataType.Guid: bw.Write((Guid)value); break;
                case DataType.Int16: bw.Write((Int16)value); break;
                case DataType.Int32: bw.Write((Int32)value); break;
                case DataType.Int64: bw.Write((Int64)value); break;
                case DataType.SByte: bw.Write((SByte)value); break;
                case DataType.Single: bw.Write((Single)value); break;
                case DataType.String: bw.WriteNullTerminatedString((String)value); break;
                case DataType.UInt16: bw.Write((UInt16)value); break;
                case DataType.UInt32: bw.Write((UInt32)value); break;
                case DataType.UInt64: bw.Write((UInt64)value); break;
                case DataType.Version: bw.Write((Version)value); break;
            }
            throw new InvalidOperationException();
        }
        public static void Write(this BinaryWriter bw, DataType dataType)
        {
            bw.Write((byte)dataType);
        }
        public static DataType ToDataType(this Type type)
        {
            if (type == typeof(Boolean)) return DataType.Boolean;
            else if (type == typeof(Byte)) return DataType.Byte;
            else if (type == typeof(Char)) return DataType.Char;
            else if (type == typeof(DateTime)) return DataType.DateTime;
            else if (type == typeof(Decimal)) return DataType.Decimal;
            else if (type == typeof(Double)) return DataType.Double;
            else if (type == typeof(Guid)) return DataType.Guid;
            else if (type == typeof(Int16)) return DataType.Int16;
            else if (type == typeof(Int32)) return DataType.Int32;
            else if (type == typeof(Int64)) return DataType.Int64;
            else if (type == typeof(SByte)) return DataType.SByte;
            else if (type == typeof(Single)) return DataType.Single;
            else if (type == typeof(String)) return DataType.String;
            else if (type == typeof(UInt16)) return DataType.UInt16;
            else if (type == typeof(UInt32)) return DataType.UInt32;
            else if (type == typeof(UInt64)) return DataType.UInt64;
            else if (type == typeof(Version)) return DataType.Version;
            else return DataType.Unknown;
        }
    }
}
