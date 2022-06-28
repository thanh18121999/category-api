using System;
using MediatR;
using XLog.Category.Application.UseCases.GetMerchandiseType;

namespace XLog.Category.Infrastructure.UseCases.GetMerchandiseType
{
    public class GetMerchandiseTypeCommand : IRequest<GetMerchandiseTypeResponse>, IGetMerchandiseType
    {
        public string MerchandiseTypeID { get; set; }
    }
    public class GetAllMerchandiseTypeCommand : IRequest<GetAllMerchandiseTypeResponse>
    {

    }
}
