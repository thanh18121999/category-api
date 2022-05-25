using MediatR;
using XLog.Category.Application.UseCases.GetPartners;

namespace XLog.Category.Infrastructure.UseCases.GetPartners
{
    public class GetPartnersCommand : IRequest<GetPartnersResponse>, IGetPartners
    {
        //public int PageIndex { get; set; } = 1;

        public int PageSize { get; set; } = 10;
    }
}
