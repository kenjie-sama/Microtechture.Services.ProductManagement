using Microtechture.Common.Constants.Enums;

namespace Microtechture.Common.Models.Complex
{
    /// <summary>
    /// Use this to represent the result of an operation, such as a repository action or a service method. 
    /// It provides information about the success or failure of the operation, along with a message and status code. 
    /// This can be used to standardize the way results are handled across the application and to provide more meaningful feedback to the caller.
    /// </summary>
    public class TaskResult
    {
        public string Message { get; private set; }
        public ResultStatus Status { get; private set; }
        public bool IsSuccess { get; private set; } = false;
        public bool IsCompleted { get; private set; } = false;

        public static TaskResult Success(string message) => new() 
        { 
            Message = message, 
            IsSuccess = true, 
            IsCompleted = true, 
            Status = ResultStatus.OK 
        };

        public static TaskResult Fail(string message) => new() 
        {
            Message = message, 
            IsSuccess = false, 
            IsCompleted = true, 
            Status = ResultStatus.Error 
        };

        public static TaskResult Cancelled(string message) => new() 
        { 
            Message = message, 
            IsSuccess = false, 
            IsCompleted = false, 
            Status = ResultStatus.Cancelled 
        };


        public static TaskResult GetResult(int resultId, string successMessage, string failedMeessage) => resultId != 0 ? 
            TaskResult.Success(successMessage) : 
            TaskResult.Fail(failedMeessage);

        public bool IsOk() => IsSuccess && IsCompleted;
    }
}
