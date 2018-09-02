using System;

namespace Lendtick.Product.Common
{
    public interface IResultStatus
    {
        bool IsSuccess { get; }

        string Message { get; set; }
        string ExternalMessage { get; set; }

        IResultStatus ReturnErrorStatus(string message);
        IResultStatus ReturnErrorStatus(string message, string externalMessage);

        IResultStatus ReturnSuccessStatus();
        IResultStatus ReturnSuccessStatus(string message);
        IResultStatus ReturnSuccessStatus(string message, string externalMessage);

        void SetErrorStatus(string message);
        void SetErrorStatus(Exception ex, string message);
        void SetErrorStatus(string message, string externalMessage);

        void SetSuccessStatus();
        void SetSuccessStatus(string message);
        void SetSuccessStatus(string message, string externalMessage);
    }
}