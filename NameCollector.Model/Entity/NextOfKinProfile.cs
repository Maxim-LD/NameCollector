using System;

namespace NameCollector.Model.Entity
{
    public class NextOfKinProfile
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ProfileId { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string Relationship { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
