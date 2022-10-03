using Arch.EntityFrameworkCore.UnitOfWork;
using Calculator.Model.ViewModel;
using NameCollector.Migrations;
using NameCollector.Model.Entity;
using NameCollector.Model.ViewModel;
using NameCollector.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameCollector.Service.Service
{
    public class BasicProfileService: IBasicProfileService
    {
        private readonly NameCollectorDbContext _context;

        public BasicProfileService(NameCollectorDbContext context)
        {
            _context = context;
        }
        private readonly IUnitOfWork _unitOfWork;

        public BasicProfileService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseViewModel> CreateProfile(BasicProfileCreateRequestViewModel model)
        {
            //This searches for an existing record using firstname
            var profile = _context.BasicProfiles.ToList().FirstOrDefault(x => x.FirstName == model.FirstName);

            if(profile == null)
            {
                var request = new BasicProfile();

                request.Id = Guid.NewGuid();
                request.FirstName = model.FirstName;
                request.LastName = model.LastName;
                request.Gender = model.Gender;
                request.DateOfBirth = model.DateOfBirth;
                request.CreatedDate = DateTime.Now;

                _unitOfWork.GetRepository<BasicProfile>().Insert(request);
                await _unitOfWork.SaveChangesAsync();

                return new BaseResponseViewModel { Status = true, Message = "Profile created successfully" };
            }
            return new BaseResponseViewModel { Status = false, Message = "Profile already exist" };
        }

        public int GetSquareArea(AreaOfSquareViewModel model)
        {
            var result = model.Length * model.Breadth;
            return result;

            //_unitOfWork.GetRepository<BasicProfile>().Insert(result);
            //await _unitOfWork.SaveChangesAsync();


        }
        public BasicProfileResponseViewModel GetById(Guid id)
        {
            var profile = _context.BasicProfiles.ToList().FirstOrDefault(x => x.Id == id);

            if (profile == null) return null;

            var response = new BasicProfileResponseViewModel();

            response.Id = profile.Id;
            response.FirstName = profile.FirstName;
            response.LastName = profile.LastName;
            response.DateOfBirth = profile.DateOfBirth;
            response.Gender = profile.Gender;


            return response;
        }

        //public List<BasicProfile> GetAll()
        //{
        //    return _context.BasicProfiles.ToList();
        //}

        public async Task<BaseResponseViewModel> UpdateProfile(BasicProfileUpdateViewModel model)
        {
            var profile = _context.BasicProfiles.ToList().FirstOrDefault(x => x.Id == model.Id);
            if(profile != null)
            {
                profile.FirstName = model.FirstName;
                profile.LastName = model.LastName;

                _unitOfWork.GetRepository<BasicProfile>().Insert(profile);
                await _unitOfWork.SaveChangesAsync();

                return new BaseResponseViewModel { Status = true, Message = "Profile updated successfully" };
            }
            return new BaseResponseViewModel { Status = false, Message = "Profile does not exist" };
        }

        public async Task<BaseResponseViewModel> DeleteProfile(Guid id)
        {
            var profile = _context.BasicProfiles.ToList().FirstOrDefault(x => x.Id == id);
            if (profile != null)
            {
                _unitOfWork.GetRepository<BasicProfile>().Insert(profile);
                await _unitOfWork.SaveChangesAsync();

                return new BaseResponseViewModel { Status = true, Message = "Profile deleted successfully" };
            }
            return new BaseResponseViewModel { Status = false, Message = "Profile does not exist" };
        }
    }
}
