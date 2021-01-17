using PartTwo.Models;
using System;

namespace PartTwo.Interfaces
{
	public interface IMessageBroker
	{
		void Publish(IMessage message);
		void Subscribe(ISubscriber subscription);
		void Unsubscribe(ISubscriber subscription);

        /*
        void Unsubscribe<T>();
        void Unsubscribe(string name);
    
        void Subscribe<T>(Func<Task> func, string name = "") where T : IMessage;
        void Subscribe<T>(Func<T, Task> func, string name = "") where T : IMessageWithData;
        */
    }
}
