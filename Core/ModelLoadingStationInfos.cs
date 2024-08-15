namespace EChargeFinder.Core
{
    public class Address
    {
        public string HouseNum { get; set; }
        public string TimeZone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
    }

    public class ChargingFacility
    {
        public int Power { get; set; }
        public string Powertype { get; set; }
    }

    public class ChargingStationName
    {
        public string Lang { get; set; }
        public string Value { get; set; }
    }

    public class GeoCoordinates
    {
        public string Google { get; set; }
    }

    public class EVSEDataRecord
    {
        public string AccessibilityLocation { get; set; }
        public Address Address { get; set; }
        public List<string> AuthenticationModes { get; set; }
        public string CalibrationLawDataAvailability { get; set; }
        public List<ChargingFacility> ChargingFacilities { get; set; }
        public List<ChargingStationName> ChargingStationNames { get; set; }
        public string DynamicInfoAvailable { get; set; }
        public string HotlinePhoneNumber { get; set; }
        public string HubOperatorID { get; set; }
        public bool IsHubjectCompatible { get; set; }
        public bool IsOpen24Hours { get; set; }
        public List<string> PaymentOptions { get; set; }
        public List<string> Plugs { get; set; }
        public bool RenewableEnergy { get; set; }
        public string Accessibility { get; set; }
        public string ChargingStationId { get; set; }
        public GeoCoordinates GeoCoordinates { get; set; }
        public string LastUpdate { get; set; }
        public string EvseID { get; set; }
    }

    public class EVSEData
    {
        public List<EVSEDataRecord> EVSEDataRecord { get; set; }
    }

    public class LoadingStationInfos
    {
        public List<EVSEData> EVSEData { get; set; }
    }

    public class BaseData
    {
        public EVSEDataRecord dataRecord { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string chargingStationId { get; set; } // Add this line
        public bool renewableEnergy { get; set; }
        public string availability { get; set; }
    }
}