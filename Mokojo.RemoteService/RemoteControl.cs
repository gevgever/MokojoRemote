using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Mokojo.RemoteService
{
    [ServiceContract]
    public class RemoteControlL:IRemoteControl
    {
        [OperationContract]
        public void Do(RemoteCommand i_remoteCommand)
        {
            ///Your Mother!! :)
            throw new NotImplementedException();
        }
    }
}
