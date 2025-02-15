namespace DahitanGhar.Domain.Common;
public class OperationResult
{
    public bool IsSuccess { get; }
    public string? Message { get; }

    public OperationResult(bool isSuccess, string? message = null)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    public static OperationResult Success() => new OperationResult(true);
    public static OperationResult<T> Success<T>(T data) => new OperationResult<T>(true, data, null);
    public static OperationResult<T> Failure<T>(string message) => new OperationResult<T>(false, default, message);

}

public class OperationResult<T> : OperationResult
{
    public T? Data { get; set; }

    public OperationResult(bool isSuccess, T? data, string? message) : base(isSuccess, message)
    {
        Data = data;
    }
    public static OperationResult<T> Success(T data) => new OperationResult<T>(true, data, null);

}