using System.IO;
using System.Text.RegularExpressions;

namespace _5.Exceptions_Pract
{
    public class ErrorCatcher
    {
        public static double Catcher(string logFilePath)
        {
            int totalLogEntites = 0;
            int errorEntities = 0;

            try
            {
                using (StreamReader sreader = new StreamReader(logFilePath))
                {
                    string logLine;
                    while ((logLine = sreader.ReadLine()) != null)
                    {
                        totalLogEntites++;

                        //Errors finding
                        if (Regex.IsMatch(logLine, @"\b(error|Error|ERROR)\b"))
                        {
                            errorEntities++;

                            //Logs errors to the file
                            using (StreamWriter swriter = new StreamWriter("errors.log"))
                            {
                                swriter.WriteLine(logLine);
                            }

                            //Checking criticals
                            if (Regex.IsMatch(logLine, @"\b(CRITICAL ERROR)\b"))
                            {
                                throw new CriticalException(logLine);
                            }

                        }
                    }
                }
                double ratio = totalLogEntites / errorEntities;
                return ratio;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found! " + e.Message);
                return 0;
            }
            catch (IOException e)
            {
                Console.WriteLine("Some exception is came up: " + e.Message);
                return 0;
            }
            catch (OutOfMemoryException e )
            {
                Console.WriteLine("Out of memory exception: " + e.Message);
                return 0;
            }
            catch (CriticalException e)
            {
                Console.WriteLine("CRITTICAL ERROR: " + e.Message);
                return 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Please do not devide by zero : " + e.Message);
                return 0;
            }
            finally 
            {
                //Totals to the console
                Console.WriteLine("Total errors: " + errorEntities);
                Console.WriteLine("Total log entities: " + totalLogEntites);
                Console.WriteLine("Total critical errors: " + CriticalException.Ccount);

                //Clearing critical count variable
                CriticalException.Ccount = 0;
            }
    }
        //Voiding critical exception 
        public class CriticalException : Exception
        {
            public static int Ccount { get; set; } = 0;
            public CriticalException(string message):base(message) 
            {
                Ccount++;
            }
        }
    
        internal class Program
        {
            static void Main(string[] args)
            {
                string logFilePath = "yupdate.log";
                string errorFilePath = "errors.log";

                ErrorCatcher catcher = new ErrorCatcher();

                double ratio = Catcher(logFilePath);
                Console.WriteLine("Ratio: " + ratio);

            }
        }
    }
}