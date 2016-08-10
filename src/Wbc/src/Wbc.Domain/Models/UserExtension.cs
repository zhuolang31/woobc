using System;

namespace Wbc.Domain.Models
{
	public class UserExtension : AggregateRoot<long>
	{
		public long UserId { get; set; }
		public DateTime Birthday { get; set; }
		public decimal Height { get; set; }
		public string City { get; set; }
		public string Birthplace { get; set; }
		public string Occupation { get; set; }
		public string ParentsDesc { get; set; }
		public bool IsUniqueChild { get; set; }
		public string IncomeDesc { get; set; }
		public string Hobby { get; set; }
		public bool IsAcceptLongDistance { get; set; }
		public string MinRequirement { get; set; }
		public string SpecialRequirement { get; set; }
		public string Introduction { get; set; }
		public string ToPartner { get; set; }
		public int Status { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateModified { get; set; }
		public string Weichat { get; set; }
		public string QqNumber { get; set; }
	}
}
