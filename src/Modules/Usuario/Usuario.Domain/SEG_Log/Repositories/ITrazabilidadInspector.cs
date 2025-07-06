namespace Usuario.Domain.SEG_Log.Repositories
{
    public interface ITrazabilidadInspector
    {
        Task<string?> ObtenerEstadoActualAsync(string tabla, string campoId, int valorId);
    }
}
