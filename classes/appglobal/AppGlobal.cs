using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appglobal
{
  public class AppGlobal
  {
    internal static string DEFAULT_SECRET = "gls_cloud_api";
    internal static string BASE_URL = "";
    internal static string LOG_DIR = @"./LOGS";
    internal static string MYSQL_CS = "Server=sql;Database=web_api;Uid=root;Pwd=mypassword";
    internal static string OVERRIDE_CS = "";
    internal static string OVERRIDE_TM = "";

    /// <summary>
    /// Used in defining which connection to be used in a db_context
    /// </summary>
    /// <returns></returns>
    public static dynamic get_db_option()
    {
      DbContextOptionsBuilder ob = new DbContextOptionsBuilder<webapi_db>();
      ob.UseMySql(get_connection_string());
      return ob.Options;
    }

    /// <summary>
    /// Get primary connection string for .netcore project
    /// </summary>
    /// <param name="db_server"></param>
    /// <returns></returns>
    static internal string get_connection_string(string db_server = "MySQL")
    {
      string connection = "";
      if (db_server == "MySQL")
      {
        string file_setting = OVERRIDE_CS;
        connection = file_setting == "" ? MYSQL_CS : file_setting;
      }
      return connection;
    }

    /// <summary>
    /// Get primary working directory for application path searching
    /// </summary>
    /// <returns></returns>
    public static string get_working_directory()
    {
      return BASE_URL; //Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
    }
    
    /// <summary>
    /// Standardize console logging
    /// </summary>
    public static void console_log(string name, string content)
    {
      Console.WriteLine("======================================================");
      Console.Write(name + " >> ");
      Console.WriteLine(content);
      Console.WriteLine("======================================================");
    }
  }
}
