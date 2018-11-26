using CoreLibrary.Models;
using System;

namespace CoreLibrary
{
    public static class WorkItemFactory
    {
        public static IWorkItem Create(string assignedUser)
        {
            return new WorkItemModel()
            {
                AssignDate = DateTime.Now,
                AssignedUser = assignedUser
            };
        }

    }
}
