using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MCC.Utility
{
    [DataContract]
    public class PostHeader
    {
        [DataMember(Name = "PostType")]
        public PostType PostType { get; set; }
    }

    public enum PostType
    { 
        Comment = 0,
        UserSetting = 1,
    }
}
