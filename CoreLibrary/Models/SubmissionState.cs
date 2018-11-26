namespace CoreLibrary.Models
{
    public abstract class SubmissionState
    {

        protected SubmissionModel submission;

        public SubmissionModel SubmissionModel { get => submission; set => submission = value; }

        public abstract void Complete();

    }

}
