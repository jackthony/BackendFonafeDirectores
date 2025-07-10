/***********
 * Nombre del archivo:  CrearDirectorParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para crear un nuevo director,
 *                      incluyendo datos personales, contacto, cargo, fechas importantes y
 *                      datos de auditoría como usuario y fecha de registro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros de creación de director.
 ***********/

namespace Empresa.Domain.Director.Parameters
{
    public class CrearDirectorParameters
    {
        public int IdEmpresa { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public int Genero { get; set; }
        public int Distrito { get; set; }
        public int Provincia { get; set; }
        public int Departamento { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string? TelefonoSecundario { get; set; }
        public string? TelefonoTerciario { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string? CorreoSecundario { get; set; }
        public string? CorreoTerciario { get; set; }
        public int Cargo { get; set; }
        public int TipoDirector { get; set; }
        public int nSectorId { get; set; }
        public string Profesion { get; set; } = string.Empty;
        public decimal Dieta { get; set; }
        public int Especialidad { get; set; }
        public DateTime FechaNombramiento { get; set; }
        public DateTime FechaDesignacion { get; set; }
        public DateTime? FechaRenuncia { get; set; }
        public string Comentario { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
    }
}
