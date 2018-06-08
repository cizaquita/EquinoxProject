using System;
using Equinox.Domain.Core.Events;

namespace Equinox.Domain.Events
{
    public class CustomerUpdatedEvent : Event
    {
        public CustomerUpdatedEvent(Guid id, string name, string email, DateTime birthDate, DateTime registerDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            RegisterDate = registerDate;
            AggregateId = id;
        }
        public Guid Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime RegisterDate { get; private set; }
    }
}