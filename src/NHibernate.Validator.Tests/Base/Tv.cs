using System;
using NHibernate.Validator.Constraints;

namespace NHibernate.Validator.Tests.Base
{
	public class Tv
	{
		[Length(Min = 0)] public String description;

		[Future] public DateTime expDate;

		[Min(1000)] public Int64 lifetime;

		[Length(Max = 2)] public String name;

		[Length(Max = 2)] public String serial;

		public int size;
	}
}