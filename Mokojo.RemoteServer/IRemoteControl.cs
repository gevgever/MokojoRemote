using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mokojo.RemoteServer
{
    interface IRemoteControl
    {
        void Do(RemoteCommand i_remoteCommand);
        int CountPendingCommands();
    }
}
