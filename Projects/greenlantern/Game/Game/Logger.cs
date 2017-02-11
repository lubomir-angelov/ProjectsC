using System;
using System.IO;
using System.Text;

namespace Game
{
    /// <summary>
    /// A class to log the exceptions
    /// </summary>
    class Logger
    {
        private const string File = "Log.txt";

        /// <summary>
        /// Writes the date/time and the exception to a file.
        /// Creates a new file or appends a new line.
        /// </summary>
        /// <param name="e">Input: exception</param>
        internal static void Log(Exception e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (System.IO.File.Exists(File))
                {
                    StreamWriter writer = new StreamWriter(File, true);
                    using (writer)
                    {
                        sb.Append(DateTime.Today.ToString());
                        sb.Append(" ");
                        sb.Append(e.ToString());
                        writer.WriteLine(sb.ToString());
                    }
                }
                else
                {
                    StreamWriter writer = new StreamWriter(File, false);
                    using (writer)
                    {
                        sb.Append(DateTime.Today.ToString());
                        sb.Append(" ");
                        sb.Append(e.ToString());
                        writer.WriteLine(sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading Log file!");
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Logs to a file exception and icon
        /// </summary>
        /// <param name="e">Input exception</param>
        /// <param name="icon">Input icon</param>
        internal static void Log(Exception e, int row, int column, char symbol)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (System.IO.File.Exists(File))
                {
                    StreamWriter writer = new StreamWriter(File, true);
                    using (writer)
                    {
                        sb.Append(DateTime.Today.ToString());
                        sb.Append(" ");
                        sb.Append(row);
                        sb.Append(" ");
                        sb.Append(column);
                        sb.Append(" ");
                        sb.Append(symbol);
                        sb.Append(" ");
                        sb.Append(e.ToString());
                        writer.WriteLine(sb.ToString());
                    }
                }
                else
                {
                    StreamWriter writer = new StreamWriter(File, false);
                    using (writer)
                    {
                        sb.Append(DateTime.Today.ToString());
                        sb.Append(" ");
                        sb.Append(row);
                        sb.Append(" ");
                        sb.Append(column);
                        sb.Append(" ");
                        sb.Append(symbol);
                        sb.Append(" ");
                        sb.Append(e.ToString());
                        writer.WriteLine(sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading Log file!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
