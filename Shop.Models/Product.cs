﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Description { get; set; }
		[Required]
		public string Developer { get; set; }
		[Required]
		public string Publisher { get; set; }
		[Required]
		[Display(Name = "Price for 1-50")]
		public double Price { get; set; }
		[Required]
		[Display(Name = "Price for 51-100")]
		public double Price50 { get; set; }
		[Required]
		[Display(Name = "Price for 100+")]
		public double Price100 { get; set; }
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageURL { get; set; }
	}
}
