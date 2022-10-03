using System;
using System.Collections.Generic;
using System.Text;

namespace NameCollector.Model.ViewModel
{
    public class BasicProfileResponseViewModel
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
