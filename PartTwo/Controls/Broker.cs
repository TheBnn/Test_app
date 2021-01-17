using PartTwo.Exeptions;
using PartTwo.Interfaces;
using PartTwo.Models;
using System;
using System.Collections.Generic;

namespace PartTwo.Controls
{
	class Broker : IMessageBroker
	{

		private static Broker _instance;
		private readonly Dictionary<Type, List<Delegate>> _subscribers;
		private Broker()
		{
			_subscribers = new Dictionary<Type, List<Delegate>>();
		}
		public static Broker Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Broker();
				return _instance;
			}
		}

		public void Publish(IMessage message)
		{
			throw new NotImplementedException();
		}

		public void Subscribe(ISubscriber subscription)
		{
			throw new NotImplementedException();
		}

		public void Unsubscribe(ISubscriber subscription)
		{

		}



		private static string ResolveMessageType<T>()
		{
			return typeof(T).FullName;
		}
	}
}
