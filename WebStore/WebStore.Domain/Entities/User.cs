﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entities
{
	public class User : IdentityUser
	{
		public const string AdminUserName = "Admin";
		public const string DefaultAdminPassword = "AdminPassword";

		public const string RoleAdmin = "Administrator";
		public const string RoleUser = "User";
	}
}
