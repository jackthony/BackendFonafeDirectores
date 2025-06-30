using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Shared.Kernel.Errors
{
    public class ValidationProblemDetailsOur : ValidationProblemDetails
    {
        public bool ShowToast { get; set; } = true;

        public ValidationProblemDetailsOur() : base()
        {
        }

        public ValidationProblemDetailsOur(IDictionary<string, string[]> errors) : base()
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
