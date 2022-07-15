using FluentValidation;

namespace ProductFeatures.CreateProductUseCase.Validators
{
    public class RequestValidator: AbstractValidator<CreateProductRequest>
    {
        public RequestValidator()
        {
            RuleFor(opt => opt.ActualCost)
                .GreaterThan(0).WithMessage("Actual cost cannot be 0");

            RuleFor(opt => opt.Price)
                .GreaterThan(0).WithMessage("Price needs be greater then 0")
                .GreaterThan(req => req.ActualCost).WithMessage("Price needs to be greater then actual cost");

            RuleFor(opt => opt.Quantity)
                .GreaterThan(0).WithMessage("Quantity needs to greater then 0");

            RuleFor(opt => opt.Name)
                .NotNull().WithMessage("Name cannot be null")
                .NotEmpty().WithMessage("Name cannot be empty");

            RuleFor(opt => opt.Description)
                .NotNull().WithMessage("Description cannot be null")
                .NotEmpty().WithMessage("Description cannot be empty");
        }
    }
}
