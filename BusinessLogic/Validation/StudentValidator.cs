using BusinessLogic.DTO;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLogic.Validation
{
    public class StudentValidator : AbstractValidator<StudentDTO>
    {
        private const string RegexNumbers = @"^[0-9]+$";
        private const string RegexLetters = @"^[a-zA-Z ]+$";
        private const string RegexNumbersAndLetters = @"^\w+$";

        public StudentValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage(Messages.NameRequired);
            RuleFor(x => x.Name).MaximumLength(20).WithMessage(Messages.NameValidation);
            RuleFor(x => x.Name).Matches(RegexLetters).WithMessage(Messages.NameValidation);

            RuleFor(x => x.Surname).NotNull().NotEmpty().WithMessage(Messages.SurnameRequired);
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage(Messages.SurnameValidation);
            RuleFor(x => x.Surname).Matches(RegexLetters).WithMessage(Messages.SurnameValidation);

            RuleFor(x => x.Identification).NotNull().NotEmpty().WithMessage(Messages.IdentificationRequired);
            RuleFor(x => x.Identification).MaximumLength(10).WithMessage(Messages.IdentificationValidation);
            RuleFor(x => x.Identification).Matches(RegexNumbersAndLetters).WithMessage(Messages.IdentificationValidation);

            RuleFor(x => x.Age).NotNull().NotEmpty().WithMessage(Messages.AgeRequired);
            RuleFor(x => x.Age).Must(ValidAge).WithMessage(Messages.AgeValidation);

            RuleFor(x => x.IdAffinity).NotNull().NotEmpty().WithMessage(Messages.AffinityRequired);
        }

        private bool ValidAge(short age)
        {
            Regex regex = new Regex(RegexNumbers);
            if (age.ToString().Length > 2 || !regex.IsMatch(age.ToString()))
                return false;
            else
                return true;
        }
    }
}
