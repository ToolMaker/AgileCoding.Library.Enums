namespace AgileCoding.Library.Enums.Logging
{
    public enum LogTypeEnum
    {
        /// <summary>
        /// Used to indicate Tracing details. Tracing refers to Start and stopping of threads. If execution is handed over to an external service or application then Trace used to create a Sub trace code
        /// </summary>
        Trace = 0,

        /// <summary>
        /// Used to raise critical Errors
        /// </summary>
        Critical = 1,

        /// <summary>
        /// Used to raise Error
        /// </summary>
        Error = 2,

        /// <summary>
        /// Used to raise Warnings
        /// </summary>
        Warning = 4,

        /// <summary>
        /// Used For Trace Information. Dont use if not necessary.
        /// </summary>
        Information = 8,

        /// <summary>
        /// Used for Debugging information
        /// </summary>
        Verbose = 16,

        /// <summary>
        /// Used for performance logs. Lis log are minimal time based with a lable
        /// </summary>
        Performance = 32,

        /// <summary>
        /// Logging is disabled
        /// </summary>
        None = 999,
    }
}