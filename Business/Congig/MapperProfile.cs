using AutoMapper;
using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Congig
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			CreateMap<AboutDTO, About>();
			CreateMap<About, AboutDTO>();

			CreateMap<CategoryDTO, Category>();
			CreateMap<Category, CategoryDTO>();

			CreateMap<ContactDTO, Contact>();
			CreateMap<Contact, ContactDTO>();

			CreateMap<MessageDTO, Message>();
			CreateMap<Message, MessageDTO>();

			CreateMap<ProductDTO, Product>();
			CreateMap<Product, ProductDTO>();

			CreateMap<SiteDTO, Site>();
			CreateMap<Site, SiteDTO>();

			CreateMap<SocialMediaDTO, SocialMedia>();
			CreateMap<SocialMedia, SocialMediaDTO>();

			CreateMap<UserDTO, User>();
			CreateMap<User, UserDTO>();

		}
	}
}
