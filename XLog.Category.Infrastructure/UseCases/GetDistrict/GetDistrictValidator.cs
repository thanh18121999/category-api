using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetDistrict
{
    public class GetDistrictValidator : AbstractValidator<GetDistrictCommand>
    {
        public GetDistrictValidator()
        {
           RuleFor(x => x.DistrictCode)
               .NotNull();

            RuleFor(x => x.CityCode)
               .NotNull();
            
            RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }

    public class GetAllDistrictValidator : AbstractValidator<GetAllDistrictCommand>
    {
        public GetAllDistrictValidator()
        {
           RuleFor(x => x.CityCode)
               .NotNull();

            RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }
}
