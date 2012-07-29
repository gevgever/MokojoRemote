using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Mokojo.RemoteServer
{
    [ServiceContract]
    public class RemoteControl:IRemoteControl
    {
        [OperationContract]
        public void Do(RemoteCommand i_remoteCommand)
        {
            ///Your Mother!! :)
            throw new NotImplementedException();
        }
    }
}
