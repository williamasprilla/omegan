using MediatR;
using Omegan.Application.Features.Announcements.Queries.GetAnnouncementById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omegan.Application.Features.Compensation.Querys.GetCompensationById
{
    public class GetCompensationByIdQuery: IRequest<CompensationDTO>
    {
        public GetCompensationByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

}
