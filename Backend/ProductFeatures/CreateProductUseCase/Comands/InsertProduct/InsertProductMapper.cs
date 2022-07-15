using AutoMapper;
using EntityORM.DbEntities;

namespace ProductFeatures.CreateProductUseCase.Comands.InsertProduct
{
    public  class InsertProductMapper: Profile
    {
        public InsertProductMapper()
        {
            CreateMap<CreateProductRequest, Product>()
                .ForMember(dest => dest.ActualCost, opt => opt.MapFrom(src => src.ActualCost))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
        }
    }
}
