namespace Synergetic.Api.Services.MedicalImmunisations
{
    using System.Text.Json.Serialization;

    public class CreateMedicalImmunisationRequest
    {
        [JsonPropertyName("MedicalImmunisationSeq")]
        public int MedicalImmunisationSeq { get; set; }

        [JsonPropertyName("ImmunisationCode")]
        public string ImmunisationCode { get; set; }

        [JsonPropertyName("ActiveFlag")]
        public bool ActiveFlag { get; set; }

        [JsonPropertyName("VaccineBrandCode")]
        public string VaccineBrandCode { get; set; }

        [JsonPropertyName("BatchNo")]
        public string BatchNo { get; set; }

        [JsonPropertyName("ImmunityEndDate")]
        public string ImmunityEndDate { get; set; }

        [JsonPropertyName("AdministeredBy")]
        public string AdministeredBy { get; set; }

        [JsonPropertyName("AdministeredDate")]
        public string AdministeredDate { get; set; }
    }
}