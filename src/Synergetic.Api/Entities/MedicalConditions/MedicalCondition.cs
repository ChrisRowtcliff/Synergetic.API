namespace Synergetic.Api.Entities.MedicalConditions
{
    using System;
    using System.Text.Json.Serialization;

    public class MedicalCondition
    {
        [JsonPropertyName("MedicalConditionSeq")]
        public int MedicalConditionSeq { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("MedicalConditionCode")]
        public string MedicalConditionCode { get; set; }

        [JsonPropertyName("ActiveFlag")]
        public bool ActiveFlag { get; set; }

        [JsonPropertyName("ConditionDetails")]
        public string ConditionDetails { get; set; }

        [JsonPropertyName("SeverityCode")]
        public string SeverityCode { get; set; }

        [JsonPropertyName("ConfidentialFlag")]
        public bool? ConfidentialFlag { get; set; }

        [JsonPropertyName("EmergencyTreatmentDetails")]
        public string EmergencyTreatmentDetails { get; set; }

        [JsonPropertyName("OtherTreatmentDetails")]
        public string OtherTreatmentDetails { get; set; }

        [JsonPropertyName("NotifiedStartDate")]
        public DateTime? NotifiedStartDate { get; set; }

        [JsonPropertyName("ConditionEndDate")]
        public DateTime? ConditionEndDate { get; set; }

        [JsonPropertyName("ModifiedBy")]
        public int? ModifiedBy { get; set; }

        [JsonPropertyName("ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        [JsonPropertyName("NotifiedBy")]
        public int? NotifiedBy { get; set; }

        [JsonPropertyName("Visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("MedicalConditionDocumentID")]
        public string MedicalConditionDocumentID { get; set; }

        [JsonPropertyName("ActiveAnaphylaxisFlag")]
        public bool ActiveAnaphylaxisFlag { get; set; }

        [JsonPropertyName("MedicalConditionDescription")]
        public string MedicalConditionDescription { get; set; }

        [JsonPropertyName("MedicalSeverityDescrption")]
        public string MedicalSeverityDescrption { get; set; }

        [JsonPropertyName("RGB")]
        public string RGB { get; set; }
    }
}