using System.Xml;

namespace NexusForever.StsServer.Network.Message.Model
{
    [Message("/Auth/LoginFinish")]
    public class ClientLoginFinishMessage : IReadable
    {
        public uint? RegisterVerifiedIp { get; private set; }

        public void Read(XmlDocument document)
        {
            // This same packet is used for multiple things
            // Regular login or OTP = <Request /> 
            // OTP w/ Save IP Address = <Request><RegisterVerifiedIp>1</RegisterVerifiedIp></Request> 
            XmlNode rootNode = document["Request"];
            if (rootNode["RegisterVerifiedIp"] != null) {
                RegisterVerifiedIp = rootNode["RegisterVerifiedIp"].GetValue<uint>();
            } 
        }
    }
}
