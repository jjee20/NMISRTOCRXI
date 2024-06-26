﻿using DomainLayer.Models;

namespace DomainLayer.Models.ViewModels
{
	public class AccountUserViewModel
	{
		public string Id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string middleName { get; set; }
		public string contactNo { get; set; }
		public DateTime birthdate { get; set; }
		public int? MeatEstablishmentId { get; set; }
		public MeatEstablishment? MeatEstablishment { get; set; }
		public string sex { get; set; }
	}
}
