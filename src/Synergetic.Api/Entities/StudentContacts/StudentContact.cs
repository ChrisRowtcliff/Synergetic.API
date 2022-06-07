namespace Synergetic.Api.Entities.StudentContacts
{
    using System;
    using System.Text.Json.Serialization;

    public class StudentContact
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("ContactType")]
        public string ContactType { get; set; }

        [JsonPropertyName("LinkedID")]
        public int LinkedID { get; set; }

        [JsonPropertyName("LinkedIDSeq")]
        public int LinkedIDSeq { get; set; }

        [JsonPropertyName("PrimaryOnlyFlag")]
        public bool PrimaryOnlyFlag { get; set; }

        [JsonPropertyName("NormalMailFlag")]
        public bool NormalMailFlag { get; set; }

        [JsonPropertyName("ReportsFlag")]
        public bool ReportsFlag { get; set; }

        [JsonPropertyName("ParentFlag")]
        public bool ParentFlag { get; set; }

        [JsonPropertyName("LivesWithFlag")]
        public bool LivesWithFlag { get; set; }

        [JsonPropertyName("SIF3RefID")]
        public Guid? SIF3RefID { get; set; }

        [JsonPropertyName("StudentContactsSeq")]
        public int StudentContactsSeq { get; set; }

        [JsonPropertyName("SpouseSIF3RefID")]
        public Guid? SpouseSIF3RefID { get; set; }
    }
}