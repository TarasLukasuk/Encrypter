using Encrypter.Factory_method;
using Encrypter.Factory_method.Decipher;
using Encrypter.Factory_method.Product;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Encrypter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encryption_text_Click(object sender, RoutedEventArgs e)
        {
            string Text = new TextRange(Entered_text.Document.ContentStart,
            Entered_text.Document.ContentEnd).Text;

            Translation.Document.Blocks.Clear();
            Translation.Document.Blocks.Add(new Paragraph(new Run(Choosing_encryption_method(Text))));
        }

        private void Decoding_text_Click(object sender, RoutedEventArgs e)
        {
            string Text = new TextRange(Entered_text.Document.ContentStart,
            Entered_text.Document.ContentEnd).Text;

            Translation.Document.Blocks.Clear();
            Translation.Document.Blocks.Add(new Paragraph(new Run(Decipher_text(new Aurora_decoding(Text)))));

        }

        private void Copy_text_Click(object sender, RoutedEventArgs e)
        {
            string Text = new TextRange(Translation.Document.ContentStart,
           Translation.Document.ContentEnd).Text;

            Clipboard.Clear();
            Clipboard.SetText(Text);
        }

        private string Decipher_text(Decoding_text decryption_Method) { return decryption_Method.Decrypt_encrypted_message(); }

        private void Toolbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        private string Choosing_encryption_method(string text)
        {
            Random random = new Random();

            Dictionary<int, Encryption_text> Encryption_methods = new Dictionary<int, Encryption_text>();
            {
                Encryption_methods.Add(0, new Aurora_encryption(text));
            }

            return Encryption_methods[random.Next(Encryption_methods.Count)].Сreate_encrypted_message();
        }
        
    }
}
