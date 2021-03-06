﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Holyprin.Web.Security
{
	public class ProviderRole : BaseRole<ProviderUser, Guid>
	{
		[Key]
		public override Guid RoleId { get; set; }
	}
}
