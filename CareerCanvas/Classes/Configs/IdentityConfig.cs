using ProtoBuf;

namespace CareerCanvas.Classes.Configs
{
    [ProtoContract]
    public class IdentityConfig
    {
        [ProtoMember(1)]
        public bool UseEncryption { get; set; } = false;

        [ProtoMember(2)]
        public string? EncryptionKey { get; set; }
    }
}