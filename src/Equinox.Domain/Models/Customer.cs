using System;
using Equinox.Domain.Core.Models;

namespace Equinox.Domain.Models
{
    public class Customer : Entity
    {
        public Customer(Guid id, string name, string email, DateTime birthDate, DateTime registerDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            RegisterDate = registerDate;
        }

        // Empty constructor for EF
        protected Customer() { }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime RegisterDate { get; private set; }
    }
}