using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter.Factory_method.Encryption
{
    internal class Toronto_encryption : Encryption_text
    {
        public Toronto_encryption(string Text_encrypted)
        {
            Text = Text_encrypted;
        }

        private readonly string Text;

        private int Symbols_texts_Length;

        public override string Сreate_encrypted_message()
        {
            string encryption_result = string.Empty;

            char[] Symbols_texts = Text.ToCharArray();

            Symbols_texts_Length = Symbols_texts.Length;

            for (int Index = 0; Index <= Symbols_texts_Length; Index++)
            {
                encryption_result += Encrypt_English_characters(Symbols_texts, Index);
                encryption_result += Encrypt_Ukrainian_symbols(Symbols_texts, Index);
                encryption_result += Encrypt_punctuation_marks(Symbols_texts, Index);
                encryption_result += Encrypt_numbers(Symbols_texts, Index);
            }

            return encryption_result;
        }

        private string Encrypt_English_characters(char[] symbols, int index)
        {
            string result = string.Empty;

            try
            {
                if (symbols[index] == 'A')
                {
                    result += "V2Qoy!";
                }

                if (symbols[index] == 'B')
                {
                    result += "rt8Dz!";
                }

                if (symbols[index] == 'C')
                {
                    result += "qjkwA!";
                }

                if (symbols[index] == 'D')
                {
                    result += "PvrbW!";
                }

                if (symbols[index] == 'E')
                {
                    result += "mY0OE!";
                }

                if (symbols[index] == 'F')
                {
                    result += "7BpXG!";
                }

                if (symbols[index] == 'G')
                {
                    result += "DhHBs!";
                }

                if (symbols[index] == 'H')
                {
                    result += "Dl3TJ!";
                }

                if (symbols[index] == 'I')
                {
                    result += "sSzx0!";
                }

                if (symbols[index] == 'J')
                {
                    result += "21F2E!";
                }

                if (symbols[index] == 'K')
                {
                    result += "D9BST!";
                }

                if (symbols[index] == 'L')
                {
                    result += "YcJVw!";
                }

                if (symbols[index] == 'M')
                {
                    result += "vvCrX!";
                }

                if (symbols[index] == 'N')
                {
                    result += "90MNa!";
                }

                if (symbols[index] == 'O')
                {
                    result += "NzWVx!";
                }

                if (symbols[index] == 'P')
                {
                    result += "3RIRO!";
                }

                if (symbols[index] == 'Q')
                {
                    result += "nNXWh!";
                }

                if (symbols[index] == 'R')
                {
                    result += "JUVV5!";
                }

                if (symbols[index] == 'T')
                {
                    result += "TIwuB!";
                }

                if (symbols[index] == 'U')
                {
                    result += "0oYFT!";
                }

                if (symbols[index] == 'V')
                {
                    result += "E557K!";
                }

                if (symbols[index] == 'W')
                {
                    result += "oZeIs!";
                }

                if (symbols[index] == 'X')
                {
                    result += "ItOMu!";
                }

                if (symbols[index] == 'Y')
                {
                    result += "1bAVH!";
                }

                if (symbols[index] == 'Z')
                {
                    result += "IRDXX!";
                }

                if (symbols[index] == 'S')
                {
                    result += "FKpMq!";
                }

                if (symbols[index] == 'a')
                {
                    result += "sNv2r!";
                }

                if (symbols[index] == 'b')
                {
                    result += "hadcB!";
                }

                if (symbols[index] == 'c')
                {
                    result += "kcd ";
                }

                if (symbols[index] == 'd')
                {
                    result += "IfMra!";
                }

                if (symbols[index] == 'e')
                {
                    result += "A7vla!";
                }

                if (symbols[index] == 'f')
                {
                    result += "XJI6I";
                }

                if (symbols[index] == 'g')
                {
                    result += "uZQGe!";
                }

                if (symbols[index] == 'h')
                {
                    result += "FglFw!";
                }

                if (symbols[index] == 'i')
                {
                    result += "JWcrs!";
                }

                if (symbols[index] == 'j')
                {
                    result += "xux9J!";
                }

                if (symbols[index] == 'k')
                {
                    result += "pBeOM!";
                }

                if (symbols[index] == 'l')
                {
                    result += "jpz1D!";
                }

                if (symbols[index] == 'm')
                {
                    result += "U2Oq5!";
                }

                if (symbols[index] == 'n')
                {
                    result += "vIvmj!";
                }

                if (symbols[index] == 'o')
                {
                    result += "uID3O!";
                }

                if (symbols[index] == 'p')
                {
                    result += "dCd7u!";
                }

                if (symbols[index] == 'q')
                {
                    result += "zNruh!";
                }

                if (symbols[index] == 'r')
                {
                    result += "tllAY!";
                }

                if (symbols[index] == 't')
                {
                    result += "AVxTM!";
                }

                if (symbols[index] == 'u')
                {
                    result += "hwC01!";
                }

                if (symbols[index] == 'v')
                {
                    result += "4oidE!";
                }

                if (symbols[index] == 'w')
                {
                    result += "rHjOD!";
                }

                if (symbols[index] == 'x')
                {
                    result += "CRhMe!";
                }

                if (symbols[index] == 'y')
                {
                    result += "GjsJd!";
                }

                if (symbols[index] == 'z')
                {
                    result += "3lGuK!";
                }

                if (symbols[index] == 's')
                {
                    result += "tnNKj!";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }

        private string Encrypt_Ukrainian_symbols(char[] symbols, int index)
        {
            string result = string.Empty;

            try
            {
                if (symbols[index] == 'А')
                {
                    result += "D87g5!";
                }

                if (symbols[index] == 'Б')
                {
                    result += "YGQoq!";
                }

                if (symbols[index] == 'В')
                {
                    result += "aWoNA!";
                }

                if (symbols[index] == 'Г')
                {
                    result += "scVMO!";
                }

                if (symbols[index] == 'Д')
                {
                    result += "WCQ9y!";
                }

                if (symbols[index] == 'Е')
                {
                    result += "qjMXR!";
                }

                if (symbols[index] == 'Є')
                {
                    result += "epaS3!";
                }

                if (symbols[index] == 'Ж')
                {
                    result += "LnnlD!";
                }

                if (symbols[index] == 'З')
                {
                    result += "iFlx4!";
                }

                if (symbols[index] == 'И')
                {
                    result += "dLSyR!";
                }

                if (symbols[index] == 'І')
                {
                    result += "LeKpW!";
                }

                if (symbols[index] == 'Ї')
                {
                    result += "ODGXl!";
                }

                if (symbols[index] == 'Й')
                {
                    result += "u63gB!";
                }

                if (symbols[index] == 'К')
                {
                    result += "C8lRI!";
                }
                if (symbols[index] == 'Л')
                {
                    result += "J10Su!";
                }

                if (symbols[index] == 'М')
                {
                    result += "zLkpE!";
                }

                if (symbols[index] == 'Н')
                {
                    result += "0sWnW!";
                }

                if (symbols[index] == 'О')
                {
                    result += "teNL8!";
                }

                if (symbols[index] == 'П')
                {
                    result += "RQylH!";
                }

                if (symbols[index] == 'Р')
                {
                    result += "IfZYT!";
                }

                if (symbols[index] == 'С')
                {
                    result += "onUiI!";
                }

                if (symbols[index] == 'Т')
                {
                    result += "JkMy5!";
                }

                if (symbols[index] == 'У')
                {
                    result += "9xRHp!";
                }

                if (symbols[index] == 'Ф')
                {
                    result += "72uwE!";
                }

                if (symbols[index] == 'Х')
                {
                    result += "i7Wy2!";
                }

                if (symbols[index] == 'Ц')
                {
                    result += "UZUN4!";
                }

                if (symbols[index] == 'Ч')
                {
                    result += "1AbDi!";
                }

                if (symbols[index] == 'Ш')
                {
                    result += "e2xv6!";
                }

                if (symbols[index] == 'Щ')
                {
                    result += "ouS1H!";
                }

                if (symbols[index] == 'Я')
                {
                    result += "ZExMt!";
                }

                if (symbols[index] == 'Ь')
                {
                    result += "05YIy!";
                }

                if (symbols[index] == 'Ю')
                {
                    result += "C9BZV!";
                }

                if (symbols[index] == 'а')
                {
                    result += "9UoSd!";
                }

                if (symbols[index] == 'б')
                {
                    result += "Juvr7!";
                }

                if (symbols[index] == 'в')
                {
                    result += "yMf3T!";
                }

                if (symbols[index] == 'г')
                {
                    result += "SZm8q!";
                }

                if (symbols[index] == 'д')
                {
                    result += "YiNH8!";
                }

                if (symbols[index] == 'е')
                {
                    result += "EAtra!";
                }

                if (symbols[index] == 'є')
                {
                    result += "hKf5q!";
                }

                if (symbols[index] == 'ж')
                {
                    result += "jdZa1!";
                }

                if (symbols[index] == 'з')
                {
                    result += "vKpfJ!";
                }

                if (symbols[index] == 'и')
                {
                    result += "qxe ";
                }

                if (symbols[index] == 'і')
                {
                    result += "WY0ac!";
                }

                if (symbols[index] == 'ї')
                {
                    result += "WY0ac!";
                }

                if (symbols[index] == 'й')
                {
                    result += "2FF8I!";
                }

                if (symbols[index] == 'к')
                {
                    result += "O72NM!";
                }
                if (symbols[index] == 'л')
                {
                    result += "uBJEr!";
                }

                if (symbols[index] == 'м')
                {
                    result += "Uketc!";
                }

                if (symbols[index] == 'н')
                {
                    result += "uFZ9h!";
                }

                if (symbols[index] == 'о')
                {
                    result += "o79kb!";
                }

                if (symbols[index] == 'п')
                {
                    result += "Ssg6B!";
                }

                if (symbols[index] == 'р')
                {
                    result += "r2HXy!";
                }

                if (symbols[index] == 'с')
                {
                    result += "9yrIO!";
                }

                if (symbols[index] == 'т')
                {
                    result += "l1tsk!";
                }

                if (symbols[index] == 'у')
                {
                    result += "GY1c0!";
                }

                if (symbols[index] == 'ф')
                {
                    result += "apVID!";
                }

                if (symbols[index] == 'х')
                {
                    result += "Wus4x!";
                }

                if (symbols[index] == 'ц')
                {
                    result += "oKvr1!";
                }

                if (symbols[index] == 'ч')
                {
                    result += "8QxKy!";
                }

                if (symbols[index] == 'ш')
                {
                    result += "P6GsM!";
                }

                if (symbols[index] == 'щ')
                {
                    result += "1ElEb!";
                }

                if (symbols[index] == 'я')
                {
                    result += "LkJVX!";
                }

                if (symbols[index] == 'ь')
                {
                    result += "g8PeX!";
                }

                if (symbols[index] == 'ю')
                {
                    result += "W5gZn!";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }

        private string Encrypt_punctuation_marks(char[] symbols, int index)
        {
            string result = string.Empty;

            try
            {
                if (symbols[index] == '[')
                {
                    result += "jDBXm!";
                }

                if (symbols[index] == ']')
                {
                    result += "FaySe!";
                }

                if (symbols[index] == '(')
                {
                    result += "oyqpF!";
                }

                if (symbols[index] == ')')
                {
                    result += "Tl0UH!";
                }

                if (symbols[index] == '{')
                {
                    result += "UjhDX!";
                }

                if (symbols[index] == '}')
                {
                    result += "Avpjb!";
                }

                if (symbols[index] == ',')
                {
                    result += "LvqPv!";
                }

                if (symbols[index] == ':')
                {
                    result += "uFqOJ!";
                }

                if (symbols[index] == '‒')
                {
                    result += "3F083!";
                }

                if (symbols[index] == '…')
                {
                    result += "zONHY!";
                }

                if (symbols[index] == '!')
                {
                    result += "jQGm5!";
                }

                if (symbols[index] == '.')
                {
                    result += "WIR3U!";
                }

                if (symbols[index] == '‘')
                {
                    result += "57h3X!";
                }

                if (symbols[index] == '’')
                {
                    result += "jIglF!";
                }
                if (symbols[index] == '«')
                {
                    result += "w6Yps!";
                }

                if (symbols[index] == '»')
                {
                    result += "hRgNI!";
                }

                if (symbols[index] == '?')
                {
                    result += "luznh!";
                }

                if (symbols[index] == ';')
                {
                    result += "kR0l2!";
                }

                if (symbols[index] == '/')
                {
                    result += "DnfQj!";
                }

                if (symbols[index] == ' ')
                {
                    result += "bU4Y1!";
                }

                if (symbols[index] == '&')
                {
                    result += "DumIB!";
                }

                if (symbols[index] == '@')
                {
                    result += "WCCiv!";
                }

                if (symbols[index] == '^')
                {
                    result += "MbShA!";
                }

                if (symbols[index] == '¯')
                {
                    result += "ScThj!";
                }

                if (symbols[index] == '•')
                {
                    result += "wur ";
                }

                if (symbols[index] == '*')
                {
                    result += "8lVpT!";
                }

                if (symbols[index] == '†')
                {
                    result += "VTvty!";
                }

                if (symbols[index] == '‡')
                {
                    result += "ziz4R!";
                }

                if (symbols[index] == '°')
                {
                    result += "ZZMxH!";
                }

                if (symbols[index] == '¡')
                {
                    result += "IAsns!";
                }

                if (symbols[index] == '¿')
                {
                    result += "oFfBF!";
                }

                if (symbols[index] == '#')
                {
                    result += "ZOsu8!";
                }

                if (symbols[index] == '№')
                {
                    result += "iZbou!";
                }

                if (symbols[index] == '%')
                {
                    result += "wIpUH!";
                }

                if (symbols[index] == '¶')
                {
                    result += "yWoRG!";
                }

                if (symbols[index] == '′')
                {
                    result += "oTz9I!";
                }

                if (symbols[index] == '″')
                {
                    result += "KnfPs!";
                }

                if (symbols[index] == '§')
                {
                    result += "qx5xe!";
                }

                if (symbols[index] == '~')
                {
                    result += "Svvxj!";
                }

                if (symbols[index] == '_')
                {
                    result += "rjgQM!";
                }

                if (symbols[index] == '|')
                {
                    result += "bP7Ya!";
                }

                if (symbols[index] == '-')
                {
                    result += "hqWdz!";
                }

                if (symbols[index] == '¦')
                {
                    result += "BAPaY!";
                }

                if (symbols[index] == '+')
                {
                    result += "Ya8nU!";
                }

                if (symbols[index] == '=')
                {
                    result += "8KpXF!";
                }

                if (symbols[index] == '<')
                {
                    result += "rFhkP!";
                }

                if (symbols[index] == '>')
                {
                    result += "SlgkJ!";
                }

                if (symbols[index] == '?')
                {
                    result += "coV2e!";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }

        private string Encrypt_numbers(char[] symbols, int index)
        {
            string result = string.Empty;

            try
            {
                if (symbols[index] == '1')
                {
                    result += "FFxrM!";
                }

                if (symbols[index] == '2')
                {
                    result += "MhX2x!";
                }

                if (symbols[index] == '3')
                {
                    result += "MhX2x!";
                }

                if (symbols[index] == '4')
                {
                    result += "UFeww!";
                }

                if (symbols[index] == '5')
                {
                    result += "knznc!";
                }

                if (symbols[index] == '6')
                {
                    result += "knznc!";
                }

                if (symbols[index] == '7')
                {
                    result += "9H2Xi!";
                }

                if (symbols[index] == '8')
                {
                    result += "zvBsX!";
                }

                if (symbols[index] == '9')
                {
                    result += "zvBsX!";
                }

                if (symbols[index] == '0')
                {
                    result = "ykwxU!";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }
    }
}

