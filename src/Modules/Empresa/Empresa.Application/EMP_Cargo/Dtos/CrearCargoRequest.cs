<<<<<<< HEAD
﻿namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class CrearCargoRequest
    {
        public required string NombreCargo { get; set; }
        public required int UsuarioRegistroId { get; set; }
=======
﻿namespace Empresa.Application.Cargo.Dtos
{
    public class CrearCargoRequest
    {
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }
>>>>>>> origin/masterboa
    }
}
