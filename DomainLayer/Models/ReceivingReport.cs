﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer.Models;
using DomainLayer.Enum;

namespace DomainLayer.Models
{
    public class ReceivingReport
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RecTime { get; set; }
        public int BatchCode { get; set; }
        public Species Species { get; set; }
        public CategoryOfFoodAnimals Category { get; set; }
        public int NoOfHeads { get; set; }
        public double LiveWeight { get; set; }
        [ForeignKey("MeatDealers")]
        public int? MeatDealersId { get; set; }
        public virtual MeatDealers? MeatDealers { get; set; }
        public string Origin { get; set; }
        public string ShippingDoc { get; set; }
        public int HoldingPenNo { get; set; }
        public string ReceivingBy { get; set; }
        [ForeignKey("AccountDetails")]
        public string? ProcessedById { get; set; }
        public virtual AccountDetails? ProcessedBy { get; set; }
        public InspectionStatus? InspectionStatus { get; set; }

        public MeatInspectionReport? MeatInspectionReport { get; set; }
        public IEnumerable<Antemortem>? Antemortems { get; set; }
        public IEnumerable<PassedForSlaughter>? PassedForSlaughter { get; set; }
        public IEnumerable<Postmortem>? Postmortems { get; set; }
        public IEnumerable<TotalNoFitForHumanConsumptions>? TotalNoFitForHumanConsumptions { get; set; }
		public SummaryAndDistributionOfMIC? SummaryAndDistributionOfMIC { get; set; }
	}
}
