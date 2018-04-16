using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Function;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace NewLists
{
	class fnc
	{
		public static void Init_Vari()
		{
			vari.pgm_path = Application.StartupPath;

			vari.Setting = new Setting(vari.pgm_path + "\\config\\setting.xml");

			vari.db_path = vari.pgm_path + "\\config\\NewList.db";
		}


		public static void Despos_Vari()
		{
			vari.Setting.Setting_Save();
		}

		public static ArrayList SymbolGet(string str, string symbol)
		{
			ArrayList rtn = new ArrayList();

			int idx = 0;
			int idx2 = 0;

			while(true)
			{
				idx = str.IndexOf(symbol, idx);

				if (idx < 0) break;

				idx = str.IndexOf(":", idx);

				if (idx < 0) break;

				idx2 = str.IndexOf(",", idx);

				if (idx < 0) break;

				string value = str.Substring(idx + 1, idx2 - idx -1).Replace("\"", "");

				idx = idx2;

				rtn.Add(value);
			}
			
			return rtn;

		}




	}
}
