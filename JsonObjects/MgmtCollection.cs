using Newtonsoft.Json;

namespace ElastiRestApi.Business.JsonObjects
{
    public class MgmtCollection
    {
        [JsonProperty("mgmt")]
        public MgmtObject MgmtMgmt { get; set; }
    }
}
