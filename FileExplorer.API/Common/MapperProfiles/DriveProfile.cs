﻿using AutoMapper;
using FileExplorer.API.Models.Dtos;
using FileExplorer.Application.FileStorage.Models.Storage;

namespace FileExplorer.API.Common.MapperProfiles;

public class DriveProfile : Profile
{
    public DriveProfile()
    {
        CreateMap<StorageDriveDto, StorageDrive>();
        CreateMap<StorageDrive, StorageDriveDto>();
    }
}