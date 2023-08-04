namespace AgileCoding.Library.Enums.Integration
{
    public enum ServiceRequestTypeEnum
    {
        NA = 0,

        RESTAPI = 1,

        //This is DataPower Call using Text Encoding
        SOAP11 = 11,

        //This is Direct Call using WCF MTOM encoding
        SOAP12 = 12,

    }
}
