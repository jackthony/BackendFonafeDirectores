/***********
 * Nombre del archivo:  ModuloConAccionesResponseMapper.cs
 * Descripción:         Mapeador que convierte objetos ModuloConAccionesResult en respuestas
 *                      ModuloConAccionesResponse, deserializando acciones desde JSON.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapeador con soporte para deserialización de acciones.
 ***********/

using System.Text.Json;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Mappers
{
    public static class ModuloConAccionesResponseMapper
    {
        public static ModuloConAccionesResponse ToResponse(ModuloConAccionesResult dto)
        {
            var acciones = new List<AccionResponse>();

            if (!string.IsNullOrWhiteSpace(dto.AccionesJson))
            {
                try
                {
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                    acciones = JsonSerializer.Deserialize<List<AccionResponse>>(dto.AccionesJson, opciones) ?? [];
                }
                catch(Exception ex) 
                {
                    acciones = [];
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }

            return new ModuloConAccionesResponse
            {
                nModuloId = dto.ModuloId,
                sNombre = dto.Nombre,
                sRuta = dto.Ruta,
                sIcono = dto.Icono,
                bModuloPermitido = dto.ModuloPermitido,
                acciones = acciones
            };
        }

        public static IEnumerable<ModuloConAccionesResponse> ToListResponse(IEnumerable<ModuloConAccionesResult> items)
            => items.Select(ToResponse);
    }
}
