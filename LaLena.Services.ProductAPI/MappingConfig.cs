using AutoMapper;
using LaLena.Services.ProductAPI.DbContexts.Models;
using LaLena.Services.ProductAPI.DbContexts.Models.Dto;

namespace LaLena.Services.ProductAPI
{
    public class MappingConfig
    {

        public static MapperConfiguration RegisterMaps()
        {

            var mappingConfig = new MapperConfiguration(

                config =>
                {
                    config.CreateMap<ProductDto, Product>();
                    config.CreateMap<Product, ProductDto>();
                }


                );

            return mappingConfig;
        }


    }
}
