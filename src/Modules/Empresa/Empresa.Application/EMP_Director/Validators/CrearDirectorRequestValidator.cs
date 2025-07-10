/*****
 * Nombre del archivo:  CrearDirectorRequestValidator.cs
 * Descripción:         Validador para el caso de uso de creación de director. Valida que los campos del request cumplan con las reglas de negocio.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación del validador para verificar que los datos de entrada son correctos, incluyendo validaciones de campos de texto, fechas y números.
 *****/
using FluentValidation;
using Empresa.Application.Director.Dtos;
using System;

namespace Empresa.Application.Director.Validators
{
    public class CrearDirectorRequestValidator : AbstractValidator<CrearDirectorRequest>
    {
        public CrearDirectorRequestValidator()
        {
            // 1. Empresa (FK NOT NULL)
            RuleFor(x => x.nIdEmpresa)
                .GreaterThan(0)
                .WithMessage("Debe especificar una empresa válida.");

            // 2. Tipo de documento (FK NOT NULL)
            RuleFor(x => x.nTipoDocumento)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de documento.");

            // 3. Número de documento (varchar(20) NOT NULL, único)
            RuleFor(x => x.sNumeroDocumento)
                .NotEmpty()
                .WithMessage("El número de documento es obligatorio.")
                .MaximumLength(20)
                .WithMessage("El número de documento no puede exceder 20 caracteres.");

            // 4. Nombres y apellidos (varchar(250) NOT NULL)
            RuleFor(x => x.sNombres)
                .NotEmpty()
                .WithMessage("El nombre es obligatorio.")
                .MaximumLength(250)
                .WithMessage("El nombre no puede exceder 250 caracteres.");
            RuleFor(x => x.sApellidos)
                .NotEmpty()
                .WithMessage("El apellido es obligatorio.")
                .MaximumLength(250)
                .WithMessage("El apellido no puede exceder 250 caracteres.");

            // 5. Fecha de nacimiento (date NULLABLE en BD, pero requerida en request)
            RuleFor(x => x.dFechaNacimiento)
                .NotEmpty()
                .WithMessage("La fecha de nacimiento es obligatoria.")
                .LessThan(DateTime.Today)
                .WithMessage("La fecha de nacimiento debe ser anterior al día de hoy.");

            // 6. Género (FK NOT NULL)
            RuleFor(x => x.nGenero)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un género.");

            // 7. Ubicación (los campos vienen como string, deben ser dígitos parseables > 0)
            RuleFor(x => x.sDepartamento)
                .NotEmpty()
                .WithMessage("El departamento es obligatorio.")
                .Matches(@"^\d+$")
                .WithMessage("El departamento debe ser un número válido.");
            RuleFor(x => x.sProvincia)
                .NotEmpty()
                .WithMessage("La provincia es obligatoria.")
                .Matches(@"^\d+$")
                .WithMessage("La provincia debe ser un número válido.");
            RuleFor(x => x.sDistrito)
                .NotEmpty()
                .WithMessage("El distrito es obligatorio.")
                .Matches(@"^\d+$")
                .WithMessage("El distrito debe ser un número válido.");

            // 8. Dirección (varchar(300) NULLABLE)
            When(x => !string.IsNullOrEmpty(x.sDireccion), () =>
            {
                RuleFor(x => x.sDireccion!)
                    .MaximumLength(300)
                    .WithMessage("La dirección no puede exceder 300 caracteres.");
            });

            // 9. Teléfonos (varchar(20) NULLABLE)
            RuleFor(x => x.sTelefono)
                .NotEmpty()
                .WithMessage("El teléfono es obligatorio.")
                .Matches(@"^\d+$")
                .WithMessage("El teléfono debe contener solo dígitos.")
                .MaximumLength(20)
                .WithMessage("El teléfono no puede exceder 20 caracteres.");
            When(x => !string.IsNullOrEmpty(x.sTelefonoSecundario), () =>
            {
                RuleFor(x => x.sTelefonoSecundario!)
                    .Matches(@"^\d+$")
                    .WithMessage("El teléfono secundario debe contener solo dígitos.")
                    .MaximumLength(20)
                    .WithMessage("El teléfono secundario no puede exceder 20 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sTelefonoTerciario), () =>
            {
                RuleFor(x => x.sTelefonoTerciario!)
                    .Matches(@"^\d+$")
                    .WithMessage("El teléfono terciario debe contener solo dígitos.")
                    .MaximumLength(20)
                    .WithMessage("El teléfono terciario no puede exceder 20 caracteres.");
            });

            //10. Correos (varchar(250) NULLABLE)
            RuleFor(x => x.sCorreo)
                .NotEmpty()
                .WithMessage("El correo es obligatorio.")
                .EmailAddress()
                .WithMessage("El correo no tiene un formato válido.")
                .MaximumLength(250)
                .WithMessage("El correo no puede exceder 250 caracteres.");
            When(x => !string.IsNullOrEmpty(x.sCorreoSecundario), () =>
            {
                RuleFor(x => x.sCorreoSecundario!)
                    .EmailAddress()
                    .WithMessage("El correo secundario no tiene un formato válido.")
                    .MaximumLength(250)
                    .WithMessage("El correo secundario no puede exceder 250 caracteres.");
            });
            When(x => !string.IsNullOrEmpty(x.sCorreoTerciario), () =>
            {
                RuleFor(x => x.sCorreoTerciario!)
                    .EmailAddress()
                    .WithMessage("El correo terciario no tiene un formato válido.")
                    .MaximumLength(250)
                    .WithMessage("El correo terciario no puede exceder 250 caracteres.");
            });

            //11. Cargo, tipo de director y sector (FKs NOT NULL)
            RuleFor(x => x.nCargo)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un cargo.");
            RuleFor(x => x.nTipoDirector)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un tipo de director.");
            RuleFor(x => x.nIdSector)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar un sector.");

            //12. Profesión (varchar(250) NULLABLE)
            When(x => !string.IsNullOrEmpty(x.sProfesion), () =>
            {
                RuleFor(x => x.sProfesion!)
                    .MaximumLength(250)
                    .WithMessage("La profesión no puede exceder 250 caracteres.");
            });

            //13. Dieta (decimal(18,2) NULLABLE en BD, pero request es non-nullable)
            RuleFor(x => x.mDieta)
                .GreaterThanOrEqualTo(0)
                .WithMessage("La dieta debe ser un valor no negativo.");

            //14. Especialidad (FK NOT NULL)
            RuleFor(x => x.nEspecialidad)
                .GreaterThan(0)
                .WithMessage("Debe seleccionar una especialidad.");

            //15. Fechas de nombramiento y designación (DATETIME NULLABLE en BD, pero request es non-nullable)
            //RuleFor(x => x.dFechaNombramiento)
            //    .LessThanOrEqualTo(DateTime.Now)
            //    .WithMessage("La fecha de nombramiento no puede ser futura.")
            //    .GreaterThan(x => x.dFechaNacimiento)
            //    .WithMessage("La fecha de nombramiento debe ser posterior a la fecha de nacimiento.");
            //RuleFor(x => x.dFechaDesignacion)
            //    .LessThanOrEqualTo(DateTime.Now)
            //    .WithMessage("La fecha de designación no puede ser futura.")
            //    .GreaterThanOrEqualTo(x => x.dFechaNombramiento)
            //    .WithMessage("La fecha de designación debe ser igual o posterior a la de nombramiento.");

            //16. Comentario (varchar(500) NULLABLE)
            When(x => !string.IsNullOrEmpty(x.sComentario), () =>
            {
                RuleFor(x => x.sComentario!)
                    .MaximumLength(500)
                    .WithMessage("El comentario no puede exceder 500 caracteres.");
            });

            //17. Usuario que registra (FK NOT NULL)
            RuleFor(x => x.nUsuarioRegistro)
                .GreaterThan(0)
                .WithMessage("Debe especificar el usuario que registra.");
        }
    }
}
