using System;

namespace CoreLibrary.Models
{
    public interface IWorkItem
    {
        DateTime AssignDate { get; set; }
        string AssignedUser { get; set; }
        DateTime? CompletionDate { get; set; }
        int Id { get; set; }
        bool IsComplete { get; }

        void Complete();
    }
}