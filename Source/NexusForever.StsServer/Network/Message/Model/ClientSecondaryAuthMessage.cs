using System.Xml;
using System;
using NLog;
using System.IO;

namespace NexusForever.StsServer.Network.Message.Model
{
    [Message("/Auth/VerifySecondaryAuth")]
    public class ClientSecondaryAuthMessage : IReadable
    {
        public uint AuthType { get; private set; }
        public uint Value { get; private set; }

        public void Read(XmlDocument document)
        {
            XmlNode rootNode = document["Request"];
            AuthType = rootNode["AuthType"].GetValue<uint>();
            Value = rootNode["Value"].GetValue<uint>();
        }
    }
}
