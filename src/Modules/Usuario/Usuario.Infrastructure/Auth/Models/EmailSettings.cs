/***********
 * Nombre del archivo:  EmailSettings.cs
 * Descripción:         Clase de configuración para el servicio de correo electrónico.
 *                      Contiene parámetros como host, puerto, credenciales y remitente predeterminado.
 *                      Se utiliza para enviar notificaciones y validaciones por correo.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial de parámetros SMTP para integración con Hostinger.
 ***********/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Infrastructure.Auth.Models
{
    public record EmailSettings
    {
        public string Host { get; init; } = "smtp.hostinger.com";
        public int Port { get; init; } = 465;                // TLS implícito
        public string User { get; init; } = default!;
        public string Pass { get; init; } = default!;
        public string From { get; init; } = default!;
    }
}
