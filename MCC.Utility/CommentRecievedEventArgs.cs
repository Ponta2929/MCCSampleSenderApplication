using System;

namespace MCC.Utility
{
    public delegate void CommentRecievedEventHandler(object sender, CommentRecievedEventArgs e);

    public class CommentRecievedEventArgs : EventArgs
    {
        public CommentRecievedEventArgs(CommentData data)
          => CommentData = data;

        public CommentData CommentData { get; private set; }
    }
}
