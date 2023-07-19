using System;
namespace EpicFood_API.Models.Custom
{
    public class ResponseAuthorization
    {
        public string Token { get; set; }
        public string RefresToken { get; set; }
        public bool Result { get; set; }
        public string Message { get; set; }

    }
}

