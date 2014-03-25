using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking.Requests
{
    public enum ParameterRequestMode : byte
    {
        Unknown = 0,
        Get = 1,
        Set = 2
    }
	public class ParameterRequest : Request
	{
        private ParameterRequestMode mvarMode = ParameterRequestMode.Unknown;
        public ParameterRequestMode Mode { get { return mvarMode; } }

        private string mvarParameterName = String.Empty;
        public string ParameterName { get { return mvarParameterName; } }

        private DataType mvarDataType = DataType.Unknown;
        public DataType DataType { get { return mvarDataType; } }

        private object mvarValue = null;
        public object Value { get { return mvarValue; } }

		public ParameterRequest(string parameter)
		{
            mvarMode = ParameterRequestMode.Get;
            mvarParameterName = parameter;
		}
		public ParameterRequest(string parameter, DataType type, object value)
		{
            mvarMode = ParameterRequestMode.Set;
            mvarParameterName = parameter;
            mvarDataType = type;
            mvarValue = value;
		}
	}
}
