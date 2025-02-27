using FluentValidation;
using TechLibrary.Communication.Requests;

namespace TechLibrary.Api.UseCases.Users.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("O nome é obrigatório.");
            RuleFor(request => request.Email).EmailAddress().WithMessage("O e-mail é inválido.");
            RuleFor(request => request.Password.Length).NotEmpty().WithMessage("A senha é obrigatório.");
            When(request => string.IsNullOrEmpty(request.Password) == false, () =>
            {
                RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("A senha deve ter no mínimo 6 caracteres.");
            });
        }
    }
}
