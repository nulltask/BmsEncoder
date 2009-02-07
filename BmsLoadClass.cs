using System;
using System.IO;
using System.Text;

namespace Cage
{
	/// <summary>
	/// LoadBMSHeader の概要の説明です。
	/// </summary>
	public class BmsLoadClass
	{
		public BmsLoadClass()
		{
			//
			// TODO: コンストラクタ ロジックをここに追加してください。
			//
		}

		public enum HeaderType : int
		{
			PLAYER,
			TITLE,
			ARTIST,
			GENRE,
			BPM,
			PLAYLAVEL,
			RANK,
			TOTAL,
			COMMENT,
			URL,
			MAIL,
			THIS_LENGTH
		}

		public static void LoadBMSHeader(string filename,out string[] p)
		{
			p = new string[(int)HeaderType.THIS_LENGTH];
			StreamReader sr = new StreamReader(filename, Encoding.GetEncoding("Shift_JIS"));
			string line;
			while((line = sr.ReadLine()) != null)
			{
				if(!line.StartsWith("#") && !line.StartsWith("%")) continue;
				switch(GetBmsCmd(line).ToLower())
				{
					case "#player":
						p[(int)HeaderType.PLAYER] = GetBmsValue(line);
						break;
					case "#title":
						p[(int)HeaderType.TITLE] = GetBmsValue(line);
						break;
					case "#artist":
						p[(int)HeaderType.ARTIST] = GetBmsValue(line);
						break;
					case "#genre":
						p[(int)HeaderType.GENRE] = GetBmsValue(line);
						break;
					case "#bpm":
						p[(int)HeaderType.BPM] = GetBmsValue(line);
						break;
					case "#playlevel":
						p[(int)HeaderType.PLAYLAVEL] = GetBmsValue(line);
						break;
					case "#rank":
						p[(int)HeaderType.RANK] = GetBmsValue(line);
						break;
					case "#total":
						p[(int)HeaderType.TOTAL] = GetBmsValue(line);
						break;
					case "#comment":
						p[(int)HeaderType.COMMENT] = GetBmsValue(line);
						break;
					case "%url":
						p[(int)HeaderType.URL] = GetBmsValue(line);
						break;
					case "%mail":
						p[(int)HeaderType.MAIL] = GetBmsValue(line);
						break;
				}
			}
		}

		private static string GetBmsValue(string line)
		{
			return line.Substring(line.IndexOf(" ")).Trim();
		}

		private static string GetBmsCmd(string line)
		{
			string[] cmd = line.Split(new char[] {' '});
			return cmd[0];
		}
	}
}
