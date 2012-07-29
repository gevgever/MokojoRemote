using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Mokojo.RemoteServer
{
    [ServiceContract]
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class RemoteControl:IRemoteControl
    {
        public List<RemoteCommand> m_commands { get; set; }
        public RemoteControl()
        {
            m_commands = new List<RemoteCommand>();
        }
        
        [OperationContract]
        public void Do(RemoteCommand i_remoteCommand)
        {
            m_commands.Add(i_remoteCommand);
            ///Your Mother!! :)
            
        }

        [OperationContract]
        public int CountPendingCommands()
        {
            return m_commands.Count;
        }
    }
}
