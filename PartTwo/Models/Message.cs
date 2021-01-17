using PartTwo.Interfaces;

namespace PartTwo.Models
{
	public abstract class Message : IMessage
	{
        public virtual string Type => GetType().FullName;
    }

    public abstract class Message<TData> : Message, IMessage<TData>
    {

        object IMessageWithData.Data => Data;

        public TData Data { get; set; }
    }
}
