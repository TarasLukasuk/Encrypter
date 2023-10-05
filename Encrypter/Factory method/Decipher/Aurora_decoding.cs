namespace Encrypter.Factory_method.Decipher
{
    class Aurora_decoding : Decoding_text
    {
        public Aurora_decoding(string Aurora_decipher)
        {
            Text = Aurora_decipher;
        }

        private readonly string Text;

        private int Texts_Length;

        public override string Decrypt_encrypted_message()
        {
            string decrypt_result = string.Empty;

            Texts_Length = Text.Length;

            string[] Array_ciphertext = Text.Split(' ');

            for (int Index = 0; Index <= Texts_Length; Index++)
            {
                decrypt_result += Deciphering_English_symbols(Array_ciphertext, Index);
                decrypt_result += Deciphering_Ukrainian_symbols(Array_ciphertext, Index);
                decrypt_result += Decipher_punctuation_marks(Array_ciphertext, Index);
                decrypt_result += Decipher_numbers(Array_ciphertext, Index);

            }

            return decrypt_result;
        }

        private string Deciphering_English_symbols(string[] array_ciphertext, int index)
        {
            string result = string.Empty;

            try
            {
                if (array_ciphertext[index] == "rdg")
                {
                    result += "A";
                }

                if (array_ciphertext[index] == "ela")
                {
                    result += "B";
                }

                if (array_ciphertext[index] == "tub")
                {
                    result += "C";
                }

                if (array_ciphertext[index] == "dqf")
                {
                    result += "D";
                }

                if (array_ciphertext[index] == "ehz")
                {
                    result += "E";
                }

                if (array_ciphertext[index] == "whu")
                {
                    result += "F";
                }

                if (array_ciphertext[index] == "czn")
                {
                    result += "G";
                }

                if (array_ciphertext[index] == "yxi")
                {
                    result += "H";
                }

                if (array_ciphertext[index] == "riw")
                {
                    result += "I";
                }

                if (array_ciphertext[index] == "gwe")
                {
                    result += "J";
                }

                if (array_ciphertext[index] == "jrc")
                {
                    result += "K";
                }

                if (array_ciphertext[index] == "nbm")
                {
                    result += "L";
                }

                if (array_ciphertext[index] == "qch")
                {
                    result += "M";
                }

                if (array_ciphertext[index] == "qwa")
                {
                    result += "N";
                }

                if (array_ciphertext[index] == "zma")
                {
                    result += "O";
                }

                if (array_ciphertext[index] == "kym")
                {
                    result += "P";
                }

                if (array_ciphertext[index] == "zsn")
                {
                    result += "Q";
                }

                if (array_ciphertext[index] == "oyw")
                {
                    result += "R";
                }

                if (array_ciphertext[index] == "cvt")
                {
                    result += "T";
                }

                if (array_ciphertext[index] == "ikq")
                {
                    result += "U";
                }

                if (array_ciphertext[index] == "mgo")
                {
                    result += "V";
                }

                if (array_ciphertext[index] == "hck")
                {
                    result += "W";
                }

                if (array_ciphertext[index] == "cnm")
                {
                    result += "X";
                }

                if (array_ciphertext[index] == "bzr")
                {
                    result += "Y";
                }

                if (array_ciphertext[index] == "mtq")
                {
                    result += "Z";
                }

                if (array_ciphertext[index] == "etk")
                {
                    result += "S";
                }

                if (array_ciphertext[index] == "ipz")
                {
                    result += "a";
                }

                if (array_ciphertext[index] == "wub")
                {
                    result += "b";
                }

                if (array_ciphertext[index] == "kcd")
                {
                    result += "c";
                }

                if (array_ciphertext[index] == "zjx")
                {
                    result += "d";
                }

                if (array_ciphertext[index] == "qgr")
                {
                    result += "e";
                }

                if (array_ciphertext[index] == "tfh")
                {
                    result += "f";
                }

                if (array_ciphertext[index] == "cwi")
                {
                    result += "g";
                }

                if (array_ciphertext[index] == "oob")
                {
                    result += "h";
                }

                if (array_ciphertext[index] == "gsz")
                {
                    result += "i";
                }

                if (array_ciphertext[index] == "xbk")
                {
                    result += "j";
                }

                if (array_ciphertext[index] == "ryf")
                {
                    result += "k";
                }

                if (array_ciphertext[index] == "wux")
                {
                    result += "l";
                }

                if (array_ciphertext[index] == "tva")
                {
                    result += "m";
                }

                if (array_ciphertext[index] == "vfq")
                {
                    result += "n";
                }

                if (array_ciphertext[index] == "nuk")
                {
                    result += "o";
                }

                if (array_ciphertext[index] == "abg")
                {
                    result += "p";
                }

                if (array_ciphertext[index] == "acw")
                {
                    result += "q";
                }

                if (array_ciphertext[index] == "xff")
                {
                    result += "r";
                }

                if (array_ciphertext[index] == "otk")
                {
                    result += "t";
                }

                if (array_ciphertext[index] == "dah")
                {
                    result += "u";
                }

                if (array_ciphertext[index] == "gnq")
                {
                    result += "v";
                }

                if (array_ciphertext[index] == "oti")
                {
                    result += "w";
                }

                if (array_ciphertext[index] == "cvi")
                {
                    result += "x";
                }

                if (array_ciphertext[index] == "pqf")
                {
                    result += "y";
                }

                if (array_ciphertext[index] == "sbb")
                {
                    result += "z";
                }

                if (array_ciphertext[index] == "flk")
                {
                    result += "s";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }

        private string Deciphering_Ukrainian_symbols(string[] array_ciphertexts, int index)
        {
            string result = string.Empty;

            try
            {
                if (array_ciphertexts[index] == "bjq")
                {
                    result += "А";
                }

                if (array_ciphertexts[index] == "xaj")
                {
                    result += "Б";
                }

                if (array_ciphertexts[index] == "qwd")
                {
                    result += "В";
                }

                if (array_ciphertexts[index] == "hlg")
                {
                    result += "Г";
                }

                if (array_ciphertexts[index] == "bii")
                {
                    result += "Д";
                }

                if (array_ciphertexts[index] == "iie")
                {
                    result += "Е";
                }

                if (array_ciphertexts[index] == "iuf")
                {
                    result += "Є";
                }

                if (array_ciphertexts[index] == "lqr")
                {
                    result += "Ж";
                }

                if (array_ciphertexts[index] == "rmt")
                {
                    result += "З";
                }

                if (array_ciphertexts[index] == "ban")
                {
                    result += "И";
                }

                if (array_ciphertexts[index] == "rnp")
                {
                    result += "І";
                }

                if (array_ciphertexts[index] == "byf")
                {
                    result += "Ї";
                }

                if (array_ciphertexts[index] == "hev")
                {
                    result += "Й";
                }

                if (array_ciphertexts[index] == "xwu")
                {
                    result += "К";
                }
                if (array_ciphertexts[index] == "mpk")
                {
                    result += "Л";
                }

                if (array_ciphertexts[index] == "ojb")
                {
                    result += "М";
                }

                if (array_ciphertexts[index] == "lsa")
                {
                    result += "Н";
                }

                if (array_ciphertexts[index] == "qvd")
                {
                    result += "О";
                }

                if (array_ciphertexts[index] == "ltg")
                {
                    result += "П";
                }

                if (array_ciphertexts[index] == "iyy")
                {
                    result += "Р";
                }

                if (array_ciphertexts[index] == "bjn")
                {
                    result += "С";
                }

                if (array_ciphertexts[index] == "rks")
                {
                    result += "Т";
                }

                if (array_ciphertexts[index] == "elu")
                {
                    result += "У";
                }

                if (array_ciphertexts[index] == "loz")
                {
                    result += "Ф";
                }

                if (array_ciphertexts[index] == "wnq")
                {
                    result += "Х";
                }

                if (array_ciphertexts[index] == "ugb")
                {
                    result += "Ц";
                }

                if (array_ciphertexts[index] == "ppu")
                {
                    result += "Ч";
                }

                if (array_ciphertexts[index] == "jrj")
                {
                    result += "Ш";
                }

                if (array_ciphertexts[index] == "ahh")
                {
                    result += "Щ";
                }

                if (array_ciphertexts[index] == "fem")
                {
                    result += "Я";
                }

                if (array_ciphertexts[index] == "uzd")
                {
                    result += "Ь";
                }

                if (array_ciphertexts[index] == "tiq")
                {
                    result += "Ю";
                }

                if (array_ciphertexts[index] == "yic")
                {
                    result += "а";
                }

                if (array_ciphertexts[index] == "ysw")
                {
                    result += "б";
                }

                if (array_ciphertexts[index] == "jtf")
                {
                    result += "в";
                }

                if (array_ciphertexts[index] == "ezb")
                {
                    result += "г";
                }

                if (array_ciphertexts[index] == "wja")
                {
                    result += "д";
                }

                if (array_ciphertexts[index] == "cju")
                {
                    result += "е";
                }

                if (array_ciphertexts[index] == "rdj")
                {
                    result += "є";
                }

                if (array_ciphertexts[index] == "fqr")
                {
                    result += "ж";
                }

                if (array_ciphertexts[index] == "qom")
                {
                    result += "з";
                }

                if (array_ciphertexts[index] == "qxe")
                {
                    result += "и";
                }

                if (array_ciphertexts[index] == "sxj")
                {
                    result += "і";
                }

                if (array_ciphertexts[index] == "gqc")
                {
                    result += "ї";
                }

                if (array_ciphertexts[index] == "mbj")
                {
                    result += "й";
                }

                if (array_ciphertexts[index] == "rxu")
                {
                    result += "к";
                }
                if (array_ciphertexts[index] == "wnc")
                {
                    result += "л";
                }

                if (array_ciphertexts[index] == "zal")
                {
                    result += "м";
                }

                if (array_ciphertexts[index] == "arr")
                {
                    result += "н";
                }

                if (array_ciphertexts[index] == "fpb")
                {
                    result += "о";
                }

                if (array_ciphertexts[index] == "gqi")
                {
                    result += "п";
                }

                if (array_ciphertexts[index] == "dhv")
                {
                    result += "р";
                }

                if (array_ciphertexts[index] == "rhj")
                {
                    result += "с";
                }

                if (array_ciphertexts[index] == "kke")
                {
                    result += "т";
                }

                if (array_ciphertexts[index] == "bik")
                {
                    result += "у";
                }

                if (array_ciphertexts[index] == "dnu")
                {
                    result += "ф";
                }

                if (array_ciphertexts[index] == "ozc")
                {
                    result += "х";
                }

                if (array_ciphertexts[index] == "ozc")
                {
                    result += "ц";
                }

                if (array_ciphertexts[index] == "qmj")
                {
                    result += "ч";
                }

                if (array_ciphertexts[index] == "kuk")
                {
                    result += "ш";
                }

                if (array_ciphertexts[index] == "bjc")
                {
                    result += "щ";
                }

                if (array_ciphertexts[index] == "tas")
                {
                    result += "я";
                }

                if (array_ciphertexts[index] == "pzs")
                {
                    result += "ь";
                }

                if (array_ciphertexts[index] == "utc")
                {
                    result += "ю";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }

        private string Decipher_punctuation_marks(string[] array_ciphertexts, int index)
        {
            string result = string.Empty;

            try
            {
                if (array_ciphertexts[index] == "sou")
                {
                    result += "[";
                }

                if (array_ciphertexts[index] == "wlx")
                {
                    result += "]";
                }

                if (array_ciphertexts[index] == "xvb")
                {
                    result += "(";
                }

                if (array_ciphertexts[index] == "dac")
                {
                    result += ")";
                }

                if (array_ciphertexts[index] == "ukh")
                {
                    result += "{";
                }

                if (array_ciphertexts[index] == "eac ")
                {
                    result += "}";
                }

                if (array_ciphertexts[index] == "eac")
                {
                    result += ",";
                }

                if (array_ciphertexts[index] == "imr")
                {
                    result += ":";
                }

                if (array_ciphertexts[index] == "sxy")
                {
                    result += "‒";
                }

                if (array_ciphertexts[index] == "xvq")
                {
                    result += "…";
                }

                if (array_ciphertexts[index] == "ngc")
                {
                    result += "!";
                }

                if (array_ciphertexts[index] == "upc")
                {
                    result += ".";
                }

                if (array_ciphertexts[index] == "svp")
                {
                    result += "‘";
                }

                if (array_ciphertexts[index] == "dpm")
                {
                    result += "’";
                }

                if (array_ciphertexts[index] == "dak")
                {
                    result += "«";
                }

                if (array_ciphertexts[index] == "hsy")
                {
                    result += "»";
                }

                if (array_ciphertexts[index] == "jgt ")
                {
                    result += "?";
                }

                if (array_ciphertexts[index] == "mft")
                {
                    result += ";";
                }

                if (array_ciphertexts[index] == "oah")
                {
                    result += "/";
                }

                if (array_ciphertexts[index] == "omq")
                {
                    result += " ";
                }

                if (array_ciphertexts[index] == "cgs")
                {
                    result += "&";
                }

                if (array_ciphertexts[index] == "gjj")
                {
                    result += "@";
                }

                if (array_ciphertexts[index] == "bru")
                {
                    result += "^";
                }

                if (array_ciphertexts[index] == "jeg")
                {
                    result += "¯";
                }

                if (array_ciphertexts[index] == "wur")
                {
                    result += "•";
                }

                if (array_ciphertexts[index] == "ndg")
                {
                    result += "*";
                }

                if (array_ciphertexts[index] == "ltd")
                {
                    result += "†";
                }

                if (array_ciphertexts[index] == "ptz")
                {
                    result += "‡";
                }

                if (array_ciphertexts[index] == "lcq")
                {
                    result += "°";
                }

                if (array_ciphertexts[index] == "lyf")
                {
                    result += "¡";
                }

                if (array_ciphertexts[index] == "bvs")
                {
                    result += "¿";
                }

                if (array_ciphertexts[index] == "gbm")
                {
                    result += "#";
                }

                if (array_ciphertexts[index] == "ygt")
                {
                    result += "№";
                }

                if (array_ciphertexts[index] == "teo")
                {
                    result += "%";
                }

                if (array_ciphertexts[index] == "eyt")
                {
                    result += "¶";
                }

                if (array_ciphertexts[index] == "rwk")
                {
                    result += "′";
                }

                if (array_ciphertexts[index] == "kox")
                {
                    result += "″";
                }

                if (array_ciphertexts[index] == "nog")
                {
                    result += "§";
                }

                if (array_ciphertexts[index] == "lli")
                {
                    result += "~";
                }

                if (array_ciphertexts[index] == "ytj")
                {
                    result += "_";
                }

                if (array_ciphertexts[index] == "mtp")
                {
                    result += "|";
                }

                if (array_ciphertexts[index] == "tej")
                {
                    result += "-";
                }

                if (array_ciphertexts[index] == "zns")
                {
                    result += "¦";
                }

                if (array_ciphertexts[index] == "ssr")
                {
                    result += "+";
                }

                if (array_ciphertexts[index] == "xkv")
                {
                    result += "=";
                }

                if (array_ciphertexts[index] == "ykz")
                {
                    result += "<";
                }

                if (array_ciphertexts[index] == "cdi")
                {
                    result += ">";
                }

                if (array_ciphertexts[index] == "jfj")
                {
                    result += "?";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }

        private string Decipher_numbers(string[] array_ciphertexts, int index)
        {
            string result = string.Empty;

            try
            {
                if (array_ciphertexts[index] == "fyp")
                {
                    result += "1";
                }

                if (array_ciphertexts[index] == "xpl")
                {
                    result += "2";
                }

                if (array_ciphertexts[index] == "omm")
                {
                    result += "3";
                }

                if (array_ciphertexts[index] == "ula")
                {
                    result += "4";
                }

                if (array_ciphertexts[index] == "san")
                {
                    result += "5";
                }

                if (array_ciphertexts[index] == "toh")
                {
                    result += "6";
                }

                if (array_ciphertexts[index] == "sro")
                {
                    result += "7";
                }

                if (array_ciphertexts[index] == "cyg")
                {
                    result += "8";
                }

                if (array_ciphertexts[index] == "lhu")
                {
                    result += "9";
                }

                if (array_ciphertexts[index] == "dmu ")
                {
                    result = "0";
                }
            }
            catch (System.Exception)
            {
            }

            return result;
        }
    }
}
