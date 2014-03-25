using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking
{
    public struct Variable
    {
        private string mvarName;
        public string Name { get { return mvarName; } }

        private DataType mvarDataType;
        public DataType DataType { get { return mvarDataType; } }

        private object mvarValue;
        public object Value { get { return mvarValue; } set { mvarValue = value; } }

        public Variable(string Name, object Value)
        {
            mvarName = Name;
            if (Value.GetType().IsArray)
            {
                mvarDataType = DataType.Array;
            }
            else if (Value.GetType() == typeof(Boolean))
            {
                mvarDataType = DataType.Boolean;
            }
            else if (Value.GetType() == typeof(Byte))
            {
                mvarDataType = DataType.Byte;
            }
            else if (Value.GetType() == typeof(Char))
            {
                mvarDataType = DataType.Char;
            }
            else if (Value.GetType() == typeof(DateTime))
            {
                mvarDataType = DataType.DateTime;
            }
            else if (Value.GetType() == typeof(Decimal))
            {
                mvarDataType = DataType.Decimal;
            }
            else if (Value.GetType() == typeof(Double))
            {
                mvarDataType = DataType.Double;
            }
            else if (Value.GetType() == typeof(Guid))
            {
                mvarDataType = DataType.Guid;
            }
            else if (Value.GetType() == typeof(Int16))
            {
                mvarDataType = DataType.Int16;
            }
            else if (Value.GetType() == typeof(Int32))
            {
                mvarDataType = DataType.Int32;
            }
            else if (Value.GetType() == typeof(Int64))
            {
                mvarDataType = DataType.Int64;
            }
            else if (Value.GetType() == typeof(SByte))
            {
                mvarDataType = DataType.SByte;
            }
            else if (Value.GetType() == typeof(Single))
            {
                mvarDataType = DataType.Single;
            }
            else if (Value.GetType() == typeof(String))
            {
                mvarDataType = DataType.String;
            }
            else if (Value.GetType() == typeof(UInt16))
            {
                mvarDataType = DataType.UInt16;
            }
            else if (Value.GetType() == typeof(UInt32))
            {
                mvarDataType = DataType.UInt32;
            }
            else if (Value.GetType() == typeof(UInt64))
            {
                mvarDataType = DataType.UInt64;
            }
            else if (Value.GetType() == typeof(Version))
            {
                mvarDataType = DataType.Version;
            }
            else
            {
                mvarDataType = DataType.Unknown;
            }
            mvarValue = Value;
        }
        public Variable(string Name, DataType DataType, object Value)
        {
            mvarName = Name;
            mvarDataType = DataType;
            mvarValue = Value;
        }
    }
}
