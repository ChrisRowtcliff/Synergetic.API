namespace Synergetic.Api.Services.StudentAllergies
{
    using System.Text.Json.Serialization;

    public class CreateStudentAllergyRequest
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("MedicalAllergyTypeCode")]
        public string MedicalAllergyTypeCode { get; set; }

        [JsonPropertyName("SeverityCode")]
        public string SeverityCode { get; set; }

        [JsonPropertyName("ActiveFlag")]
        public bool ActiveFlag { get; set; }

        [JsonPropertyName("AllergyDescription")]
        public string AllergyDescription { get; set; }

        [JsonPropertyName("AllergyTreatment")]
        public string AllergyTreatment { get; set; }
    }
}