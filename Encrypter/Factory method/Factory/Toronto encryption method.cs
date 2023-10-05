using Encrypter.Factory_method.Decipher;
using Encrypter.Factory_method.Encryption;
using Encrypter.Factory_method.Product;

namespace Encrypter.Factory_method.Factory
{
    internal class Toronto_encryption_method : Encryption_method
    {
        public Toronto_encryption_method(string Text_encrypted) => Text = Text_encrypted;

        private readonly string Text;

        public override Encryption_text Get_encrypted_message()
        {
            Toronto_encryption toronto_Encryption = new(Text);
            return toronto_Encryption;
        }
    }
}
