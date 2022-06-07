namespace Synergetic.Api.Services.MedicalDetails
{
    using System;
    using System.Text.Json.Serialization;

    public class CreateMedicalDetailRequest
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("AmbulanceFlag")]
        public bool AmbulanceFlag { get; set; }

        [JsonPropertyName("AmbulanceNo")]
        public string AmbulanceNo { get; set; }

        [JsonPropertyName("BloodGroup")]
        public string BloodGroup { get; set; }

        [JsonPropertyName("DisabilityLevel")]
        public string DisabilityLevel { get; set; }

        [JsonPropertyName("HealthCareCardExpiryDate")]
        public DateTime HealthCareCardExpiryDate { get; set; }

        [JsonPropertyName("HealthCareCardFlag")]
        public bool HealthCareCardFlag { get; set; }

        [JsonPropertyName("HealthCareCardNo")]
        public string HealthCareCardNo { get; set; }

        [JsonPropertyName("ImmunisationFormDate")]
        public DateTime ImmunisationFormDate { get; set; }

        [JsonPropertyName("ImmunisationFormFlag")]
        public bool ImmunisationFormFlag { get; set; }

        [JsonPropertyName("ImmunisationFormStatus")]
        public string ImmunisationFormStatus { get; set; }

        [JsonPropertyName("ImmunisationOtherDetails")]
        public string ImmunisationOtherDetails { get; set; }

        [JsonPropertyName("MedicareExpiryDate")]
        public DateTime MedicareExpiryDate { get; set; }

        [JsonPropertyName("MedicareLineNo")]
        public int MedicareLineNo { get; set; }

        [JsonPropertyName("MedicareNo")]
        public string MedicareNo { get; set; }

        [JsonPropertyName("PrivateHealthFundExpiryDate")]
        public DateTime PrivateHealthFundExpiryDate { get; set; }

        [JsonPropertyName("PrivateInsuranceExtraCoverFlag")]
        public bool PrivateInsuranceExtraCoverFlag { get; set; }

        [JsonPropertyName("PrivateInsuranceFlag")]
        public bool PrivateInsuranceFlag { get; set; }

        [JsonPropertyName("PrivateInsuranceFund")]
        public string PrivateInsuranceFund { get; set; }

        [JsonPropertyName("PrivateInsuranceNo")]
        public string PrivateInsuranceNo { get; set; }

        [JsonPropertyName("PrivateInsuranceTable")]
        public string PrivateInsuranceTable { get; set; }
    }
}