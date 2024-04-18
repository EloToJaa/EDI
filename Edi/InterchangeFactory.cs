using Edi.Contracts.Interchanges;
using Edi.Contracts.InterchangeSegments;
using Edi.Contracts.Interfaces;
using System.Reflection;

namespace Edi;

public class InterchangeFactory
{
    private static readonly string _assemblyName = "Edi.Contracts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null";

    public static Interchange<IMessage>? Create(string messageClassName)
    {
        var asm = Assembly.Load(_assemblyName);
        var messageType = asm.GetType($"Edi.Contracts.Messages.{messageClassName}");
        if (messageType is null) return null;

        if (!typeof(IMessage).IsAssignableFrom(messageType))
            return null;

        IMessage? message = (IMessage?)Activator.CreateInstance(messageType);

        if (message is null) return null;

        return new Interchange<IMessage>
        {
            InterchangeHeader = new UNB(),
            Messages = [message],
            InterchangeTrailer = new UNZ()
        };
    }

    public static Type? CreateType(string messageClassName)
    {
        var asm = Assembly.Load(_assemblyName);
        var messageType = asm.GetType($"Edi.Contracts.Messages.{messageClassName}");
        if (messageType is null) return null;

        if (!typeof(IMessage).IsAssignableFrom(messageType))
            return null;

        var interchangeGenericType = typeof(Interchange<>);
        var interchangeType = interchangeGenericType.MakeGenericType(messageType);

        return interchangeType;
    }
}
