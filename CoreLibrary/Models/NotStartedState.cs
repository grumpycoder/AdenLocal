namespace CoreLibrary.Models
{
    public class NotStartedState : SubmissionState
    {
        public NotStartedState(SubmissionModel submission)
        {
            this.submission = submission;
        }

        public override void Complete()
        {
            submission.SubmissionState = new PendingState();
        }

    }
}