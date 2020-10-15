using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFS_Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length >= 14)
            {
                // define tfs_servicehelper
                var tfs_servicehelper = new TFS_ServiceHelper();

                var workItemStore = tfs_servicehelper.GetWorkItemStore();


                if (args[0] == "-reqNo" && args[1] != "" &&
                    args[2] == "-title" && args[3] != "" &&
                    args[4] == "-area" && args[5] != "" &&
                    args[6] == "-description" && args[7] != "" &&
                    args[8] == "-startingdate" && args[9] != "" &&
                    args[10] == "-targetdate" && args[11] != "" &&
                    args[12] != "-priority" && args[13] != ""
                    )
                {
                    var newWorkItemName = tfs_servicehelper.CreationWorkItem(args[1], args[3], args[5], args[7], args[9], args[11], args[13]);
                }



            }
        }
    }
}
