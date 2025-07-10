/***********
 * Nombre del archivo:  DirectorResponse.cs
 * Descripción:         Clase DTO que representa la respuesta del módulo Director.
 *                      Contiene propiedades que describen la información de un director,
 *                      incluyendo datos personales, contacto, cargos, fechas relevantes,
 *                      estado, descripciones asociadas y un índice auxiliar.
 *                      Además, expone una propiedad calculada para obtener el nombre completo.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial del DTO DirectorResponse.
 ***********/

namespace Empresa.Presentation.Director.Responses
{
    public class DirectorResponse
    {
        public int nIdRegistro { get; set; }
        public int nIdEmpresa { get; set; }
        public int nTipoDocumento { get; set; }
        public string sNumeroDocumento { get; set; } = default!;
        public string sNombres { get; set; } = default!;
        public string sApellidos { get; set; } = default!;
        public DateTime dFechaNacimiento { get; set; }
        public int nGenero { get; set; }
        public string sDistrito { get; set; } = default!;
        public string sProvincia { get; set; } = default!;
        public string sDepartamento { get; set; } = default!;
        public string sDireccion { get; set; } = default!;
        public string sTelefono { get; set; } = default!;
        public string? sTelefonoSecundario { get; set; }
        public string? sTelefonoTerciario { get; set; }
        public string sCorreo { get; set; } = default!;
        public string? sCorreoSecundario { get; set; }
        public string? sCorreoTerciario { get; set; }
        public int nCargo { get; set; }
        public int nTipoDirector { get; set; }
        public int nIdSector { get; set; }
        public string sProfesion { get; set; } = default!;
        public decimal mDieta { get; set; }
        public int nEspecialidad { get; set; }
        public DateTime dFechaNombramiento { get; set; }
        public DateTime dFechaDesignacion { get; set; }
        public DateTime? dFechaRenuncia { get; set; }
        public string? sComentario { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public string sTipoDocumentoDescripcion { get; set; } = default!;
        public string sCargoDescripcion { get; set; } = default!;
        public string sTipoDirectorDescripcion { get; set; } = default!;
        public int indice { get; set; }
        public string sNombreCompleto => $"{sApellidos} {sNombres}";

    }
}
