using System;

namespace NameCollector.Model.ViewModel
{
    public class NextOfKinProfileRequestViewModel
    {
        public Guid ProfileId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Relationship { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


    }
}
