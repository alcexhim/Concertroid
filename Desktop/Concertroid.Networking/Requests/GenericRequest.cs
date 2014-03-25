using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking.Requests
{
	public class GenericRequest : Request
	{
		private string mvarText = String.Empty;
		public string Text { get { return mvarText; } }


		public GenericRequest(string text)
		{
			mvarText = text;
		}
	}
}
