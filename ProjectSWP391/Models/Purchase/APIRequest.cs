﻿namespace ProjectSWP391.Models.Purchase
{
    public class APIRequest
    {
        public long accountNo { get; set; }
        public string accountName { get; set; }
        public int acqId { get; set; }
        public int amount { get; set; }
        public string addInfo { get; set; }
        public string format { get; set; }
        public string template { get; set; }
    }
}
