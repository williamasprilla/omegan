﻿using MediatR;
using Omegan.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Commands.UpdateAnnouncement
{
    public class UpdateAnnouncementCommandMapper: IRequest
    {
        public int Id { get; set; }
        public string PortShipment { get; set; } = string.Empty;
        public string DestinationCountry { get; set; } = string.Empty;
        public DateTime ShippingDate { get; set; }
        public string Observation { get; set; } = string.Empty;
        public int State { get; set; }
        public int CompanyId { get; set; }
       
    }
}
