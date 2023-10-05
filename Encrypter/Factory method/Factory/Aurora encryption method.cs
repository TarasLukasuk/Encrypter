using Encrypter.Factory_method.Product;

namespace Encrypter.Factory_method.Factory
{
    class Aurora_encryption_method : Encryption_method
    {
        public Aurora_encryption_method(string Text_encrypted)=>Text = Text_encrypted;

        private readonly string Text;

        public override Encryption_text Get_encrypted_message()
        {
            Aurora_encryption aurora_Encryption = new(Text);
            return aurora_Encryption;
        }
    }
}
