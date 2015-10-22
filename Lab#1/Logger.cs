using System;
using System.IO;

namespace Lab_1
{
    class Logger
    {
        StreamWriter writer = new StreamWriter(@"output.log", false);
        public void Log(string actionType, string comment, string state)
        {
            writer.WriteLine(
                "[{0}][{1}][{2}][{3}][{4}]",
                DateTime.Now.ToShortDateString(),
                DateTime.Now.ToLongTimeString(),
                actionType,
                comment,
                state);
            writer.Flush();
        }
    }
}
