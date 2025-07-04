namespace Archivo.Presentation.Archivo.Responses
{
    public class ElementoNodoResponse<T>
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public int? codeParent { get; set; }
        public int status { get; set; }
        public T? element { get; set; }
        public bool hasChildren { get; set; }
        public List<ElementoNodoResponse<T>> Children { get; set; } = [];
    }
}
