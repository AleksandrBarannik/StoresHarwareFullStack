using System.Net;

namespace StoresHardware_HardWareAPI.Models
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            ErrorMessages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }

        public void FailedResponse(string _message)
        {
            IsSuccess = false;
            ErrorMessages = new List<string>() { _message };
        }

        public void SucsessResponse( HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            IsSuccess = true;           
        }
    }
}
