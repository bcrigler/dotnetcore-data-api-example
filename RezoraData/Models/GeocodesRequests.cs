using System;
using System.Collections.Generic;

namespace RezoraData.Models
{
    public partial class GeocodesRequests
    {
        public int RequestId { get; set; }
        public DateTimeOffset RequestTimestamp { get; set; }
        public string JobId { get; set; }
        public string JobStatus { get; set; }
        public DateTime JobCreated { get; set; }
        public DateTime JobCompleted { get; set; }
        public string JobDescription { get; set; }
        public int JobEntitiesFailed { get; set; }
        public int JobEntitiesProcessed { get; set; }
        public int JobEntitiesTotal { get; set; }
        public string JobErrorMessage { get; set; }
    }
}
