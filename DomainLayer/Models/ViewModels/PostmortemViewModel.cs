﻿using DomainLayer.Enum;
using DomainLayer.Models;
using Microsoft.AspNetCore.Http;

namespace DomainLayer.Models.ViewModels
{
	public class PostmortemViewModel
	{
		public IEnumerable<DomainLayer.Models.Postmortem> Postmortem { get; set; }
		public DomainLayer.Models.Postmortem SinglePostmortem { get; set; }


		public int Id { get; set; }
		public int PassedForSlaughterId { get; set; }
		public PassedForSlaughter PassedForSlaughter { get; set; }
		public AnimalPart AnimalPart { get; set; }
		public Cause Cause { get; set; }
		public int Weight { get; set; }
		public int NoOfHeads { get; set; }
		public IFormFile Image1 { get; set; }
		public IFormFile Image2 { get; set; }
		public IFormFile Image3 { get; set; }
	}
}
