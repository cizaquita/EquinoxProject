using System;
using Equinox.Domain.Validations;

namespace Equinox.Domain.Commands
{
    public class RegisterNewCustomerCommand : CustomerCommand
    {
        public RegisterNewCustomerCommand(string name, string email, DateTime birthDate, DateTime registerDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            RegisterDate = registerDate;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterNewCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}