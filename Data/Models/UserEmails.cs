
using FluentValidation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TescatGlobalServer.Data.Models
{
    public class UserEmails
    {
        //private readonly string EmailRegexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        //public const string = "La longitud máxima de la contraseña es de 20 caracteres";
        public Guid USER_EMAILS_ID { get; set; }

        public int? ID_USER { get; set; }

        //[RegularExpression(ErrorMessages.EmailRegexPattern, ErrorMessage = ErrorMessages.messageEmailFormat)]
        //[StringLength(49, ErrorMessage = ErrorMessages.messageEmailLen)]
        public string? EMAIL_1 { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? PASS_1 { get; set; }

        //[RegularExpression(ErrorMessages.EmailRegexPattern, ErrorMessage = ErrorMessages.messageEmailFormat)]
        //[StringLength(49, ErrorMessage = ErrorMessages.messageEmailLen)]
        public string? EMAIL_2 { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? PASS_2 { get; set; }

        //[RegularExpression(ErrorMessages.EmailRegexPattern, ErrorMessage = ErrorMessages.messageEmailFormat)]
        //[StringLength(49, ErrorMessage = ErrorMessages.messageEmailLen)]
        public string? EMAIL_3 { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? PASS_3 { get; set; }


        }
    public static class ErrorMessages
    {
        public const string messagePass = "La longitud máxima de la contraseña es de 20 caracteres";
        public const string messageEmailLen = "La longitud máxima del email es de 50 caracteres";
        public const string messageEmailFormat = "El formato del email no es válido";
        public const string EmailRegexPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    }
    public class UserEmailsValidator : AbstractValidator<UserEmails>
    {
        public UserEmailsValidator()
        {
            RuleFor(customer => customer.EMAIL_1).NotEmpty().MaximumLength(49).WithMessage("La longitud máxima del email es de 50 caracteres")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("El email no tiene un formato válido");
            RuleFor(customer => customer.EMAIL_2).NotEmpty().MaximumLength(49).WithMessage("La longitud máxima del email es de 50 caracteres")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("El email no tiene un formato válido");
            RuleFor(customer => customer.EMAIL_3).NotEmpty().MaximumLength(49).WithMessage("La longitud máxima del email es de 50 caracteres")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("El email no tiene un formato válido");
            RuleFor(customer => customer.PASS_1).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
            RuleFor(customer => customer.PASS_2).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
            RuleFor(customer => customer.PASS_3).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
        }
    }
}
