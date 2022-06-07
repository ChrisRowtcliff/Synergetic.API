namespace Synergetic.Api.Entities.Common
{
    using System.Text.Json.Serialization;

    public class EntityResult
    {
        [JsonPropertyName("RowNum")]
        public int RowNum { get; set; }

        [JsonPropertyName("Result")]
        public Result Result { get; set; }
    }

    public class Result
    {
        /// <summary>The unique sequence number of the newly created or updated record</summary>
        [JsonPropertyName("EntitySeq")]
        public int EntitySeq { get; set; }
    }
}