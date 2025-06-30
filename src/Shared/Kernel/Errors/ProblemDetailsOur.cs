using Microsoft.AspNetCore.Mvc;

namespace Shared.Kernel.Errors
{
    public class ProblemDetailsOur : ProblemDetails
    {
        public bool showToast { get; set; }
    }
}
