using NameCollector.Model.ViewModel;
using System;

namespace NameCollector.Service.Interface
{
    public interface INextOfKinProfileService
    {
        public NextOfKinProfileResponseViewModel CreateNextOfKinProfile(NextOfKinProfileRequestViewModel model);
    }
}
