using Exceptions.ProductExceptions;
using Microsoft.Extensions.Logging;
using ProductFeatures.CreateProductUseCase.Validators;

namespace ProductFeatures.CreateProductUseCase
{
    public interface ICreateProduct
    {
        Task Create(CreateProductRequest request);
    }
    public class CreateProduct : ICreateProduct
    {
        private readonly ILogger<CreateProduct> _logger;
        private readonly IBusinessValidator _businessValidator;

        public CreateProduct(ILogger<CreateProduct> logger, IBusinessValidator businessValidator)
        {
            _logger = logger;
            _businessValidator = businessValidator;
        }
        public async Task Create(CreateProductRequest request)
        {
            // Validate Request
            await ValidateRequestAsync(request);

            //Validate bussiness rules
            await _businessValidator.ValidateAsync(request);
        }

        private async Task ValidateRequestAsync(CreateProductRequest request)
        {
            var validator = new RequestValidator();
            var response = await validator.ValidateAsync(request);
            if (!response.IsValid)
            {
                _logger.LogError($"Request had invalid data on :");
                response.Errors.ForEach(err => _logger.LogError($"--> {err}"));
                throw new CreateProductBadRequestException();
            }
        }
    }
}
