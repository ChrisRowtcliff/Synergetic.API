namespace Synergetic.Api.Entities.Students
{
    using System;
    using System.Text.Json.Serialization;

    public class Student
    {
        [JsonPropertyName("StudentID")]
        public int StudentID { get; set; }

        [JsonPropertyName("StudentPersonalInfo")]
        public StudentPersonalInfo StudentPersonalInfo { get; set; }

        [JsonPropertyName("StudentOccupEmail")]
        public string StudentOccupEmail { get; set; }

        [JsonPropertyName("StudentMobilePhone")]
        public string StudentMobilePhone { get; set; }

        [JsonPropertyName("StudentDefaultMobilePhone")]
        public string StudentDefaultMobilePhone { get; set; }

        [JsonPropertyName("StudentOccupMobilePhone")]
        public string StudentOccupMobilePhone { get; set; }

        [JsonPropertyName("StudentEmail")]
        public string StudentEmail { get; set; }

        [JsonPropertyName("StudentEducation")]
        public string StudentEducation { get; set; }

        [JsonPropertyName("StudentQualifications")]
        public string StudentQualifications { get; set; }

        [JsonPropertyName("FileYear")]
        public int FileYear { get; set; }

        [JsonPropertyName("FileSemester")]
        public int FileSemester { get; set; }

        [JsonPropertyName("StudentActiveFlag")]
        public bool StudentActiveFlag { get; set; }

        [JsonPropertyName("StudentStatus")]
        public string StudentStatus { get; set; }

        [JsonPropertyName("StudentStatusDescription")]
        public string StudentStatusDescription { get; set; }

        [JsonPropertyName("StudentStatusSynergyMeaning")]
        public string StudentStatusSynergyMeaning { get; set; }

        [JsonPropertyName("StudentStatusNextYear")]
        public string StudentStatusNextYear { get; set; }

        [JsonPropertyName("StudentCampus")]
        public string StudentCampus { get; set; }

        [JsonPropertyName("StudentCampusDescription")]
        public string StudentCampusDescription { get; set; }

        [JsonPropertyName("StudentCampusSort")]
        public int StudentCampusSort { get; set; }

        [JsonPropertyName("StudentCampusRSBNumber")]
        public string StudentCampusRSBNumber { get; set; }

        [JsonPropertyName("StudentYearLevel")]
        public int StudentYearLevel { get; set; }

        [JsonPropertyName("SchoolingYearOffset")]
        public int SchoolingYearOffset { get; set; }

        [JsonPropertyName("FundingYearLevel")]
        public int FundingYearLevel { get; set; }

        [JsonPropertyName("StudentTypeCode")]
        public string StudentTypeCode { get; set; }

        [JsonPropertyName("SecondaryTertiaryProgramme")]
        public string SecondaryTertiaryProgramme { get; set; }

        [JsonPropertyName("StudentOverrideNextYearLevel")]
        public bool? StudentOverrideNextYearLevel { get; set; }

        [JsonPropertyName("StudentOverrideNextStudentCampus")]
        public string StudentOverrideNextStudentCampus { get; set; }

        [JsonPropertyName("StudentOverrideNextBoarder")]
        public string StudentOverrideNextBoarder { get; set; }

        [JsonPropertyName("StudentYearLevelSort")]
        public int StudentYearLevelSort { get; set; }

        [JsonPropertyName("StudentYearLevelDescription")]
        public string StudentYearLevelDescription { get; set; }

        [JsonPropertyName("StudentYearLevelCoordinator")]
        public string StudentYearLevelCoordinator { get; set; }

        [JsonPropertyName("StudentYearLevelTimeTableGroup")]
        public string StudentYearLevelTimeTableGroup { get; set; }

        [JsonPropertyName("StudentYearLevelIncludeInCensusFlag")]
        public bool StudentYearLevelIncludeInCensusFlag { get; set; }

        [JsonPropertyName("StudentHouse")]
        public string StudentHouse { get; set; }

        [JsonPropertyName("StudentHouseDescription")]
        public string StudentHouseDescription { get; set; }

        [JsonPropertyName("StudentHeadOfHouse")]
        public string StudentHeadOfHouse { get; set; }

        [JsonPropertyName("StudentHouseCaptain")]
        public string StudentHouseCaptain { get; set; }

        [JsonPropertyName("StudentForm")]
        public string StudentForm { get; set; }

        [JsonPropertyName("StudentFormDescription")]
        public string StudentFormDescription { get; set; }

        [JsonPropertyName("StudentFormHomeRoom")]
        public string StudentFormHomeRoom { get; set; }

        [JsonPropertyName("StudentFormStaffName")]
        public string StudentFormStaffName { get; set; }

        [JsonPropertyName("StudentTutor")]
        public string StudentTutor { get; set; }

        [JsonPropertyName("StudentTutorDescription")]
        public string StudentTutorDescription { get; set; }

        [JsonPropertyName("StudentTutorHomeRoom")]
        public string StudentTutorHomeRoom { get; set; }

        [JsonPropertyName("StudentTutorName")]
        public string StudentTutorName { get; set; }

        [JsonPropertyName("StudentBoarder")]
        public string StudentBoarder { get; set; }

        [JsonPropertyName("StudentBoarderSynergyMeaning")]
        public string StudentBoarderSynergyMeaning { get; set; }

        [JsonPropertyName("StudentBoarderType")]
        public string StudentBoarderType { get; set; }

        [JsonPropertyName("StudentBoardingHouse")]
        public string StudentBoardingHouse { get; set; }

        [JsonPropertyName("StudentLockerBook")]
        public string StudentLockerBook { get; set; }

        [JsonPropertyName("StudentLockerOther")]
        public string StudentLockerOther { get; set; }

        [JsonPropertyName("StudentStudiesCode")]
        public string StudentStudiesCode { get; set; }

        [JsonPropertyName("StudentGovernmentStudentNumber")]
        public string StudentGovernmentStudentNumber { get; set; }

        [JsonPropertyName("StudentEarlyLearningCode")]
        public string StudentEarlyLearningCode { get; set; }

        [JsonPropertyName("VocationalEducationCode")]
        public string VocationalEducationCode { get; set; }

        [JsonPropertyName("StudentTertiaryCode")]
        public string StudentTertiaryCode { get; set; }

        [JsonPropertyName("StudentTimeTableCode")]
        public string StudentTimeTableCode { get; set; }

        [JsonPropertyName("StudentEntryDate")]
        public DateTime StudentEntryDate { get; set; }

        [JsonPropertyName("StudentEntryCampus")]
        public string StudentEntryCampus { get; set; }

        [JsonPropertyName("StudentEntryYearLevel")]
        public int StudentEntryYearLevel { get; set; }

        [JsonPropertyName("StudentLeavingDate")]
        public DateTime? StudentLeavingDate { get; set; }

        [JsonPropertyName("StudentLeavingReason")]
        public string StudentLeavingReason { get; set; }

        [JsonPropertyName("StudentLeavingDestination")]
        public string StudentLeavingDestination { get; set; }

        [JsonPropertyName("StudentReturningDate")]
        public DateTime? StudentReturningDate { get; set; }

        [JsonPropertyName("StudentEnquirySource")]
        public string StudentEnquirySource { get; set; }

        [JsonPropertyName("StudentEnquirySourceComment")]
        public string StudentEnquirySourceComment { get; set; }

        [JsonPropertyName("StudentPreviousSchool")]
        public string StudentPreviousSchool { get; set; }

        [JsonPropertyName("StudentTuitionVariationType")]
        public string StudentTuitionVariationType { get; set; }

        [JsonPropertyName("StudentDoctorName")]
        public string StudentDoctorName { get; set; }

        [JsonPropertyName("StudentDoctorPhone")]
        public string StudentDoctorPhone { get; set; }

        [JsonPropertyName("StudentDoctorPhoneAlt")]
        public string StudentDoctorPhoneAlt { get; set; }

        [JsonPropertyName("StudentDoctorAddress")]
        public string StudentDoctorAddress { get; set; }

        [JsonPropertyName("StudentDoctorSpecialisation")]
        public string StudentDoctorSpecialisation { get; set; }

        [JsonPropertyName("StudentDoctor2Name")]
        public string StudentDoctor2Name { get; set; }

        [JsonPropertyName("StudentDoctor2Phone")]
        public string StudentDoctor2Phone { get; set; }

        [JsonPropertyName("StudentDoctor2PhoneAlt")]
        public string StudentDoctor2PhoneAlt { get; set; }

        [JsonPropertyName("StudentDoctor2Address")]
        public string StudentDoctor2Address { get; set; }

        [JsonPropertyName("StudentDoctor2Specialisation")]
        public string StudentDoctor2Specialisation { get; set; }

        [JsonPropertyName("StudentDentistName")]
        public string StudentDentistName { get; set; }

        [JsonPropertyName("StudentDentistPhone")]
        public string StudentDentistPhone { get; set; }

        [JsonPropertyName("StudentDentistPhoneAlt")]
        public string StudentDentistPhoneAlt { get; set; }

        [JsonPropertyName("StudentDentistAddress")]
        public string StudentDentistAddress { get; set; }

        [JsonPropertyName("StudentEmergencyName")]
        public string StudentEmergencyName { get; set; }

        [JsonPropertyName("StudentEmergencyAddress")]
        public string StudentEmergencyAddress { get; set; }

        [JsonPropertyName("StudentEmergencyPhone")]
        public string StudentEmergencyPhone { get; set; }

        [JsonPropertyName("StudentEmergencyPhoneAlt")]
        public string StudentEmergencyPhoneAlt { get; set; }

        [JsonPropertyName("StudentEmergencyRelat")]
        public string StudentEmergencyRelat { get; set; }

        [JsonPropertyName("StudentEmergency2Name")]
        public string StudentEmergency2Name { get; set; }

        [JsonPropertyName("StudentEmergency2Address")]
        public string StudentEmergency2Address { get; set; }

        [JsonPropertyName("StudentEmergency2Phone")]
        public string StudentEmergency2Phone { get; set; }

        [JsonPropertyName("StudentEmergency2PhoneAlt")]
        public string StudentEmergency2PhoneAlt { get; set; }

        [JsonPropertyName("StudentEmergency2Relat")]
        public string StudentEmergency2Relat { get; set; }

        [JsonPropertyName("StudentEmergency3Name")]
        public string StudentEmergency3Name { get; set; }

        [JsonPropertyName("StudentEmergency3Address")]
        public string StudentEmergency3Address { get; set; }

        [JsonPropertyName("StudentEmergency3Phone")]
        public string StudentEmergency3Phone { get; set; }

        [JsonPropertyName("StudentEmergency3PhoneAlt")]
        public string StudentEmergency3PhoneAlt { get; set; }

        [JsonPropertyName("StudentEmergency3Relat")]
        public string StudentEmergency3Relat { get; set; }

        [JsonPropertyName("StudentLastLessonRcvdDate")]
        public DateTime? StudentLastLessonRcvdDate { get; set; }

        [JsonPropertyName("StudentsVisaType")]
        public string StudentsVisaType { get; set; }

        [JsonPropertyName("StudentVisaIssuedDate")]
        public DateTime? StudentVisaIssuedDate { get; set; }

        [JsonPropertyName("StudentsVisaExpiryDate")]
        public DateTime? StudentsVisaExpiryDate { get; set; }

        [JsonPropertyName("StudentVisaNumber")]
        public string StudentVisaNumber { get; set; }

        [JsonPropertyName("StudentPassportCountryCode")]
        public string StudentPassportCountryCode { get; set; }

        [JsonPropertyName("StudentPassportIssuedDate")]
        public DateTime? StudentPassportIssuedDate { get; set; }

        [JsonPropertyName("StudentPassportExpiryDate")]
        public DateTime? StudentPassportExpiryDate { get; set; }

        [JsonPropertyName("StudentsPassportNo")]
        public string StudentsPassportNo { get; set; }

        [JsonPropertyName("StudentsComment")]
        public string StudentsComment { get; set; }

        [JsonPropertyName("ExternalStudentFlag")]
        public bool ExternalStudentFlag { get; set; }

        [JsonPropertyName("EnglishSecondFlag")]
        public bool EnglishSecondFlag { get; set; }

        [JsonPropertyName("DisabilityFlag")]
        public bool DisabilityFlag { get; set; }

        [JsonPropertyName("IntegrationFlag")]
        public bool IntegrationFlag { get; set; }

        [JsonPropertyName("FullFeeFlag")]
        public bool FullFeeFlag { get; set; }

        [JsonPropertyName("EMAFlag")]
        public bool EMAFlag { get; set; }

        [JsonPropertyName("IntendsTertiaryFlag")]
        public bool IntendsTertiaryFlag { get; set; }

        [JsonPropertyName("CurrentSemesterOnlyFlag")]
        public int CurrentSemesterOnlyFlag { get; set; }

        [JsonPropertyName("StudentFamilyPosition")]
        public int StudentFamilyPosition { get; set; }

        [JsonPropertyName("StudentParishCode")]
        public string StudentParishCode { get; set; }

        [JsonPropertyName("StudentParishDescription")]
        public string StudentParishDescription { get; set; }

        [JsonPropertyName("StudentReligionCode")]
        public string StudentReligionCode { get; set; }

        [JsonPropertyName("StudentReligionDescription")]
        public string StudentReligionDescription { get; set; }

        [JsonPropertyName("StudentPreviousSchoolCode")]
        public string StudentPreviousSchoolCode { get; set; }

        [JsonPropertyName("StudentPreviousSchoolDescription")]
        public string StudentPreviousSchoolDescription { get; set; }

        [JsonPropertyName("StudentPreviousSchoolRSBNumber")]
        public string StudentPreviousSchoolRSBNumber { get; set; }

        [JsonPropertyName("StudentPreviousSchoolSuburb")]
        public string StudentPreviousSchoolSuburb { get; set; }

        [JsonPropertyName("IndigenousFlag")]
        public bool IndigenousFlag { get; set; }

        [JsonPropertyName("StudentIBFlag")]
        public bool StudentIBFlag { get; set; }

        [JsonPropertyName("StudentApplicationDate")]
        public DateTime? StudentApplicationDate { get; set; }

        [JsonPropertyName("StudentMedicalAlertFlag")]
        public bool StudentMedicalAlertFlag { get; set; }

        [JsonPropertyName("StudentSpecialNeedsFlag")]
        public bool StudentSpecialNeedsFlag { get; set; }

        [JsonPropertyName("StudentStudyAtHomeFlag")]
        public bool StudentStudyAtHomeFlag { get; set; }

        [JsonPropertyName("StudentTSIFlag")]
        public bool StudentTSIFlag { get; set; }

        [JsonPropertyName("StudentESLProficiencyLevel")]
        public string StudentESLProficiencyLevel { get; set; }

        [JsonPropertyName("StudentESLListeningLevelCode")]
        public string StudentESLListeningLevelCode { get; set; }

        [JsonPropertyName("StudentESLSpeakingLevelCode")]
        public string StudentESLSpeakingLevelCode { get; set; }

        [JsonPropertyName("StudentESLReadingLevelCode")]
        public string StudentESLReadingLevelCode { get; set; }

        [JsonPropertyName("StudentESLWritingLevelCode")]
        public string StudentESLWritingLevelCode { get; set; }

        [JsonPropertyName("LegalParentsSeparatedFlag")]
        public bool LegalParentsSeparatedFlag { get; set; }

        [JsonPropertyName("LegalParentsSeparatedReason")]
        public string LegalParentsSeparatedReason { get; set; }

        [JsonPropertyName("LegalCourtOrderType")]
        public string LegalCourtOrderType { get; set; }

        [JsonPropertyName("LegalCourtOrderDate")]
        public DateTime? LegalCourtOrderDate { get; set; }

        [JsonPropertyName("LegalCourtOrderDetails")]
        public string LegalCourtOrderDetails { get; set; }

        [JsonPropertyName("LegalPhotoWebFlag")]
        public bool LegalPhotoWebFlag { get; set; }

        [JsonPropertyName("LegalPhotoPromFlag")]
        public bool LegalPhotoPromFlag { get; set; }

        [JsonPropertyName("LegalPhotoPublicationFlag")]
        public bool LegalPhotoPublicationFlag { get; set; }

        [JsonPropertyName("LegalPrivacyPolicyAgreedFlag")]
        public bool LegalPrivacyPolicyAgreedFlag { get; set; }

        [JsonPropertyName("StudentBarcode")]
        public string StudentBarcode { get; set; }

        [JsonPropertyName("StudentMedicalAlert")]
        public string StudentMedicalAlert { get; set; }

        [JsonPropertyName("StudentSchoolFTE")]
        public double StudentSchoolFTE { get; set; }

        [JsonPropertyName("StudentInitialSchoolingYear")]
        public int? StudentInitialSchoolingYear { get; set; }

        [JsonPropertyName("StudentInitialSchoolingDate")]
        public DateTime? StudentInitialSchoolingDate { get; set; }

        [JsonPropertyName("StudentNonResidentFlag")]
        public bool StudentNonResidentFlag { get; set; }

        [JsonPropertyName("DirectoryIncludeFlag")]
        public bool DirectoryIncludeFlag { get; set; }

        [JsonPropertyName("DirectoryProvideFlag")]
        public bool DirectoryProvideFlag { get; set; }

        [JsonPropertyName("AddressID")]
        public int AddressID { get; set; }

        [JsonPropertyName("StudentBirthCertificateOnFileFlag")]
        public bool StudentBirthCertificateOnFileFlag { get; set; }

        [JsonPropertyName("StudentCountryOfBirthCode")]
        public string StudentCountryOfBirthCode { get; set; }

        [JsonPropertyName("StudentCountryOfBirthCodeRaw")]
        public string StudentCountryOfBirthCodeRaw { get; set; }

        [JsonPropertyName("StudentCountryOfBirthDescription")]
        public string StudentCountryOfBirthDescription { get; set; }

        [JsonPropertyName("StudentHomeLanguageCode")]
        public string StudentHomeLanguageCode { get; set; }

        [JsonPropertyName("StudentHomeLanguageDescription")]
        public string StudentHomeLanguageDescription { get; set; }

        [JsonPropertyName("ActualSemester")]
        public int ActualSemester { get; set; }

        [JsonPropertyName("StudentAltCode")]
        public string StudentAltCode { get; set; }

        [JsonPropertyName("ImportantCommentsFlag")]
        public bool ImportantCommentsFlag { get; set; }

        [JsonPropertyName("StudentLeavingDestinationDesc")]
        public string StudentLeavingDestinationDesc { get; set; }

        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("DebtorID")]
        public int DebtorID { get; set; }

        [JsonPropertyName("MCEETYAFormReceivedDate")]
        public DateTime? MCEETYAFormReceivedDate { get; set; }

        [JsonPropertyName("StudentNationalityCode")]
        public string StudentNationalityCode { get; set; }

        [JsonPropertyName("StudentNationalityDescription")]
        public string StudentNationalityDescription { get; set; }

        [JsonPropertyName("StudentNationality2Code")]
        public string StudentNationality2Code { get; set; }

        [JsonPropertyName("StudentNationality2Description")]
        public string StudentNationality2Description { get; set; }

        [JsonPropertyName("StudentIntendedTertiaryCourseCode")]
        public string StudentIntendedTertiaryCourseCode { get; set; }

        [JsonPropertyName("StudentSubSchool")]
        public string StudentSubSchool { get; set; }

        [JsonPropertyName("AustudyFlag")]
        public bool AustudyFlag { get; set; }

        [JsonPropertyName("StudentEmergencyRelatDesc")]
        public string StudentEmergencyRelatDesc { get; set; }

        [JsonPropertyName("StudentEmergency2RelatDesc")]
        public string StudentEmergency2RelatDesc { get; set; }

        [JsonPropertyName("StudentEmergency3RelatDesc")]
        public string StudentEmergency3RelatDesc { get; set; }

        [JsonPropertyName("StudentNetworkLogin")]
        public string StudentNetworkLogin { get; set; }

        [JsonPropertyName("AllowAutoTuitionFlag")]
        public bool AllowAutoTuitionFlag { get; set; }

        [JsonPropertyName("SpecialBillingType")]
        public string SpecialBillingType { get; set; }

        [JsonPropertyName("TuitionNoSibFlag")]
        public bool TuitionNoSibFlag { get; set; }

        [JsonPropertyName("LearningPathway")]
        public string LearningPathway { get; set; }

        [JsonPropertyName("GenderSynergyMeaning")]
        public string GenderSynergyMeaning { get; set; }
    }

    public class StudentPersonalInfo
    {
        [JsonPropertyName("Given1")]
        public string Given1 { get; set; }

        [JsonPropertyName("Given2")]
        public string Given2 { get; set; }

        [JsonPropertyName("Initials")]
        public string Initials { get; set; }

        [JsonPropertyName("Suffix")]
        public string Suffix { get; set; }

        [JsonPropertyName("Surname")]
        public string Surname { get; set; }

        [JsonPropertyName("NameInternal")]
        public string NameInternal { get; set; }

        [JsonPropertyName("NameExternal")]
        public string NameExternal { get; set; }

        [JsonPropertyName("LegalFullName")]
        public string LegalFullName { get; set; }

        [JsonPropertyName("PreferredFormal")]
        public string PreferredFormal { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Preferred")]
        public string Preferred { get; set; }

        [JsonPropertyName("StudentGender")]
        public string StudentGender { get; set; }
    }
}