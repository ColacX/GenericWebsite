﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseLayer.Tables
{
	public class Filedata
	{
		[Key]
		public Guid Id { get; set; }
		public string Extension { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
