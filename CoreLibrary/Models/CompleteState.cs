namespace CoreLibrary.Models
{
    public class CompleteState : State
    {
        public CompleteState(SubmissionModel submission)
        {
            this.submission = submission;
        }

        public override void Complete()
        {
            submission.State = new CompleteState(submission);
        }
    }
}