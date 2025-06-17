﻿using FluentValidation;
using Yummy.WebApi.Entities;

namespace Yummy.WebApi.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş olamaz!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("En az 2 karakter girilmeli!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez").GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz").LessThan(1000).WithMessage("Ürün fiyatı bu kadar yüksek olamaz, girdiğiniz değeri kontrol edin!");

            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün açıklaması boş geçilemez!");
        }
    }
}
