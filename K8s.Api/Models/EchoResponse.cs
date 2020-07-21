using System;

namespace K8s.Api.Models
{
    public class EchoResponse
    {
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
        public string Message { get; set; }
        public string MachineName { get; set; }
    }
}
