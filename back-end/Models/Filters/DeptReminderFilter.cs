﻿using System;

namespace InternetBanking.Models.Filters
{
    public class DeptReminderFilter
    {
        public Guid Id { get; set; }
        public string RequestorAccountNumber { get; set; }
        public string RecipientAccountNumber { get; set; }
        public bool? IsCanceled { get; set; }
        public bool? IsPaid { get; set; }
        public string Code { get; set; }
    }
}
