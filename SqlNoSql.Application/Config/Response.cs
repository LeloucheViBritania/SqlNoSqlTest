namespace SqlNoSql.Application.Config
{
    public static class Response
    {
        public static Response<TData> Failure<TData>(Error error)
        {
            return new Response<TData>(false, default, error);
        }

        public static Response<TData> Ok<TData>(TData value= default)
        {
            return new Response<TData>(true, value, null);
        }
    }

    public class Response<TData>
    {
        public bool Succeed { get; set; }
        public TData Value { get; set; }
        public Error Error { get; set; }
        public Response(bool succeed, TData value, Error error)
        {
            Succeed = succeed;
            Value = value;
            Error = error;
        }

    }
}
