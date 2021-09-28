using System;

namespace assignment1.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Description { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
