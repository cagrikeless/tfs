using System.Configuration;

namespace TFS_Service
{
    public static class config
    {
        public static string TFS_ServiceUsername = ConfigurationManager.AppSettings["tfsUserName"];
        public static string TFS_ServicePassword = ConfigurationManager.AppSettings["tfsPassword"];
        public static string TFS_ServiceDomain = ConfigurationManager.AppSettings["tfsDomain"];
        public static string TFS_ServiceURL = ConfigurationManager.AppSettings["tfsUrl"];
        public static string TFS_ServiceProjectName = ConfigurationManager.AppSettings["tfsProjectName"];
        public static string TFS_ServiceToken = ConfigurationManager.AppSettings["tfsToken"];
        public static string TFS_ServiceWorkItemName = ConfigurationManager.AppSettings["tfsWorkItemName"];

    }
}
