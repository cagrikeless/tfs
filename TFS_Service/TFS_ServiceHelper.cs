using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;
using Microsoft.VisualStudio.Services.Client;
using System;
using System.Net;

namespace TFS_Service
{
    internal class TFS_ServiceHelper
    {

        public WorkItemStore GetWorkItemStore()
        {
            try
            {
                var networkCred = new NetworkCredential(string.Empty,config.TFS_ServiceToken);
                var vssCred = new VssClientCredentials
                {
                    Windows = { Credentials = networkCred }
                };
                var collectionUri = new Uri(config.TFS_ServiceURL);
                var tpc = new TfsTeamProjectCollection(collectionUri, vssCred);
                var workItemStore = tpc.GetService<WorkItemStore>();
                return workItemStore;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public WorkItem CreationWorkItem(string reqNo,string workItemName,string areaPath, string description, DateTime startingDate , DateTime targetDate, string priority)
        {
            // Collection workItemStore
            var workItemStore = GetWorkItemStore();
            if(workItemStore == null) { return null; }
            try
            {
                // get Project Name and item names
                var teamProject = workItemStore.Projects[config.TFS_ServiceProjectName];
                var workItemType = teamProject.WorkItemTypes[config.TFS_ServiceWorkItemName];
                // variables for workItemTypes ex:(description,starting date , areapath , title etc.)
                var workItem = new WorkItem(workItemType)
                {
                    Title = workItemName,
                    AreaPath = areaPath,
                    Description = description
                };

                //  [< !-- if can create a fields in project-- > ]
                // workItem.Fields["Finans"].Value = finans;
                workItem.Save();
                return workItem;
            }
            catch (Exception)
            {

                return null;
            }
        }

        internal object CreationWorkItem(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        {
            throw new NotImplementedException();
        }
    }
}
