using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MCC.Utility
{
    [DataContract]
    public class CommentData : PostHeader
    {
        // 2021-02-05T21:03:47.3762629+09:00
        public CommentData() => this.PostType = PostType.Comment;

        [DataMember(Name = "PostTime")]
        public DateTime PostTime { get; set; }

        [DataMember(Name = "LiveName")]
        public string LiveName { get; set; }

        [DataMember(Name = "UserName")]
        public string UserName { get; set; }

        [DataMember(Name = "UserID")]
        public string UserID { get; set; }

        [DataMember(Name = "Comment")]
        public string Comment { get; set; }
    }
}
