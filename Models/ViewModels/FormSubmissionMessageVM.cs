using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTemplateProject.Models.ViewModels
{
    public class FormSubmissionMessageVM
    {
        public RegisteredUser RegisteredUser { get; set; }
        public bool Status { get; set; }
        public string FormMessage { get; set; }
    }
}
