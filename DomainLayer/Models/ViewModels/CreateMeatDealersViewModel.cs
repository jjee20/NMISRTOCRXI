namespace DomainLayer.Models.ViewModels
{
	public class CreateMeatDealersViewModel
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public Guid MeatEstablishmentId { get; set; }
	}
}
