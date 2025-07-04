namespace Archivo.Presentation.Archivo.Responses
{
    public class ListResponse<T>
    {
        public bool IsSuccess { get; set; }
        public List<T> LstItem { get; set; } = new();
    }
}
