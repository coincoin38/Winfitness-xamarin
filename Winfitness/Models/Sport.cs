using Newtonsoft.Json.Linq;

namespace Winfitness
{
	public class Sport
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description_id { get; set; }
		public string Color { get; set; }
		public string Image { get; set; }
		public Description Description { get; set; }
	}
}
