using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels.Models;

namespace ViewModels.ViewModel.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CreateUserViewModel, User>()
                .ForMember(cv => cv.Name, m => m.MapFrom(foo => foo.Name))
                .ForMember(cv => cv.Password, m => m.MapFrom(foo => foo.Password));
        }
    }
}