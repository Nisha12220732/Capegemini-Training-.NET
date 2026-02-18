using System;
using System.Collections.Generic;
using System.Text;

namespace CampusHireApplicantManagementSystem
{
    public enum CurrLocation { Mumbai , Pune , Chennai }
    public enum JobLocation { Mumbai, Pune, Chennai, Delhi , Kolkata, Bangalore }

    public enum Competency { DotNet , JAVA , ORACLE , Testing }

    public class Applicant
    {
        public string ApplicantId { get; set; }
        public string ApplicantName { get; set; }
        public CurrLocation CurrentLocation { get; set; }   
        public JobLocation JobLocation { get; set; }
        public Competency CoreCompetency { get; set; }
        public int PassingYear { get; set; }

        public Applicant(string applicantId, string applicantName, CurrLocation currentLocation, JobLocation jobLocation, Competency coreCompetency, int passingYear)
        {
            ApplicantId = applicantId;
            ApplicantName = applicantName;
            CurrentLocation = currentLocation;
            JobLocation = jobLocation;
            CoreCompetency = coreCompetency;
            PassingYear = passingYear;
        }
    }
}
