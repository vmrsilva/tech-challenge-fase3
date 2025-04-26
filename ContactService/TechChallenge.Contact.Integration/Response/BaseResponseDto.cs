namespace TechChallenge.Contact.Integration.Response
{
    public record BaseResponseDto<T> : BaseResponse
    {

        public T Data { get; init; }
    }
}
