namespace Synergetic.Api.Entities.StudentResults
{
    using System;
    using System.Text.Json.Serialization;

    public class StudentResult
    {
        [JsonPropertyName("FileType")]
        public string FileType { get; set; }

        [JsonPropertyName("FileYear")]
        public int FileYear { get; set; }

        [JsonPropertyName("FileSemester")]
        public int FileSemester { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("ClassCampus")]
        public string ClassCampus { get; set; }

        [JsonPropertyName("ClassCode")]
        public string ClassCode { get; set; }

        [JsonPropertyName("AreaSeq")]
        public int AreaSeq { get; set; }

        [JsonPropertyName("Result")]
        public string Result { get; set; }

        [JsonPropertyName("OverrideFlag")]
        public bool OverrideFlag { get; set; }

        [JsonPropertyName("TopicComment")]
        public string TopicComment { get; set; }

        [JsonPropertyName("PrintFlag")]
        public bool PrintFlag { get; set; }

        [JsonPropertyName("ResultClassification")]
        public string ResultClassification { get; set; }

        [JsonPropertyName("ResultDate")]
        public DateTime ResultDate { get; set; }

        [JsonPropertyName("IndigenousPaperFlag")]
        public bool IndigenousPaperFlag { get; set; }

        [JsonPropertyName("IndigenousAnswerFlag")]
        public bool IndigenousAnswerFlag { get; set; }

        [JsonPropertyName("StudentAssessmentResultsSeq")]
        public int StudentAssessmentResultsSeq { get; set; }

        [JsonPropertyName("SubjectClassesSeq")]
        public int SubjectClassesSeq { get; set; }

        [JsonPropertyName("AssessmentRequestType")]
        public string AssessmentRequestType { get; set; }

        [JsonPropertyName("SIF3RefID")]
        public Guid? SIF3RefID { get; set; }
    }
}