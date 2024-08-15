using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EChargeFinder.Core
{
    public class JSONCleanUp
    {
        // this function fixes the ChargingStationNames inconsistencies which are coming from the API
        public string cleanUpChargingStationAPINamingError(string jsonString)
        {
            JObject jsonObject = JObject.Parse(jsonString);

            // Process each EVSEData record
            foreach (var evseData in jsonObject["EVSEData"])
            {
                foreach (var record in evseData["EVSEDataRecord"])
                {
                    // Check if ChargingStationNames is an object
                    if (record["ChargingStationNames"].Type == JTokenType.Object)
                    {
                        var singleObject = record["ChargingStationNames"] as JObject;
                        var lang = singleObject["lang"]?.ToString();
                        var value = singleObject["value"]?.ToString();

                        // Replace with an array containing the single object
                        record["ChargingStationNames"] = new JArray(
                            new JObject
                                    {
                            { "lang", lang },
                            { "value", value }
                                    }
                        );
                    }
                    else if (record["ChargingStationNames"].Type == JTokenType.Array)
                    {
                        // Ensure that each item in the array is of the correct format
                        var array = record["ChargingStationNames"] as JArray;
                        foreach (var item in array)
                        {
                            if (item["lang"] == null || item["value"] == null)
                            {
                                // Handle invalid items if necessary
                            }
                        }
                    }
                }
            }
            return jsonObject.ToString(Formatting.Indented);
        }
    }
}
