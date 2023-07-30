namespace Models.Response
{
    public sealed class NotFoundResponse : ApiNotFoundResponse
    {
        public NotFoundResponse(string message)
            : base(message) { }
    }
}
