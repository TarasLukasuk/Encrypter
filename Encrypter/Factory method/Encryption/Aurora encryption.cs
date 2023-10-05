namespace Encrypter.Factory_method.Product
{
    class Aurora_encryption : Encryption_text
    {
        public Aurora_encryption(string Text_encrypted)
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
                    result += "rdg ";
                }

                if (symbols[index] == 'B')
                {
                    result += "ela ";
                }

                if (symbols[index] == 'C')
                {
                    result += "tub ";
                }

                if (symbols[index] == 'D')
                {
                    result += "dqf ";
                }

                if (symbols[index] == 'E')
                {
                    result += "ehz ";
                }

                if (symbols[index] == 'F')
                {
                    result += "whu ";
                }

                if (symbols[index] == 'G')
                {
                    result += "czn ";
                }

                if (symbols[index] == 'H')
                {
                    result += "yxi ";
                }

                if (symbols[index] == 'I')
                {
                    result += "riw ";
                }

                if (symbols[index] == 'J')
                {
                    result += "gwe ";
                }

                if (symbols[index] == 'K')
                {
                    result += "jrc ";
                }

                if (symbols[index] == 'L')
                {
                    result += "nbm ";
                }

                if (symbols[index] == 'M')
                {
                    result += "qch ";
                }

                if (symbols[index] == 'N')
                {
                    result += "qwa ";
                }

                if (symbols[index] == 'O')
                {
                    result += "zma ";
                }

                if (symbols[index] == 'P')
                {
                    result += "kym ";
                }

                if (symbols[index] == 'Q')
                {
                    result += "zsn ";
                }

                if (symbols[index] == 'R')
                {
                    result += "oyw ";
                }

                if (symbols[index] == 'T')
                {
                    result += "cvt ";
                }

                if (symbols[index] == 'U')
                {
                    result += "ikq ";
                }

                if (symbols[index] == 'V')
                {
                    result += "mgo ";
                }

                if (symbols[index] == 'W')
                {
                    result += "hck ";
                }

                if (symbols[index] == 'X')
                {
                    result += "cnm ";
                }

                if (symbols[index] == 'Y')
                {
                    result += "bzr ";
                }

                if (symbols[index] == 'Z')
                {
                    result += "mtq ";
                }

                if(symbols[index] == 'S')
                {
                    result += "etk ";
                }

                if (symbols[index] == 'a')
                {
                    result += "ipz ";
                }

                if (symbols[index] == 'b')
                {
                    result += "wub ";
                }

                if (symbols[index] == 'c')
                {
                    result += "kcd ";
                }

                if (symbols[index] == 'd')
                {
                    result += "zjx ";
                }

                if (symbols[index] == 'e')
                {
                    result += "qgr ";
                }

                if (symbols[index] == 'f')
                {
                    result += "tfh ";
                }

                if (symbols[index] == 'g')
                {
                    result += "cwi ";
                }

                if (symbols[index] == 'h')
                {
                    result += "oob ";
                }

                if (symbols[index] == 'i')
                {
                    result += "gsz ";
                }

                if (symbols[index] == 'j')
                {
                    result += "xbk ";
                }

                if (symbols[index] == 'k')
                {
                    result += "ryf ";
                }

                if (symbols[index] == 'l')
                {
                    result += "wux ";
                }

                if (symbols[index] == 'm')
                {
                    result += "tva ";
                }

                if (symbols[index] == 'n')
                {
                    result += "vfq ";
                }

                if (symbols[index] == 'o')
                {
                    result += "nuk ";
                }

                if (symbols[index] == 'p')
                {
                    result += "abg ";
                }

                if (symbols[index] == 'q')
                {
                    result += "acw ";
                }

                if (symbols[index] == 'r')
                {
                    result += "xff ";
                }

                if (symbols[index] == 't')
                {
                    result += "otk ";
                }

                if (symbols[index] == 'u')
                {
                    result += "dah ";
                }

                if (symbols[index] == 'v')
                {
                    result += "gnq ";
                }

                if (symbols[index] == 'w')
                {
                    result += "oti ";
                }

                if (symbols[index] == 'x')
                {
                    result += "cvi ";
                }

                if (symbols[index] == 'y')
                {
                    result += "pqf ";
                }

                if (symbols[index] == 'z')
                {
                    result += "sbb ";
                }

                if (symbols[index] =='s')
                {
                    result += "flk ";
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
                    result += "bjq ";
                }

                if (symbols[index] == 'Б')
                {
                    result += "xaj ";
                }

                if (symbols[index] == 'В')
                {
                    result += "qwd ";
                }

                if (symbols[index] == 'Г')
                {
                    result += "hlg ";
                }

                if (symbols[index] == 'Д')
                {
                    result += "bii ";
                }

                if (symbols[index] == 'Е')
                {
                    result += "iie ";
                }

                if (symbols[index] == 'Є')
                {
                    result += "iuf ";
                }

                if (symbols[index] == 'Ж')
                {
                    result += "lqr ";
                }

                if (symbols[index] == 'З')
                {
                    result += "rmt ";
                }

                if (symbols[index] == 'И')
                {
                    result += "ban ";
                }

                if (symbols[index] == 'І')
                {
                    result += "rnp ";
                }

                if (symbols[index] == 'Ї')
                {
                    result += "byf ";
                }

                if (symbols[index] == 'Й')
                {
                    result += "hev ";
                }

                if (symbols[index] == 'К')
                {
                    result += "xwu ";
                }
                if (symbols[index] == 'Л')
                {
                    result += "mpk ";
                }

                if (symbols[index] == 'М')
                {
                    result += "ojb ";
                }

                if (symbols[index] == 'Н')
                {
                    result += "lsa ";
                }

                if (symbols[index] == 'О')
                {
                    result += "qvd ";
                }

                if (symbols[index] == 'П')
                {
                    result += "ltg ";
                }

                if (symbols[index] == 'Р')
                {
                    result += "iyy ";
                }

                if (symbols[index] == 'С')
                {
                    result += "bjn ";
                }

                if (symbols[index] == 'Т')
                {
                    result += "rks ";
                }

                if (symbols[index] == 'У')
                {
                    result += "elu ";
                }

                if (symbols[index] == 'Ф')
                {
                    result += "loz ";
                }

                if (symbols[index] == 'Х')
                {
                    result += "wnq ";
                }

                if (symbols[index] == 'Ц')
                {
                    result += "ugb ";
                }

                if (symbols[index] == 'Ч')
                {
                    result += "ppu ";
                }

                if (symbols[index] == 'Ш')
                {
                    result += "jrj ";
                }

                if (symbols[index] == 'Щ')
                {
                    result += "ahh ";
                }

                if (symbols[index] == 'Я')
                {
                    result += "fem ";
                }

                if (symbols[index] == 'Ь')
                {
                    result += "uzd ";
                }

                if (symbols[index] == 'Ю')
                {
                    result += "tiq ";
                }

                if (symbols[index] == 'а')
                {
                    result += "yic ";
                }

                if (symbols[index] == 'б')
                {
                    result += "ysw ";
                }

                if (symbols[index] == 'в')
                {
                    result += "jtf ";
                }

                if (symbols[index] == 'г')
                {
                    result += "ezb ";
                }

                if (symbols[index] == 'д')
                {
                    result += "wja ";
                }

                if (symbols[index] == 'е')
                {
                    result += "cju ";
                }

                if (symbols[index] == 'є')
                {
                    result += "rdj ";
                }

                if (symbols[index] == 'ж')
                {
                    result += "fqr ";
                }

                if (symbols[index] == 'з')
                {
                    result += "qom ";
                }

                if (symbols[index] == 'и')
                {
                    result += "qxe ";
                }

                if (symbols[index] == 'і')
                {
                    result += "sxj ";
                }

                if (symbols[index] == 'ї')
                {
                    result += "gqc ";
                }

                if (symbols[index] == 'й')
                {
                    result += "mbj ";
                }

                if (symbols[index] == 'к')
                {
                    result += "rxu ";
                }
                if (symbols[index] == 'л')
                {
                    result += "wnc ";
                }

                if (symbols[index] == 'м')
                {
                    result += "zal ";
                }

                if (symbols[index] == 'н')
                {
                    result += "arr ";
                }

                if (symbols[index] == 'о')
                {
                    result += "fpb ";
                }

                if (symbols[index] == 'п')
                {
                    result += "gqi ";
                }

                if (symbols[index] == 'р')
                {
                    result += "dhv ";
                }

                if (symbols[index] == 'с')
                {
                    result += "rhj ";
                }

                if (symbols[index] == 'т')
                {
                    result += "kke ";
                }

                if (symbols[index] == 'у')
                {
                    result += "bik ";
                }

                if (symbols[index] == 'ф')
                {
                    result += "dnu ";
                }

                if (symbols[index] == 'х')
                {
                    result += "ozc ";
                }

                if (symbols[index] == 'ц')
                {
                    result += "ozc ";
                }

                if (symbols[index] == 'ч')
                {
                    result += "qmj ";
                }

                if (symbols[index] == 'ш')
                {
                    result += "kuk ";
                }

                if (symbols[index] == 'щ')
                {
                    result += "bjc ";
                }

                if (symbols[index] == 'я')
                {
                    result += "tas ";
                }

                if (symbols[index] == 'ь')
                {
                    result += "pzs ";
                }

                if (symbols[index] == 'ю')
                {
                    result += "utc ";
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
                    result += "sou ";
                }

                if (symbols[index] == ']')
                {
                    result += "wlx ";
                }

                if (symbols[index] == '(')
                {
                    result += "xvb ";
                }

                if (symbols[index] == ')')
                {
                    result += "dac ";
                }

                if (symbols[index] == '{')
                {
                    result += "ukh ";
                }

                if (symbols[index] == '}')
                {
                    result += "eac ";
                }

                if (symbols[index] == ',')
                {
                    result += "eac ";
                }

                if (symbols[index] == ':')
                {
                    result += "imr ";
                }

                if (symbols[index] == '‒')
                {
                    result += "sxy ";
                }

                if (symbols[index] == '…')
                {
                    result += "xvq ";
                }

                if (symbols[index] == '!')
                {
                    result += "ngc ";
                }

                if (symbols[index] == '.')
                {
                    result += "upc ";
                }

                if (symbols[index] == '‘')
                {
                    result += "svp ";
                }

                if (symbols[index] == '’')
                {
                    result += "dpm ";
                }
                if (symbols[index] == '«')
                {
                    result += "dak ";
                }

                if (symbols[index] == '»')
                {
                    result += "hsy ";
                }

                if (symbols[index] == '?')
                {
                    result += "jgt ";
                }

                if (symbols[index] == ';')
                {
                    result += "mft ";
                }

                if (symbols[index] == '/')
                {
                    result += "oah ";
                }

                if (symbols[index] == ' ')
                {
                    result += "omq ";
                }

                if (symbols[index] == '&')
                {
                    result += "cgs ";
                }

                if (symbols[index] == '@')
                {
                    result += "gjj ";
                }

                if (symbols[index] == '^')
                {
                    result += "bru ";
                }

                if (symbols[index] == '¯')
                {
                    result += "jeg ";
                }

                if (symbols[index] == '•')
                {
                    result += "wur ";
                }

                if (symbols[index] == '*')
                {
                    result += "ndg ";
                }

                if (symbols[index] == '†')
                {
                    result += "ltd ";
                }

                if (symbols[index] == '‡')
                {
                    result += "ptz ";
                }

                if (symbols[index] == '°')
                {
                    result += "lcq ";
                }

                if (symbols[index] == '¡')
                {
                    result += "lyf ";
                }

                if (symbols[index] == '¿')
                {
                    result += "bvs ";
                }

                if (symbols[index] == '#')
                {
                    result += "gbm ";
                }

                if (symbols[index] == '№')
                {
                    result += "ygt ";
                }

                if (symbols[index] == '%')
                {
                    result += "teo ";
                }

                if (symbols[index] == '¶')
                {
                    result += "eyt ";
                }

                if (symbols[index] == '′')
                {
                    result += "rwk ";
                }

                if (symbols[index] == '″')
                {
                    result += "kox ";
                }

                if (symbols[index] == '§')
                {
                    result += "nog ";
                }

                if (symbols[index] == '~')
                {
                    result += "lli ";
                }

                if (symbols[index] == '_')
                {
                    result += "ytj ";
                }

                if (symbols[index] == '|')
                {
                    result += "mtp ";
                }

                if (symbols[index] == '-')
                {
                    result += "tej ";
                }

                if (symbols[index] == '¦')
                {
                    result += "zns ";
                }

                if (symbols[index] == '+')
                {
                    result += "ssr ";
                }

                if (symbols[index] == '=')
                {
                    result += "xkv ";
                }

                if (symbols[index] == '<')
                {
                    result += "ykz ";
                }

                if (symbols[index] == '>')
                {
                    result += "cdi ";
                }

                if (symbols[index] == '?')
                {
                    result += "jfj ";
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
                    result += "fyp ";
                }

                if (symbols[index] == '2')
                {
                    result += "xpl ";
                }

                if (symbols[index] == '3')
                {
                    result += "omm ";
                }

                if (symbols[index] == '4')
                {
                    result += "ula ";
                }

                if (symbols[index] == '5')
                {
                    result += "san ";
                }

                if (symbols[index] == '6')
                {
                    result += "toh ";
                }

                if (symbols[index] == '7')
                {
                    result += "sro ";
                }

                if (symbols[index] == '8')
                {
                    result += "cyg ";
                }

                if (symbols[index] == '9')
                {
                    result += "lhu ";
                }

                if (symbols[index] == '0')
                {
                    result = "dmu ";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }
    }
}
