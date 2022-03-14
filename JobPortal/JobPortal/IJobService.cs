using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal
{
    [ServiceContract]

    interface IJobService
    {
        [OperationContract]
        List<Job> GetAllJobs();

        [OperationContract]
        Job GetJob(int id);

        [OperationContract]
        Job AddJob(Job job);

        [OperationContract]
        Job RemoveJob(int id);

        [OperationContract]
        Job UpdateJob(Job job);
    }
}
