using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetPartnerType
{
    public class GetPartnerTypeValidator : AbstractValidator<GetPartnerTypeCommand>
    {
        public GetPartnerTypeValidator()
        {
           RuleFor(x => x.PartnerTypeID)
               .NotNull();
        }
    }
}
