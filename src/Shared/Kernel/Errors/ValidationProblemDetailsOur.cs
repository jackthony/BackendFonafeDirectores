namespace Shared.Kernel.Errors
{
    public class ValidationProblemDetailsOur : ProblemDetailsOur
    {
        public IDictionary<string, string[]> Errors { get; } = new Dictionary<string, string[]>(StringComparer.Ordinal);

        public ValidationProblemDetailsOur()
        {
        }

        public ValidationProblemDetailsOur(IDictionary<string, string[]> errors)
        {
            if (errors == null)
                throw new ArgumentNullException(nameof(errors));

            foreach (var kvp in errors)
            {
                Errors.Add(kvp.Key, kvp.Value);
            }
        }
    }
}
