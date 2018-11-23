using System.Collections.Generic;

namespace CoreLibrary
{
    public interface IDataConnection
    {
        SubmissionModel CreateSubmission(SubmissionModel model);

        List<SubmissionModel> GetSubmissions();
    }
}
