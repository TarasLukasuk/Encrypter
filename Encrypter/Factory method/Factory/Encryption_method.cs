using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.Factory_method.Factory
{
    internal abstract class Encryption_method
    {
        public abstract Encryption_text Get_encrypted_message();
    }
}
