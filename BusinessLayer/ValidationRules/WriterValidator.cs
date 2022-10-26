using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriteName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şire kısmı boş geçilemez");
            RuleFor(x => x.WriteName).MinimumLength(2).WithMessage("İsim Soyisim en az 2 karakter içermeli");
            RuleFor(x => x.WriteName).MaximumLength(50).WithMessage("İsim Soyisim 50 karakterden fazla olamaz");
        }
    }
}
