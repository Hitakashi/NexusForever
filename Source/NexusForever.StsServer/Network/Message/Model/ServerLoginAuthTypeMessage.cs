using System.Xml;

namespace NexusForever.StsServer.Network.Message.Model
{
    public class ServerLoginAuthTypeMessage : IWritable
    {
        public uint AuthType { get; set; }

        public void Write(XmlWriter writer)
        {
            writer.WriteStartElement("Reply");

            writer.WriteStartElement("AuthType");
            writer.WriteValue(AuthType);
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}
