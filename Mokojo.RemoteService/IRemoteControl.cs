using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mokojo.RemoteService
{
    interface IRemoteControl
    {
        void Do(RemoteCommand i_remoteCommand);
    }
}
