<<<<<<< HEAD
﻿namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class EliminarCargoRequest
    {
        public required int CargoId { get; set; }
        public required int UsuarioModificacionId { get; set; }
    }

=======
﻿namespace Empresa.Application.Cargo.Dtos
{
    public class EliminarCargoRequest
    {
        public int nIdCargo { get; set; }
        public int nUsuarioModificacion { get; set; }
    }
>>>>>>> origin/masterboa
}
