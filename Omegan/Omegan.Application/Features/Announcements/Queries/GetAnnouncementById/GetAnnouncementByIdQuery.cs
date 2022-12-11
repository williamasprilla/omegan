using MediatR;
using Omegan.Application.DTOs;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using Omegan.Application.Features.Companies.Queries.GetCompanyByUserId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Announcements.Queries.GetAnnouncementsById
{
    public class GetAnnouncementByIdQuery: IRequest<AnnouncementOuputDTO>
    {
        public GetAnnouncementByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
