﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Accreditation_Watch.Shared.Entities
{
    public class AWProgram : BaseEntity
    {
        public int AccrediteStatusId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime ValidFrom { get; set; } = DateTime.Now;
        public DateTime ValidTo { get; set; } = DateTime.Now;
        public bool IsAccredited { get => AccrediteStatusId==12; }

        public Department? Department { get; set; }
        public AccrediteStatus? Status { get; set; }
        public List<Note>? Notes { get; set; } = new();
        public override List<string> RelatedEntities()
        {
            return new() { "Status", "Department", "Notes" };
        }
        public int GetDuration() => ValidTo.Year - ValidFrom.Year; 
        public string GetStatus() { 
            
                string status = "";
                if (IsAccredited) status += "Is Accredited";
                else status += "Is Accredited";
                if (IsExpired()) status += " and Expired";
                else status += " and not Expired";
                return status;
            }
        public int MonthsRemaining() => IsExpired()? ((ValidTo.Year - DateTime.Now.Year) * 12) + ValidTo.Month - DateTime.Now.Month : 0;
        public int MonthsUsed() => IsExpired() ? ((DateTime.Now.Year - ValidFrom.Year) * 12) + DateTime.Now.Month - ValidFrom.Month : GetDuration();
        public bool IsExpired() => ValidTo < DateTime.Now; 
        
        public override string ToString()
        {
            return $"{Name} - {Department?.Name} - {Status?.Name} - {ValidFrom.ToShortDateString()} - {ValidTo.ToShortDateString()} - {ValidTo.ToShortDateString()}";
        }
        //public override void InitializeFromDto(CreateProgramDto dto)
        //{
        //    base.InitializeFromDto(dto);
        //    Status = dto;
        //}

    }
    public class CreateProgramDto : AWProgram
    {
        public int Id { get; } = 0;
        public readonly AccrediteStatus? Status = null;
        public readonly Department? Department = null;
        public readonly Accredite? Accredite = null;
    }
}
