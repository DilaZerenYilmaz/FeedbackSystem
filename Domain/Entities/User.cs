using Core.DataAccess;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class User : BaseUser
	{
		public string UserName { get; set; }
		public virtual ICollection<Feedback> Feedbacks { get; set; }
		public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }
	}
}
