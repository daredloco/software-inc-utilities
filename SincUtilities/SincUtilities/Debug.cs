using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SincUtilities
{
	public static class Debug
	{
		public static string ModName = "Mod";

		static void Log(string msg)
		{
			string path = Path.Combine(Application.dataPath, ModName, "log.txt");
			Directory.CreateDirectory(new FileInfo(path).DirectoryName);
			using (StreamWriter sw = new StreamWriter(path, true))
			{
				sw.WriteLine(DateTime.Now + ": " + msg);
			}
		}

		public static void Info(string msg)
		{
			UnityEngine.Debug.Log(msg);
			Log("[INFO] " + msg);
		}

		public static void Warn(string msg)
		{
			UnityEngine.Debug.LogWarning(msg);
			Log("[WARNING] " + msg);
		}

		public static void Error(string msg) 
		{
			UnityEngine.Debug.LogError(msg);
			Log("[ERROR] " + msg);
		}

		public static void Exception(Exception ex)
		{
			UnityEngine.Debug.LogException(ex);
			Log("[EXCEPTION] " + ex.Message);
		}
	}
}
