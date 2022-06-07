namespace Synergetic.Api.Entities.MedicalImmunisations
{
    using System;
    using System.Text.Json.Serialization;

    public class MedicalImmunisation
    {
        [JsonPropertyName("MedicalImmunisationSeq")]
        public int MedicalImmunisationSeq { get; set; }

        [JsonPropertyName("ComboDrugSeq")]
        public int? ComboDrugSeq { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("ImmunisationCode")]
        public string ImmunisationCode { get; set; }

        [JsonPropertyName("ActiveFlag")]
        public bool ActiveFlag { get; set; }

        [JsonPropertyName("VaccineBrandCode")]
        public string VaccineBrandCode { get; set; }

        [JsonPropertyName("BatchNo")]
        public string BatchNo { get; set; }

        [JsonPropertyName("AdministeredBy")]
        public string AdministeredBy { get; set; }

        [JsonPropertyName("AdministeredDate")]
        public DateTime? AdministeredDate { get; set; }

        [JsonPropertyName("ImmunityEndDate")]
        public DateTime? ImmunityEndDate { get; set; }

        [JsonPropertyName("ModifiedBy")]
        public int? ModifiedBy { get; set; }

        [JsonPropertyName("ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

        [JsonPropertyName("ImmunisationDescription")]
        public string ImmunisationDescription { get; set; }
    }
}