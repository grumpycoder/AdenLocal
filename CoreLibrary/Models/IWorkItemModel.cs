using System;

namespace CoreLibrary.Models
{
    public class WorkItemModel : IWorkItem
    {
        public int Id { get; set; }
        public DateTime AssignDate { get; set; }
        public DateTime? CompletionDate { get; set; }

        public string AssignedUser { get; set; }

        public bool IsComplete { get; private set; }

        public void Complete()
        {
            IsComplete = true;
        }
    }
}
