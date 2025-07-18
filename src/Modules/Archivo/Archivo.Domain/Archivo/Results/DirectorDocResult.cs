﻿/*****
 * Nombre del archivo:  DirectorDocResult.cs
 * Descripción:         Clase que representa los resultados de un director en el contexto de los archivos. 
 *                      Contiene propiedades como `TipoDocumento`, `Documento`, `Departamento`, `FechaNacimiento`, entre otras, 
 *                      que describen al director y su información asociada en el sistema.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Domain.Archivo.Results
{
    public class DirectorDocResult
    {
        public string TipoDocumento { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Distrito { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public DateTime? FechaNacimiento { get; set; }
        public string Genero { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string TipoDirector { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public string Profesion { get; set; } = string.Empty;
        public decimal? Dieta { get; set; }
        public string Especialidad { get; set; } = string.Empty;
        public DateTime? FechaNombramiento { get; set; }
        public DateTime? FechaDesignacion { get; set; }
        public string FechaRenuncia { get; set; } = string.Empty;
        public string Comentarios { get; set; } = string.Empty;

        public int IdEmpresa { get; set; }
        public int IdRegistro { get; set; }
        public string Ruc { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
    }
}
