using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetMerchandiseType
{
    public class GetMerchandiseTypeValidator : AbstractValidator<GetMerchandiseTypeCommand>
    {
        public GetMerchandiseTypeValidator()
        {
           RuleFor(x => x.MerchandiseTypeID)
               .NotNull();
        }
    }
    public class GetAllMerchandiseTypeValidator : AbstractValidator<GetAllMerchandiseTypeCommand>
    {
        public GetAllMerchandiseTypeValidator()
        {
        }
    }
    
}
