using Accreditation_Watch.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Accreditation_Watch.Shared.Objects
{
    public class ProgramSummery
    {
        public readonly List<AWProgram>? _programs;
        private readonly int _goodCount;
        private readonly int _umberCount;
        private readonly int _badCount;
        public ProgramSummery(List<AWProgram> programs) 
        {
            _programs = programs;
            foreach (var program in _programs)
            {
                if (CheckDate(program.ValidTo, 720, 360)) _goodCount++;
                else if (CheckDate(program.ValidTo, 360, 180)) _umberCount++;
                else if (CheckDate(program.ValidTo, 180, -180)) _badCount++;
            }
        }
        public ProgramSummery() { }
        public int Count { get { return _programs.Count; } }
        public int GoodCount { get { return _goodCount; } }
        public int UmberCount { get { return _umberCount; } }
        public int BadCount { get { return _badCount; } }
        public bool CheckDate(DateTime Date1, int upperLimit, int lowerLimit)
        {
            TimeSpan span = Date1 - DateTime.Now;
            if (span.Days > lowerLimit && span.Days < upperLimit) return true;
            else return false;
        }

        public List<string> GenerateSummaries()
    {
        // A list to store the summaries
        List<string> summaries = new List<string>();

        // A threshold to determine if a program is about to expire
        int daysThreshold = 30;

        // Loop through each program in the list
        foreach (var program in _programs)
        {
            // A string to store the summary for the current program
            string summary = "";

            // Check if the program is accredited
            if (!program.IsAccredited)
            {
                // If not, add a warning message to the summary
                summary += $"The program {program.Name} is not accredited.\n";
            }

            // Check if the program is valid
            if (program.ValidTo < DateTime.Today)
            {
                // If not, add an error message to the summary
                summary += $"The program {program.Name} has expired on {program.ValidTo.ToShortDateString()}.\n";
            }
            else if (program.ValidTo - DateTime.Today <= TimeSpan.FromDays(daysThreshold))
            {
                // If it is about to expire, add a warning message to the summary
                summary += $"The program {program.Name} is about to expire on {program.ValidTo.ToShortDateString()}.\n";
            }

            // Check if the summary is not empty
            if (summary != "")
            {
                // If it is not, add it to the list of summaries
                summaries.Add(summary);
            }
        }

        // Return the list of summaries
        return summaries;
    }
    
    public  List<ProgramStatus> GenerateStatuses()
    {
        // A list to store the statuses
        List<ProgramStatus> statuses = new List<ProgramStatus>();

        // A threshold to determine if a program is about to expire
        int daysThreshold = 30;

        // Group the programs by their school
        var groups = _programs.GroupBy(p => p.Department.SchoolId.ToString());
    
        // Loop through each group
        foreach (var group in groups)
        {
            // A status object to store the status for the current group
                ProgramStatus status = new ProgramStatus();
                status.Name = group.Key;
                status.Status = new int[2];
                //status.Status[0] = _programs.Where(p => p.Department.SchoolId.ToString() == group.Key && p.ValidTo >= DateTime.Today && p.IsAccredited && p.ValidTo - DateTime.Today <= TimeSpan.FromDays(daysThreshold)).Count();
                status.Status[0] = _programs.Where(p => p.Department.SchoolId.ToString() == group.Key && p.IsAccredited).Count();
                status.Status[1] = _programs.Where(p => p.Department.SchoolId.ToString() == group.Key && !p.IsAccredited).Count();
                //status.Status[1] = _programs.Where(p => p.Department.SchoolId.ToString() == group.Key && p.ValidTo >= DateTime.Today && p.IsAccredited && p.ValidTo - DateTime.Today > TimeSpan.FromDays(daysThreshold)).Count();
                statuses.Add(status);
         
            
        }

        // Return the list of statuses
        return statuses;
    }
    
    }
    public class ProgramStatus
{
    public int[] Status { get; set; }
    public string Name { get; set; }
}

}
