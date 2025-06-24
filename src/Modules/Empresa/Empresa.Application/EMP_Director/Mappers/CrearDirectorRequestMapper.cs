using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;

namespace Empresa.Application.Director.Mappers
{
    public class CrearDirectorRequestMapper : IMapper<CrearDirectorRequest, CrearDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearDirectorParameters Map(CrearDirectorRequest source)
        {
            return new CrearDirectorParameters
            {
                IdEmpresa = source.nIdEmpresa,
                TipoDocumento = source.nTipoDocumento,
                NumeroDocumento = source.sNumeroDocumento,
                Nombres = source.sNombres,
                Apellidos = source.sApellidos,
                FechaNacimiento = source.dFechaNacimiento,
                Genero = source.nGenero,
                Distrito = int.Parse(source.sDistrito),
                Provincia = int.Parse(source.sProvincia),
                Departamento = int.Parse(source.sDepartamento),
                Direccion = source.sDireccion,
                Telefono = source.sTelefono,
                TelefonoSecundario = source.sTelefonoSecundario,
                TelefonoTerciario = source.sTelefonoTerciario,
                Correo = source.sCorreo,
                CorreoSecundario = source.sCorreoSecundario,
                CorreoTerciario = source.sCorreoTerciario,
                Cargo = source.nCargo,
                TipoDirector = source.nTipoDirector,
                nSectorId = source.nIdSector,
                Profesion = source.sProfesion,
                Dieta = source.mDieta,
                Especialidad = source.nEspecialidad,
                FechaNombramiento = source.dFechaNombramiento,
                FechaDesignacion = source.dFechaDesignacion,
                Comentario = source.sComentario,
                UsuarioRegistro = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
