using System.Xml;

namespace NexusForever.StsServer.Network.Message.Model
{
    public class ServerSecondaryAuth : IWritable
    {
        public string Token { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Reply");

            writer.WriteEndElement();
        }
    }
}
