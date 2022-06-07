namespace Synergetic.Api.Services.MedicalConditions
{
    using System.Text.Json.Serialization;

    public class CreateMedicalConditionsRequest
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("MedicalConditionCode")]
        public string MedicalConditionCode { get; set; }

        [JsonPropertyName("ActiveFlag")]
        public string ActiveFlag { get; set; }

        [JsonPropertyName("ConditionDetails")]
        public string ConditionDetails { get; set; }

        [JsonPropertyName("SeverityCode")]
        public string SeverityCode { get; set; }

        [JsonPropertyName("ConfidentialFlag")]
        public string ConfidentialFlag { get; set; }

        [JsonPropertyName("EmergencyTreatmentDetails")]
        public string EmergencyTreatmentDetails { get; set; }

        [JsonPropertyName("OtherTreatmentDetails")]
        public string OtherTreatmentDetails { get; set; }

        [JsonPropertyName("NotifiedStartDate")]
        public string NotifiedStartDate { get; set; }

        [JsonPropertyName("ConditionEndDate")]
        public string ConditionEndDate { get; set; }

        [JsonPropertyName("NotifiedBy")]
        public string NotifiedBy { get; set; }

        [JsonPropertyName("Visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("MedicalConditionDocumentID")]
        public string MedicalConditionDocumentID { get; set; }
    }
}