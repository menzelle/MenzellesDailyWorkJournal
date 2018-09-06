using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingWebApp.Models
{
    public class JournalEntryModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public dynamic PlannedTasks { get; set; }
        public string InterruptTasks { get; set; }
        public string Notes { get; set; }
        public string Questions { get; set; }
    }
}
