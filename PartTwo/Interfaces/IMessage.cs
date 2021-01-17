

namespace PartTwo.Interfaces
{
	public interface IMessage
	{
		string Type { get; }
	}
	public interface IMessageWithData : IMessage
	{
		object Data { get; }
	}

	public interface IMessage<TData> : IMessageWithData
	{
		new TData Data { get; set; }
	}
}