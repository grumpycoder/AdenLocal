using System;

namespace CoreLibrary.Models
{
    public class SubmissionModel
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public string FileSpecification { get; private set; }
        public string AssignedUser { get; set; }
        public SubmissionState SubmissionState { get; set; }

        public SubmissionModel(string specification)
        {
            FileSpecification = specification;
            SubmissionState = new NotStartedState(this);
        }

        public string CurrentState()
        {
            return SubmissionState.GetType().Name;
        }
    }

}