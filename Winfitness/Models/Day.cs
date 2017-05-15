using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Winfitness
{
	public class Day
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public List<Session> Sessions { get; set; }
	}
}
