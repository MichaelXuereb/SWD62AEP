﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.AutoMapper
{
    //It will configure the AutoMapper instance that is going to be initialized by the Runtime to use these two profiles
    //AutoMapper > Configuration > Profiles
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings() {
            return new MapperConfiguration(
                    cfg => {
                        cfg.AddProfile(new DomainToViewModelProfile());
                        cfg.AddProfile(new ViewModelToDomainPorfile());
                    }
                );
        }
    }
}
