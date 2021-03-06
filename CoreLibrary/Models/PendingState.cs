﻿namespace CoreLibrary.Models
{
    public class PendingState : State
    {

        public PendingState(SubmissionModel submission)
        {
            this.submission = submission;
        }

        public override void Complete()
        {
            submission.State = new CompleteState(submission);
        }
    }
}