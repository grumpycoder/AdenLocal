using System;

namespace CoreLibrary.Models
{
    public class SubmissionModel
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public string FileSpecification { get; set; }
        public string AssignedUser { get; set; }

        public State State { get; set; }

        public SubmissionModel()
        {
            State = new NotStartedState(this);
        }

        public SubmissionModel(string specification)
        {
            FileSpecification = specification;
            State = new NotStartedState(this);
        }

        public string CurrentState()
        {
            return State.GetType().Name;
        }
    }

}