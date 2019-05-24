using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using hkti_api.models.hkti;

namespace appglobal
{
  /// <summary>
  /// Main class for initiating database content on .netcore
  /// </summary>
  public static class DbInitializer
  {

    /// <summary>
    /// Main method to populate database content
    /// </summary>
    public static void Initialize()
    {
      using (var _context = new webapi_db(AppGlobal.get_db_option()))
      {
        //run primary migration method
        _context.Database.Migrate();

        // Look for any user or feature group
        if (_context.m_bulan.Any())
        {
          return; // if DB has been seeded, exit the method;
        }

        try
        {
          #region m_bulan
          List<m_bulan> bulan_list = new List<m_bulan>(){
            new m_bulan{
              m_bulan_id = 1,
              m_bulan_nama = "Januari",
            },
            new m_bulan{
              m_bulan_id = 2,
              m_bulan_nama = "Febuari",
            },
            new m_bulan{
              m_bulan_id = 3,
              m_bulan_nama = "Maret",
            },
            new m_bulan{
              m_bulan_id = 4,
              m_bulan_nama = "April",
            },
            new m_bulan{
              m_bulan_id = 5,
              m_bulan_nama = "Mei",
            },
            new m_bulan{
              m_bulan_id = 6,
              m_bulan_nama = "Juni",
            },
            new m_bulan{
              m_bulan_id = 7,
              m_bulan_nama = "Juli",
            },
            new m_bulan{
              m_bulan_id = 8,
              m_bulan_nama = "Agustus",
            },
            new m_bulan{
              m_bulan_id = 9,
              m_bulan_nama = "September",
            },
            new m_bulan{
              m_bulan_id = 10,
              m_bulan_nama = "Oktober",
            },
            new m_bulan{
              m_bulan_id = 11,
              m_bulan_nama = "November",
            },
            new m_bulan{
              m_bulan_id = 12,
              m_bulan_nama = "Desember",
            },
          };
          _context.m_bulan.AddRange(bulan_list);
          _context.SaveChanges();
          #endregion
        }
        catch (Exception e)
        {
          Console.WriteLine(e);
        }
      }

    }

    /// <summary>
    /// Decompress And Deserialize form byte file
    /// </summary>
    /// <param name="data">byte</param>
    /// <returns></returns>
    public static T DecompressAndDeserialize<T>(this byte[] data)
    {
      using (System.IO.MemoryStream ms = new System.IO.MemoryStream(data))
      using (System.IO.Compression.GZipStream zs = new System.IO.Compression.GZipStream(ms, System.IO.Compression.CompressionMode.Decompress, true))
      {
        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
        return (T)bf.Deserialize(zs);
      }
    }
  }
}