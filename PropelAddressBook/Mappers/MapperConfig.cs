using AutoMapper;
using PropelAddressBook.Dto;
using PropelAddressBook.Dtos;
using PropelAddressBook.Entities;

namespace PropelAddressBook.Mappers
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ContactDto, Contact>();
                cfg.CreateMap<Contact, ContactDto>();
                cfg.CreateMap<AddressDto, Address>();
                cfg.CreateMap<Address, AddressDto>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
