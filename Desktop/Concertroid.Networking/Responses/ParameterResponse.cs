using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking.Responses
{
    public class ParameterResponse : Response
    {
        private string mvarName = String.Empty;
        public string Name { get { return mvarName; } }

        private DataType mvarDataType = DataType.Unknown;
        public DataType DataType { get { return mvarDataType; } }

        private object mvarValue = null;
        public object Value { get { return mvarValue; } }

        public ParameterResponse(string Name, DataType DataType, object Value)
        {
            mvarName = Name;
            mvarDataType = DataType;
            mvarValue = Value;
        }
    }
}
