using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetPostalCode
{
    public class GetPostalCodeValidator : AbstractValidator<GetPostalCodeCommand>
    {
        public GetPostalCodeValidator()
        {
            RuleFor(x => x.CountryCode)
               .NotNull();
            RuleFor(x => x.CityCode)
               .NotNull();
            RuleFor(x => x.DistrictCode)
               .NotNull();
            RuleFor(x => x.WardCode)
               .NotNull();
        }
    }
}