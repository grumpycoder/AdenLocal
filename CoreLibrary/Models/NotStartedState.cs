namespace CoreLibrary.Models
{
    public class NotStartedState : State
    {
        public NotStartedState(SubmissionModel submission)
        {
            this.submission = submission;
        }

        public override void Complete()
        {
            submission.State = new PendingState(submission);
        }

    }
}