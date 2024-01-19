using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourV2.Data.Dto.ValuesEducation;
using TourV2.Helper;

namespace TourV2.MediatR.Queries.Mosque
{
    public class GetAllMosqueQuery : IRequest<ServiceResponse<List<MosqueDto>>>
    { 
    }
}
