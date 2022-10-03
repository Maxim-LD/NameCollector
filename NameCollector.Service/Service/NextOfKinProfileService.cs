using NameCollector.Migrations;
using NameCollector.Model.Entity;
using NameCollector.Model.ViewModel;
using NameCollector.Service.Interface;
using System;
using System.Linq;

namespace NameCollector.Service.Service
{
    public class NextOfKinProfileService: INextOfKinProfileService
    {
        private readonly NameCollectorDbContext _context;
        public NextOfKinProfileService(NameCollectorDbContext context)
        {
            _context = context;
        }
        public NextOfKinProfileResponseViewModel CreateNextOfKinProfile(NextOfKinProfileRequestViewModel model)
        {
            var profile = _context.BasicProfiles.ToList().FirstOrDefault(x => x.Id == model.ProfileId);
            if (profile != null)
            {
                var request = new NextOfKinProfile();

                request.Id = Guid.NewGuid();
                request.CreatedDate = DateTime.Now;

                request.FirstName = model.FirstName;
                request.MiddleName = model.MiddleName;
                request.DateOfBirth = model.DateOfBirth;
                request.Gender = model.Gender;
                request.Email = model.Email;
                request.PhoneNumber = model.PhoneNumber;
                request.Relationship = model.Relationship;

                //insert
                _context.NextOfKinProfiles.Add(request);
                _context.SaveChanges();

                return new NextOfKinProfileResponseViewModel { Status = true, Message = "Next of Kin added Successful" };
            }

            return new NextOfKinProfileResponseViewModel {Status = false, Message = "User profile does not exist!"};
        }
    }
}