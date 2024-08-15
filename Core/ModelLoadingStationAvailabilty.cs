namespace EChargeFinder.Core
{
    public class EVSEStatusesList
    {
        public List<EVSEStatuses> EVSEStatuses { get; set; }
    }

    public class EVSEStatusRecord
    {
        public string EvseID { get; set; }
        public string EVSEStatus { get; set; }
    }

    public class EVSEStatuses
    {
        public List<EVSEStatusRecord> EVSEStatusRecord { get; set; }
    }
}
