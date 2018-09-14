namespace Lendtick.Product.API.Core.AppHelper.Logger
{
    internal interface ILogManager<T> where T : class
    {
        void LogInfo(T logInfo);
        void LogWarn(T logInfo);
        void LogDebug(T logInfo);
        void LogError(T logInfo);
    }
}
