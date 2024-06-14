using Grpc.Net.Client;
using grpcMessageClient;
using grpcServer;

class Program
{
     static async Task Main(string[] args)
    {
        Console.WriteLine("Start Client"); 

        var channel = GrpcChannel.ForAddress("http://localhost:5001");

       // var greeterClient = new Greeter.GreeterClient(channel);

       // HelloReply result =  await greeterClient.SayHelloAsync(new HelloRequest { Name = "World" });

       //Console.WriteLine(result.Message);

        var messageClient = new Message.MessageClient(channel);

        MessageResponse response = await messageClient.SendMessageAsync(new MessageRequest 
        { Name="Client", Message = "Hello from Client" });

        System.Console.WriteLine(response.Message);

    }
}