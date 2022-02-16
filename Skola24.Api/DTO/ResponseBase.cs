namespace Skola24.Api.DTO
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            IsSuccess = true;
        }
        public bool IsSuccess { get; set; }
    }
}
