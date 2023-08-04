AgileCoding.Library.Enums NuGet Package
=======================================

This NuGet package provides a standardized set of enumerations (Enums) across different domains, which can be beneficial in providing consistency throughout your .NET applications.

Enumerations
------------

The package includes the following Enums:

1.  `ServiceRequestTypeEnum` - Represents the types of service requests.
2.  `LogTypeEnum` - Represents the type of log information.
3.  `SystemEnvironmentEnum` - Represents the type of system environment.
4.  `TraceTypeEnum` - Represents the type of trace.

Here's an overview of each:

### ServiceRequestTypeEnum

Used to define the types of service requests.

```csharp
namespace AgileCoding.Library.Enums.Integration
{
    public enum ServiceRequestTypeEnum
    {
        NA = 0,
        RESTAPI = 1,
        SOAP11 = 11,   //DataPower Call using Text Encoding
        SOAP12 = 12,   //Direct Call using WCF MTOM encoding
    }
}
```

### LogTypeEnum

Defines the type of log information, ranging from tracing details to error logs.

```csharp
namespace AgileCoding.Library.Enums.Logging
{
    public enum LogTypeEnum
    {
        Trace = 0,       // Used for tracing details
        Critical = 1,    // Used to raise critical Errors
        Error = 2,       // Used to raise Errors
        Warning = 4,     // Used to raise Warnings
        Information = 8, // For Trace Information
        Verbose = 16,    // For Debugging information
        Performance = 32,// For performance logs
        None = 999,      // Logging is disabled
    }
}
```

### SystemEnvironmentEnum

Used to specify the type of system environment.

```csharp
namespace AgileCoding.Library.Enums.SAS
{
    public enum SystemEnvironmentEnum
    {
        None,
        LOCAL,  // Local Dev Box
        DEV,    // Development Environment
        SIT,    // Software Integration Testing
        UAT,    // User Acceptance Testing
        PROD,   // Production Environment
        DR      // Disaster Recovery
    }
}
```

### TraceTypeEnum

Defines the type of trace, particularly for transactions.

```csharp
namespace AgileCoding.Library.Enums.Logging
{
    public enum TraceTypeEnum
    {
        Start = 256,     // Starting a local transaction
        Stop = 512,      // Stopping a local transaction
        Suspend = 1024,  // Suspension of a local transaction
        Resume = 2048,   // Continuation of a logical transaction
        Transfer = 4096, // Control of transaction is passed to a different section
        Retain = 8192,   // Control is received back again from the section it was given to
        SubStart = 16384,// Start of a sub transaction
        SubStop = 32768, // End of a sub transaction
    }
}
```

Installation
------------

You can install this NuGet package through the following ways:

### Package Manager

mathematicaCopy code

`PM> Install-Package AgileCoding.Library.Enums`

### .NET CLI

csharpCopy code

`dotnet add package AgileCoding.Library.Enums`

Requirements
------------

-   .NET 6.0 or later

Contribute
----------

This is an open source project. We encourage you to contribute to it by submitting issues, or directly contributing code.

License
-------

This project is licensed under the terms of the MIT license.

Contact
-------

For questions or any other feedback, please open an issue in the GitHub repository.