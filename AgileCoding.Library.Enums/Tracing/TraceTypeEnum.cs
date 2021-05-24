namespace AgileCoding.Library.Enums.Logging
{
    public enum TraceTypeEnum
    {
        /// <summary>
        /// Starting a local transaction
        /// </summary>
        Start = 256,

        /// <summary>
        /// Stoppng a local transaction
        /// </summary>
        Stop = 512,

        /// <summary>
        /// Suspension of a local transaction
        /// </summary>
        Suspend = 1024,

        /// <summary>
        /// Continuation of a logical transaction.
        /// </summary>
        Resume = 2048,

        /// <summary>
        /// Used to indicate control of transaction is passed to a diffrent section in the current system.
        /// </summary>
        Transfer = 4096,

        /// <summary>
        /// Used to indicate control is received back again from the section it was given to by 'Tranfer'
        /// </summary>
        Retain = 8192,

        /// <summary>
        /// Used to indicate another system or program received control and  a sub transaction needs to be started
        /// </summary>
        SubStart = 16384,

        /// <summary>
        /// Used to indicate a sub transaction has stopped
        /// </summary>
        SubStop = 32768,
    }
}