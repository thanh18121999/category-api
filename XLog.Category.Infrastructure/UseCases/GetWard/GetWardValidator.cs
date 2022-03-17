using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetWard
{
    public class GetWardValidator : AbstractValidator<GetWardCommand>
    {
        public GetWardValidator()
        {
            RuleFor(x => x.WardCode)
               .NotNull();
            RuleFor(x => x.DistrictCode)
               .NotNull();
            RuleFor(x => x.CityCode)
               .NotNull();
            RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }

    public class GetAllWardValidator : AbstractValidator<GetAllWardCommand>
    {
        public GetAllWardValidator()
        {
            RuleFor(x => x.DistrictCode)
               .NotNull();
            RuleFor(x => x.CityCode)
               .NotNull();
            RuleFor(x => x.CountryCode)
               .NotNull();
        }
    }
}
