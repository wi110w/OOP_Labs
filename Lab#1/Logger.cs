namespace Lab_1
{
    using System;
    using System.IO;
    
    class Logger
    {
        StreamWriter writer = new StreamWriter(@"output.log", false);

        public void Log(string actionType, string comment, string state)
        {
            this.writer.WriteLine(
                "[{0}][{1}][{2}][{3}][{4}]",
                DateTime.Now.ToShortDateString(),
                DateTime.Now.ToLongTimeString(),
                actionType,
                comment,
                state);
            this.writer.Flush();
        }
    }
}
