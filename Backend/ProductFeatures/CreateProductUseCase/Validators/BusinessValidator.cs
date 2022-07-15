using EntityORM.Contexts;
using Microsoft.Extensions.Logging;

namespace ProductFeatures.CreateProductUseCase.Validators
{
    public interface IBusinessValidator
    {
        Task ValidateAsync(CreateProductRequest request);
    }
    public class BusinessValidator : IBusinessValidator
    {
        private readonly ApplicationContext _context;
        private readonly ILogger<BusinessValidator> _logger;

        public BusinessValidator(ILogger<BusinessValidator> logger, ApplicationContext context)
        {
            _context = context;
            _logger = logger;
        }
        public async Task ValidateAsync(CreateProductRequest request)
        {
             await ValidateCategoryId(request.CategoryID);
        }

        private async Task ValidateCategoryId(int categoryId)
        {
            var result = await _context.Categories.FindAsync(categoryId);
            if (result == null)
            {
                _logger.LogError("");
                throw new Exception();
            }
        }
    }
}
