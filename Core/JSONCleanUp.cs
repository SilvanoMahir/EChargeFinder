using Newtonsoft.Json.Linq;

namespace EChargeFinder.Core
{
    public class JSONCleanUp
    {
        // this function fixes the ChargingStationNames inconsistencies which are coming from the API
        public string cleanUpChargingStationAPINamingError(string jsonString)
        {
            var jsonObject = JObject.Parse(jsonString);

            foreach (var evseData in jsonObject["EVSEData"])
            {
                foreach (var record in evseData["EVSEDataRecord"])
                {
                    if (record["ChargingStationNames"].Type == JTokenType.Object)
                    {
                        var singleObject = (JObject)record["ChargingStationNames"];
                        var lang = singleObject["lang"]?.ToString();
                        var value = singleObject["value"]?.ToString();

                        record["ChargingStationNames"] = new JArray
                {
                    new JObject
                    {
                        { "lang", lang },
                        { "value", value }
                    }
                };
                    }
                    else if (record["ChargingStationNames"].Type == JTokenType.Array)
                    {
                        var array = (JArray)record["ChargingStationNames"];
                        foreach (var item in array)
                        {
                            if (item.Type == JTokenType.Object)
                            {
                                var itemObject = (JObject)item;
                                if (itemObject["lang"] == null || itemObject["value"] == null)
                                {
                                    // Handle invalid items if necessary
                                }
                            }
                        }
                    }
                }
            }
            return jsonObject.ToString(Newtonsoft.Json.Formatting.Indented);
        }
    }
}
