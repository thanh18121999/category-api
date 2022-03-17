using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetPartners
{
    public class GetPartnersValidator : AbstractValidator<GetPartnersCommand>
    {
        public GetPartnersValidator()
        {
            //RuleFor(x => x.PageIndex)
            //    .GreaterThan(0);

            RuleFor(x => x.PageSize)
                .GreaterThan(0);
        }
    }
}
