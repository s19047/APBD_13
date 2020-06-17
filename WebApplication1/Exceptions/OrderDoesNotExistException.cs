using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace APBD_13.Exceptions
{
	public class OrderDoesNotExistException : Exception
	{
		public OrderDoesNotExistException()
		{
		}

		public OrderDoesNotExistException(string message) : base(message)
		{
		}

		public OrderDoesNotExistException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected OrderDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
