using JetBrains.Annotations;
using System;

namespace EFCore.ManyToMany.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}