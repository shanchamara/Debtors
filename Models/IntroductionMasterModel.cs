﻿namespace AuditSystem.Models
{
    public class IntroductionMasterModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Narration { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    }
}