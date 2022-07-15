using AutoMapper;
using EntityORM.Contexts;
using EntityORM.DbEntities;
using Microsoft.Extensions.Logging;

namespace ProductFeatures.CreateProductUseCase.Comands.InsertProduct
{
    public interface IInsertProduct
    {

    }
    public class InsertProduct
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<InsertProduct> _logger;

        public InsertProduct(ApplicationContext context, IMapper mapper, ILogger<InsertProduct> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task Insert(CreateProductRequest request)
        {
            try
            {
                var productEntity = _mapper.Map<Product>(request);
                await _context.AddAsync(productEntity);
                await _context.SaveChangesAsync();
            }
            catch
            {
                _logger.LogError("");
            }
        }
    }
}
