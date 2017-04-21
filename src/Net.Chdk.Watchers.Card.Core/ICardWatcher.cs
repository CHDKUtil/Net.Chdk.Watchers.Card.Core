using System;

namespace Net.Chdk.Watchers.Card
{
    public interface ICardWatcher : IDisposable
    {
        void Initialize();
        void Start();
        void Stop();
        event EventHandler<string> CardAdded;
        event EventHandler<string> CardRemoved;
    }
}
