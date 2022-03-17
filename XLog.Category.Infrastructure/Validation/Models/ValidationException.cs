using System;

namespace XLog.Category.Infrastructure.Validation.Models
{
    public class ValidationException : Exception
    {
        public ValidationResultModel ValidationResultModel { get; }
        
        public ValidationException(ValidationResultModel validationResultModel)
        {
            ValidationResultModel = validationResultModel;
        }
    }
}
