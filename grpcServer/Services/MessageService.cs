using Grpc.Core;
using grpcMessageServer;

namespace grpcServer.Services;

public class MessageService : Message.MessageBase
{ 
    private readonly ILogger<MessageService> _logger;
    public MessageService(ILogger<MessageService> logger)
    {
        _logger = logger;
    }

    public override async Task<MessageResponse> SendMessage(MessageRequest request, ServerCallContext context)
    {
        Console.WriteLine(request.Message);

        return  new MessageResponse
        {
            Message = "Message received: " + request.Message
        };
    }

  
}
