﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainLayer.Enum;

namespace DomainLayer.Models
{
    public class TotalNoFitForHumanConsumptions
    {
        [Key]
        public int Id { get; set; }
        public Species Species { get; set; }
        public int NoOfHeads { get; set; }
        public double DressedWeight { get; set; }
		[ForeignKey("Postmortem")]
		public int PostmortemId { get; set; }
		public virtual Postmortem? Postmortem { get; set; }
		//[ForeignKey("ReceivingReport")]
		//public Guid ReceivingReportId { get; set; }
		//public virtual ReceivingReport? ReceivingReport { get; set; }

	}
}
