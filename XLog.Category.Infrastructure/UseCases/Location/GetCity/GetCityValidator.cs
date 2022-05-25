using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetCity
{
    public class GetCityValidator : AbstractValidator<GetCityCommand>
    {
        public GetCityValidator()
        {
           RuleFor(x => x.CityCode)
               .NotNull();

           RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }

    public class GetAllCityValidator : AbstractValidator<GetAllCityByCountryCodeCommand>
    {
        public GetAllCityValidator()
        {
           RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }
}
