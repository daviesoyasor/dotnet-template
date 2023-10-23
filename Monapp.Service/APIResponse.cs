using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monapp.Service
{
    public class APIResponse
    {
        public object? Data { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public APIResponse(object? data, int statusCode, string message) {
            Data = data;
            StatusCode = statusCode;
            Message = message;
        }
    }
}
