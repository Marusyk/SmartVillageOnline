using DataModel.Abstract;

namespace DataModel
{
	public class Council : BaseEntity
	{
		public int? ParentId { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public int? AddressId { get; set; }
		public string EDRPOUCode { get; set; }
	}
}
