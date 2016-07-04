using AutoMapper;
using lug.io.Domain.Models;
using lug.io.ViewModel.DTO;

namespace lug.io.ViewModel.AutoMapper
{
    public class TestMapping
    {
        public static void Map()
        {
            Mapper.CreateMap<ApplicationUser, UserDto>();
        }
    }
}
