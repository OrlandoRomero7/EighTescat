
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace TescatGlobalServer.Data.Models
{
    public  class UserCredentials
    {
        public Guid ID_CREDENTIALS{ get; set; }

        public int? ID_USER { get; set; }

        public string? PORTAL_USER { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? PORTAL_PASS{ get; set; }

        public string? CASA_USER { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? CASA_PASS { get; set; }

        public string? MOZART_USER { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? MOZART_PASS { get; set; }

        public string? DARWIN_USER{ get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? DARWIN_PASS { get; set; }

        public string? VPN_USER { get; set; }

        //[StringLength(19, ErrorMessage = ErrorMessages.messagePass)]
        public string? VPN_PASS { get; set; }

        public DateTime? LAST_MODIF { get; set; }

        //[Timestamp]
        //public byte[]? Timestamp { get; set; }
    }

    public class UserCredentialsValidator : AbstractValidator<UserCredentials>
    {
        public UserCredentialsValidator() 
        {
            RuleFor(p => p.PORTAL_PASS).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
            RuleFor(p => p.CASA_PASS).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
            RuleFor(p => p.MOZART_PASS).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
            RuleFor(p => p.DARWIN_PASS).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
            RuleFor(p => p.VPN_PASS).NotEmpty().MaximumLength(19).WithMessage("La longitud máxima de la contraseña es de 20 caracteres");
        }
    }

}