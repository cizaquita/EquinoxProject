using System;
using Equinox.Domain.Validations;

namespace Equinox.Domain.Commands
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(Guid id, string name, string email, DateTime birthDate, DateTime registerDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            RegisterDate = registerDate;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}