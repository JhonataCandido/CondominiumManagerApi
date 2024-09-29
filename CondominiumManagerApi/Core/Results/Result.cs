namespace CondominiumManagerApi.Core.Results
{
    public class Result<T>(T data, bool isSuccess, string message)
    {
        public T Data { get; private set; } = data;
        public bool IsSuccess { get; private set; } = isSuccess;
        public string Message { get; private set; } = message;
        public static Result<T> Success(T data) => new(data, true, string.Empty);
        public static Result<T> Failure(string message) => new(default, false, message);
    }
}