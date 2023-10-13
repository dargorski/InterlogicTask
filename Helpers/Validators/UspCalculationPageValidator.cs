using System.Collections.Generic;
using EPiServer.Validation;
using InterlogicTask.Models.Pages;

namespace InterlogicTask.Helpers.Validators
{
    public class UspCalculationPageValidator : IValidate<UspCalculationPage>
    {
        public IEnumerable<ValidationError> Validate(UspCalculationPage instance)
        {
            var errors = new List<ValidationError>();

            if (instance.BottomUspBlocksContentArea == null || instance.BottomUspBlocksContentArea.Items.Count != 2)
            {
                errors.Add(
                    new ValidationError
                    {
                        ErrorMessage = "BottomUspBlocksContentArea must contain 2 OptionUspProposition blocks",
                        PropertyName = nameof(UspCalculationPage.BottomUspBlocksContentArea),
                        Severity = ValidationErrorSeverity.Error,
                        ValidationType = ValidationErrorType.AttributeMatched
                    }
                );
            }

            if (instance.MinimumNumberOfEmployees >= instance.MaximumNumberOfEmployees)
            {
                errors.Add(
                    new ValidationError
                    {
                        ErrorMessage = "MinimumNumberOfEmployees cannot be greater than MaximumNumberOfEmployees",
                        PropertyName = nameof(UspCalculationPage.BottomUspBlocksContentArea),
                        Severity = ValidationErrorSeverity.Error,
                        ValidationType = ValidationErrorType.AttributeMatched
                    }
                );
            }

            if (instance.PreselectedNumberOfEmployees > instance.MaximumNumberOfEmployees ||
                instance.PreselectedNumberOfEmployees < instance.MinimumNumberOfEmployees)
            {
                errors.Add(
                    new ValidationError
                    {
                        ErrorMessage = "PreselectedNumberOfEmployees cannot be greater than MaximumNumberOfEmployees " +
                                       "or lesser than MinimumNumberOfEmployees",
                        PropertyName = nameof(UspCalculationPage.BottomUspBlocksContentArea),
                        Severity = ValidationErrorSeverity.Error,
                        ValidationType = ValidationErrorType.AttributeMatched
                    }
                );
            }

            return errors;
        }
    }
}