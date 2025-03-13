using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adını boş geçmeyin.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapın.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapın.");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatını boş geçmeyin.")
                .GreaterThan(0).WithMessage("Ürün fiyatı 0'dan küçük olamaz.")
                .LessThan(1000).WithMessage("Ürün fiyatı 1000'den büyük olamaz.");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklamasını boş geçmeyin.");
        }
    }
}
