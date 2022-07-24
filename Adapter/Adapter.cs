
using AutoMapper;
using EmployeeManagementWebApi.ClientDtos;
using EmployeeManagementWebApi.Models;

namespace EmployeeManagementWebApi.Adapter
{
    public class Adapter : Profile
    {
        public Adapter()
        {

            //CreateMap<Employee, EmployeeDto>();

            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
