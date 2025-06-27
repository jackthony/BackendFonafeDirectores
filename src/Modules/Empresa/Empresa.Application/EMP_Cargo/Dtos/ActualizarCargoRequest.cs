<<<<<<< HEAD
﻿namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class ActualizarCargoRequest
    {
        public required int CargoId { get; set; }
        public required int UsuarioModificacionId { get; set; }
        public string? NombreCargo { get; set; }
        public bool? IsActivo { get; set; }
=======
﻿namespace Empresa.Application.Cargo.Dtos
{
    public class ActualizarCargoRequest
    {
        public int nIdCargo { get; set; }
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }
>>>>>>> origin/masterboa
    }
}
