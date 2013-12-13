using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Minion
{
    public class TextBoxStreamWriter : TextWriter
    {
        RichTextBox _output = null;

        public TextBoxStreamWriter(RichTextBox output)
        {
            _output = output;
        }
        public override void Write(char value)
        {
            MethodInvoker action = delegate { _output.AppendText(value.ToString()); };
            _output.BeginInvoke(action);
        }
        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}
