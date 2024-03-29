﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using StoreApp.Entities.Dtos;
using StoreApp.Entities.Models;

namespace StoreApp.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDtoForInsertion, Product>().ReverseMap();
            CreateMap<ProductDtoForUpdate, Product>().ReverseMap();
            CreateMap<UserDtoForCreation, IdentityUser>().ReverseMap();
            CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();
        }
    }
}
