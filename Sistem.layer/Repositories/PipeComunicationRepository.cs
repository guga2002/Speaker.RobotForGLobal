using System;
using System.IO.Pipes;
using System.IO;
using Speaker.leison.Sistem.layer.Interfaces;

namespace Speaker.leison.Sistem.layer.Repositories
{
    public class PipeComunicationRepository: IPipeComunicationRepository
    {
        private readonly string sender;
        private readonly string reciever;

        public PipeComunicationRepository(string senderGui ,string RecieverGui)
        {
            this.sender = senderGui;
            this.reciever = RecieverGui;
        }
        public PipeComunicationRepository(string Sender)
        {
            this.sender = Sender;
        }
        public string Receive()
        {
            try
            {
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("GUI4835745738464t834734GE"))
                {
                    Console.WriteLine("Waiting for connection...");
                    pipeServer.WaitForConnection();
                    Console.WriteLine("Client connected.");

                    using (StreamReader reader = new StreamReader(pipeServer))
                    {
                        while (pipeServer.IsConnected)
                        {
                            string message = reader.ReadLine();
                            if (message == null)
                                break;

                            // Console.WriteLine("Received message: " + message);
                            return message;
                        }
                    }
                }
                return " ";
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex.Message);
                return " ";
            }
        }

        public void Send(string message)
        {
            try
            {
                using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "GUI4835745738464t8347334d", PipeDirection.Out))
                {
                    pipeClient.Connect();
                    using (StreamWriter writer = new StreamWriter(pipeClient))
                    {
                        writer.WriteLine(message);
                        writer.Flush();
                        Console.WriteLine("Message sent successfully.");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
