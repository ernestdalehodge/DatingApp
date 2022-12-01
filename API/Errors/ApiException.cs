namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, string message, string description)
        {
            this.StatusCode = statusCode;
            this.Message = message;
            this.Description = description;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        
    }
}