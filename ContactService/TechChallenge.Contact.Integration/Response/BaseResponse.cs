namespace TechChallenge.Contact.Integration.Response
{
    public record BaseResponse
    {
        public bool Success { get; init; }
        public string Error { get; init; }
        public IEnumerable<string> Errors { get; init; }
    }
}
