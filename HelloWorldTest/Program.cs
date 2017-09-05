using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter.GenericTextWriter.WriteText(args[0], 
                (TextWriter.TextWriterType)Enum.Parse(typeof(TextWriter.TextWriterType), Properties.Settings.Default.WriterType),
                (TextWriter.LogWriterType)Enum.Parse(typeof(TextWriter.LogWriterType), Properties.Settings.Default.LoggerType));
            Console.ReadKey();
        }
    }
}
