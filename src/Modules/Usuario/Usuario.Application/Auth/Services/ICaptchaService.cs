/***********
* Nombre del archivo: ICaptchaService.cs
* Descripción:        **Define la interfaz para el servicio de validación de CAPTCHA**.
*                     Proporciona un método único para **validar una respuesta de CAPTCHA**,
*                     el cual es fundamental para proteger las aplicaciones de bots y accesos automatizados.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz ICaptchaService.
***********/

namespace Usuario.Application.Auth.Services
{
    public interface ICaptchaService
    {
        Task<bool> ValidateCaptchaAsync(string captchaResponse);
    }
}
