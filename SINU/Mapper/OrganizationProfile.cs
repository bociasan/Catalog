﻿using AutoMapper;
using SINU.DTO;
using SINU.Model;

namespace SINU.Mapper
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<User, UserInsertDTO>().ReverseMap();

            CreateMap<User, UserInfoDTO>().ReverseMap();

            CreateMap<User, RegisterDTO>().ReverseMap();

            CreateMap<Class, ClassDTO>()
                .ForMember(dest => dest.StudyYearName, opt => opt.MapFrom(src => src.StudyYear.Year))
                .ForMember(dest => dest.MentorFirstName, opt => opt.MapFrom(src => src.Mentor.FirstName))
                .ForMember(dest => dest.MentorLastName, opt => opt.MapFrom(src => src.Mentor.LastName))
                .ReverseMap();

            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.ClassName, opt => opt.MapFrom(src => src.Class.GetFullName()))
                .ForMember(dest => dest.StudyYearName, opt => opt.MapFrom(src => src.StudyYear.Year))
                .ReverseMap();


            CreateMap<GradeInfo, GradeInfoDTO>()
                //.ForMember(dest => dest.TeacherFirstName, opt => opt.MapFrom(src => src.Teacher.FirstName))
                //.ForMember(dest => dest.TeacherLastName, opt => opt.MapFrom(src => src.Teacher.LastName))
                .ReverseMap();

            CreateMap<GradeInfo, GradeInfoDetailedDTO>()
                //.ForMember(dest => dest.MentorFirstName, opt => opt.MapFrom(src => src.Mentor.FirstName))
                //.ForMember(dest => dest.MentorLastName, opt => opt.MapFrom(src => src.Mentor.LastName))
                .ReverseMap();
        }
    }
}