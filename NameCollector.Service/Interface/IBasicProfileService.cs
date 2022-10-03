using Calculator.Model.ViewModel;
using NameCollector.Model.Entity;
using NameCollector.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NameCollector.Service.Interface
{
    public interface IBasicProfileService
    {
        Task<BaseResponseViewModel> CreateProfile(BasicProfileCreateRequestViewModel model);
        BasicProfileResponseViewModel GetById(Guid id);
        Task<BaseResponseViewModel> UpdateProfile(BasicProfileUpdateViewModel model);
        Task<BaseResponseViewModel> DeleteProfile(Guid id);
        //List<BasicProfile> GetAll();
        int GetSquareArea(AreaOfSquareViewModel model);
    }
}
