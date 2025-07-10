/***********
 * Nombre del archivo:  DietaModel.cs
 * Descripción:         Modelo que representa la dieta asociada a un RUC y tipo de cargo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación del modelo DietaModel con propiedades y constructor.
 ***********/

namespace Empresa.Domain.EMP_Dieta.Models
{
    public class DietaModel
    {
        public string SRUC { get; set; }
        public int NTipoCargo { get; set; }
        public decimal MDieta { get; set; }

        public DietaModel(string sRUC, int nTipoCargo, decimal mDieta)
        {
            SRUC = sRUC;
            NTipoCargo = nTipoCargo;
            MDieta = mDieta;
        }
    }
}
