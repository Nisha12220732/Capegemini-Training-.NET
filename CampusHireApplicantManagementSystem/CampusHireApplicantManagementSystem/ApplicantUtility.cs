using System;
using System.Collections.Generic;
using System.Text;

namespace CampusHireApplicantManagementSystem
{
     class ApplicantUtility
    {
        public List<Applicant> ApplicantList = new List<Applicant>();

        public bool AddNewApplicant(string id, string name, CurrLocation location, JobLocation joblocation, Competency skill, int year)
        {
            Applicant applicant = new Applicant(id,name,location,joblocation,skill,year);
            ApplicantList.Add(applicant);
            Console.WriteLine("Applicant Added!");
            return true;

        }

        public void DisplayApplicantDetails()
        {
            foreach(var applicant in ApplicantList)
            {
                Console.WriteLine($"Applicant ID: {applicant.ApplicantId} | Applicant Name: {applicant.ApplicantName} | Applicant Current Location: {applicant.CurrentLocation} | Applicant  Job Location: {applicant.JobLocation} | Applicant Skill: {applicant.CoreCompetency} | Applicant Passing Year {applicant.PassingYear}");
            }
        }

        public void SearchById(string id)
        {
            var appl = from i in ApplicantList
                       where i.ApplicantId == id
                       select i;
            foreach (var applicant in appl)
            {
                Console.WriteLine($"Applicant ID: {applicant.ApplicantId} | Applicant Name: {applicant.ApplicantName} | Applicant Current Location: {applicant.CurrentLocation} | Applicant  Job Location: {applicant.JobLocation} | Applicant Skill: {applicant.CoreCompetency} | Applicant Passing Year {applicant.PassingYear}");
            }

        }
        public void UpdateApplicantCurrentLocation(string id,CurrLocation location)
        {
            var appl = from i in ApplicantList
                       where i.ApplicantId == id
                       select i;
            foreach (var applicant in appl)
            {
                Console.WriteLine("Current Details: ");
                Console.WriteLine($"Applicant ID: {applicant.ApplicantId} | Applicant Name: {applicant.ApplicantName} | Applicant Current Location: {applicant.CurrentLocation} | Applicant  Job Location: {applicant.JobLocation} | Applicant Skill: {applicant.CoreCompetency} | Applicant Passing Year {applicant.PassingYear}");
                applicant.CurrentLocation = location;
                Console.WriteLine("Updated Details: ");
                Console.WriteLine($"Applicant ID: {applicant.ApplicantId} | Applicant Name: {applicant.ApplicantName} | Applicant Current Location: {applicant.CurrentLocation} | Applicant  Job Location: {applicant.JobLocation} | Applicant Skill: {applicant.CoreCompetency} | Applicant Passing Year {applicant.PassingYear}");
            }

        }

        public void UpdateApplicantCompetency(string id, Competency skill)
        {
            var appl = from i in ApplicantList
                       where i.ApplicantId == id
                       select i;
            foreach (var applicant in appl)
            {
                Console.WriteLine("Current Details: ");
                Console.WriteLine($"Applicant ID: {applicant.ApplicantId} | Applicant Name: {applicant.ApplicantName} | Applicant Current Location: {applicant.CurrentLocation} | Applicant  Job Location: {applicant.JobLocation} | Applicant Skill: {applicant.CoreCompetency} | Applicant Passing Year {applicant.PassingYear}");
                applicant.CoreCompetency = skill;
                Console.WriteLine("Updated Details: ");
                Console.WriteLine($"Applicant ID: {applicant.ApplicantId} | Applicant Name: {applicant.ApplicantName} | Applicant Current Location: {applicant.CurrentLocation} | Applicant  Job Location: {applicant.JobLocation} | Applicant Skill: {applicant.CoreCompetency} | Applicant Passing Year {applicant.PassingYear}");
            }
        }

        public void DeleteApplicantRecord(string id)
        {
            var appl = from i in ApplicantList
                       where i.ApplicantId == id
                       select i;
            foreach (var applicant in appl)
            {
                ApplicantList.Remove(applicant);
            }
        }
    }
}
