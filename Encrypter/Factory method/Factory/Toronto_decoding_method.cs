using Encrypter.Factory_method.Decipher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.Factory_method.Factory
{
    internal class Toronto_decoding_method : Decoding_method
    {
        public Toronto_decoding_method(string Text_decipher) => Text = Text_decipher;

        private readonly string Text;

        public override Decoding_text Get_decipher_message()
        {
            Aurora_decoding aurora_Decipher = new(Text);
            return aurora_Decipher;
        }
    }
}
