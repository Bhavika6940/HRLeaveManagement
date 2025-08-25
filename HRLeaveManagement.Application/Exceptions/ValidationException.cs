using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;


namespace HRLeaveManagement.Application.Exceptions
{

    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException(ValidationResult validationResult) : base("One or more validation errors occurred.")
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }

}

