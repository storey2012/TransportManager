using System;
using System.IO;
using System.Text;
using System.Reflection; 
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace TransManager
{
	/// <summary>
	/// Simple logging class, for both console and text file history. Wraps "System.Console" - RIW 07/2010
	/// </summary>
	public class Log : IDisposable
  {
    #region Member Variables

    public static StreamWriter Out		  { get; private set; }
		public static string FileName			  { get; private set; }
		public static string Application	  { get; private set; }
    public static string DatabaseName   { get; private set; }
    public static bool IsLoggingToDB    { get; private set; }
    public static bool IsLoggingToFile { get; private set;  }
    public static int BatchID           { get; private set; }
    


    private static SqlConnection sqlConn;
    //private static DbHelper _DbHelper = new DbHelper();
    private static string _messageFile = "";
    private static string _messageDb = "";
    private static int _batchID;
       
    private enum LogMode
    {
      FileOnly,
      Database,
      FileAndDatabase
    }
    #endregion

    public Log() {
      IsLoggingToDB = false;
      IsLoggingToFile = false;

    }
		 
    #region Methods

		/// <summary>
    /// Create a log file, in the format [pathoflog]\[application]\yyyyMMdd-HHmmss.log
    /// </summary>
		/// <param name="pathOfLog">Destination path of the Log file</param>
    /// <param name="application">Name the application</param>
    
    public static bool CreateFileLog(string pathOfLog, string application, ref string message)
		{
      try
      {
        DirectoryInfo logpath = new DirectoryInfo(pathOfLog);

        if (!logpath.Exists) Directory.CreateDirectory(pathOfLog);

        FileName = Path.Combine(logpath.FullName, application) + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".log";
        WriteLine("Log file is '" + FileName + "'");
        FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
        Out = new StreamWriter(fs, Encoding.GetEncoding(0));
        Assembly assembly = Assembly.GetExecutingAssembly();
        WriteLine(assembly.ToString());
      }
      catch (SystemException e) {
        message = e.Message;
        return false;
      }

      return true;

		}
		
    /// <summary>
    /// set up logging to database only
    /// </summary>
    /// <param name="application"></param>
    /// <param name="databaseConnectionString"></param>
    /// <param name="batchCode"></param>
    public static void Create(string pathOfLog, string application)
    {
      Application = application;

      IsLoggingToFile = CreateFileLog(pathOfLog, application, ref _messageFile);

            WriteLine(Assembly.GetCallingAssembly().ToString());

    }

    public static void Create(string pathOfLog, string application, string databaseConnectionString, string batchCode)
    {

      Create(pathOfLog, application);

      //CreateDatabaseLog(databaseConnectionString, batchCode);

      //If there is a string in either of the private variables it is only because of a failure.  Try to write this information to db or file log if they are working.
      if (_messageFile != "") {
        Log.WriteLine("Error creating file logging with message : " + _messageFile);
      }
      if (_messageDb != "")
      {
        Log.WriteLine("Error creating database logging with message : " + _messageDb);
      }

    }

    //private static bool CreateDatabaseLog(string databaseConnectionString, string batchCode) {
      //open the db connection for the log
    //  try {

    //    IsLoggingToDB = _DbHelper.CreateBatch(databaseConnectionString,batchCode, Application, ref _messageDb, ref _batchID);
    //    BatchID = _batchID;
        
    //  }
    //  catch(SystemException e) {
    //    //write err message to file log if applicable
    //      WriteLine(e.Message);
    //      return false;
    //  }
    //  return true;
    //}


		/// <summary>
    /// Append to an already existing log file,  created by the calling class
    /// </summary>
		/// <param name="logFileNameFullPath">Destination Log file</param>
		public static void Append(string logFileNameFullPath)
		{			
			FileStream fs = new FileStream(logFileNameFullPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			Out = new StreamWriter(fs, Encoding.GetEncoding(0));
		}


    /// <summary>
    /// Closes the log
    /// </summary>
		public static void Close()
		{					
			Close(false);
		}

		/// <summary>
		/// Closes the log
		/// </summary>
		/// <param name="suspend">supresses the 'Log closed message' (ready for a 'Resume()' to append more lines)</param>
		public static void Close(bool suspend)
		{					
			if (suspend)
				WriteLine("Log suspended");
			else
				WriteLine("Log closed normally");

			Out.Flush();			
			Out.Close();				
		}

    /// <summary>
    /// Reopens an existing log ready to 'append' lines to
    /// </summary>
		public static void Resume()
		{					
			Out = new StreamWriter(new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite));
			WriteLine("Log resumed");
		}

		    /// <summary>
    /// Writes an entry to the log with time and date details automatically prepended.
    /// </summary>
    /// <param name="message">message to add to log</param>
		public static void WriteLine(object message)
		{
			WriteLine(message.ToString());
		}
    /// <summary>
    /// Writes an entry to the log with time and date details automatically prepended.
    /// </summary>
    /// <param name="message">message to add to log</param>
		public static void WriteLine(string message)
		{
			//Console.Write(DateTime.Now.ToString("HH:mm:ss : "));												
			//Console.WriteLine(message);			
            									

      if(IsLoggingToFile){
        if (Out == null) return;
			  //	throw new Exception("error, Create() method must be called before any WriteLine() methods");
            Out.Write(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss "));
			  
            Out.Write(" : ");
            Out.WriteLine(message);				
			Out.Flush();
      }

      }

		public static void WriteLine()
		{
			WriteLine(String.Empty);												
		}

    public static string ReadLine()
    {
      return Console.ReadLine();
    }

        public static void WriteCommand(OleDbCommand cmd) {
            WriteLine("OLEDB COMMAND " + cmd.CommandText);
            WriteLine("OLEDB TYPE " + cmd.CommandType.ToString());
            foreach (OleDbParameter param in cmd.Parameters) {
                WriteLine("OLEDB PARAM " + param.ParameterName + ": " + param.Value.ToString());
            }
        }

    public void Dispose()
    {
      Close();
    }

    #endregion
  }
}