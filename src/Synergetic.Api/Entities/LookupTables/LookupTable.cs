namespace Synergetic.Api.Entities.LookupTables
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    
    public class LookupTable
    {
        /// <summary>The name of the lookup tables associated with the given entity</summary>
        [JsonPropertyName("LookupTableName")]
        public string LookupTableName { get; set; }

        /// <summary>
        /// The list of values contained in the lookup table
        /// </summary>
        [JsonPropertyName("Values")]
        public List<LookupValues> Values { get; set; }
    }

    public class LookupValues
    {
        /// <summary>
        /// The code of the value. This will be the value stored in the main entity
        /// </summary>
        [JsonPropertyName("Code")]
        public string Code { get; set; }

        /// <summary>
        /// The long description of the record
        /// </summary>
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        /// <summary>
        /// The SynergyMeaning of the entry. See https://wiki.synergetic.net.au/display/SYNMAIN/SynergyMeanings for a description
        /// </summary>
        [JsonPropertyName("Meaning")]
        public string Meaning { get; set; }
    }
}