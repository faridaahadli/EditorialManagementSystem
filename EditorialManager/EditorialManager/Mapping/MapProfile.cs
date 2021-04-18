using App.Core.Models;
using AutoMapper;
using EditorialManager.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<UserInsertDto, AppUser>();
        }
       
    }
}
