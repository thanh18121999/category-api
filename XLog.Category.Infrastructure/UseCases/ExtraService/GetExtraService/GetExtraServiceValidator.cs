using FluentValidation;

namespace XLog.Category.Infrastructure.UseCases.GetExtraService
{
    public class GetExtraServiceValidator : AbstractValidator<GetExtraServiceCommand>
    {
        public GetExtraServiceValidator()
        {
           RuleFor(x => x.ExtraServiceID)
               .NotNull();
        }
    }
    public class GetAllExtraServiceValidator : AbstractValidator<GetAllExtraServiceCommand>
    {
        public GetAllExtraServiceValidator()
        {
            
        }
    }
}