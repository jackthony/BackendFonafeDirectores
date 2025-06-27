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
