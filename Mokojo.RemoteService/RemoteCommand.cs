using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Mokojo.RemoteService
{
    [DataContract]
    public class RemoteCommand
    {
        [DataMember]
        public string CommandString { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; } 
    }
}
