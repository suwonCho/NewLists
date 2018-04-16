using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Function;

namespace NewLists
{

	public enum enSymbol_Ch_Type { Add, Del };

	public enum enTN_Symbol { Text, Name };

	class vari
	{
		//26799103
		public static int apiId = 289179;
		public static string apiHash = "a06b775f5c1176f546707644ef76d7b4";

		//72919103
		//public static int apiId = 61903;
		//public static string apiHash = "786cd82e9e5dc2c3cfb6c6ae6b059a54";

		public static int TestCnt = 0;
        
		public static readonly string tele_token = "185429576:AAEXEyfvPalLku4FAkUDsTFJM89jmIyQJG8";
		
		public static string pgm_path;

		public static string db_path;

		public static Function.Setting Setting;



        /// <summary>
        /// 텔레그램 연결 전화 번호
        /// </summary>
        public static string HP;

	}


	public class clsItem
	{
		public int Idx { get; set; }
		public string Name { get; set; }
		public System.Windows.Forms.ListViewItem lstItem { get; set; }
     
        public string Url { get; set; }

		public int iRunCnt = 0;

		public int iErrCnt = 0;

		public clsItem(int idx, string name, string url)
		{
			Idx = idx;
			Name = name;
            Url = url;
		}


	}
}
