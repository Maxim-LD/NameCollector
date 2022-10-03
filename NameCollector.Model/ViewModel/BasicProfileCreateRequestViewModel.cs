using System;

namespace NameCollector.Model.ViewModel
{
    public class BasicProfileCreateRequestViewModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
