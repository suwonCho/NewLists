using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Function;
using System.Data;

namespace NewLists
{
	class db
	{
		/// <summary>
		/// 신규 여부를 확인 하고 추가한다.
		/// </summary>
		/// <param name="site"></param>
		/// <param name="i_name"></param>
		/// <returns></returns>
		public static bool isNewList(string site, string i_name)
		{
			bool rtn;

			Function.Db.SQLite db = new Function.Db.SQLite(vari.db_path);

			string sql = string.Format(@"SELECT COUNT(*) cnt
FROM ICO
WHERE SITE = '{0}'
AND I_NAME = '{1}'", site, i_name);

			

			using (DataSet ds = db.dsExcute_Query(sql))
			{
				rtn = Fnc.obj2int(ds.Tables[0].Rows[0]["cnt"]) < 1;
			}

			//신규 처리
			if(rtn)
			{
				sql = string.Format(@"INSERT INTO ICO ( SITE, I_NAME, DATE )
VALUES ('{0}', '{1}', '{2}' )", site, i_name, Fnc.Date2String(DateTime.Now, Fnc.enDateType.DateTime));

				db.intExcute_Query(sql);
			}

			return rtn;

		}



		/// <summary>
		/// 해당 사이트의 목록을 가져온다.
		/// </summary>
		/// <param name="site"></param>
		/// <returns></returns>
		public static DataTable NewList_Get(string site)
		{
			Function.Db.SQLite db = new Function.Db.SQLite(vari.db_path);

			string sql = string.Format(@"SELECT I_Name, 0 IsChk
FROM ICO
WHERE SITE = '{0}'", site);

			return db.dsExcute_Query(sql).Tables[0];
		}

		/// <summary>
		/// 사이트에 신규 심볼을 추가한다.
		/// </summary>
		/// <param name="site"></param>
		/// <param name="i_name"></param>
		public static void NewList_Add(string site, string i_name)
		{
			Function.Db.SQLite db = new Function.Db.SQLite(vari.db_path);

			string sql = string.Format(@"INSERT INTO ICO ( SITE, I_NAME, DATE )
VALUES ('{0}', '{1}', '{2}' )", site, i_name, Fnc.Date2String(DateTime.Now, Fnc.enDateType.DateTime));

			db.intExcute_Query(sql);
		}

		/// <summary>
		/// 사이트에서 심볼을 삭제 처리한다.
		/// </summary>
		/// <param name="site"></param>
		/// <param name="i_name"></param>
		public static void NewList_Del(string site, string i_name)
		{
			Function.Db.SQLite db = new Function.Db.SQLite(vari.db_path);

			string sql = string.Format(@"DELETE FROM ICO 
WHERE SITE = '{0}' AND I_NAME = '{1}'", site, i_name);

			db.intExcute_Query(sql);
		}
		

		public static DataTable ChatID_Get(string mtype)
		{
			Function.Db.SQLite db = new Function.Db.SQLite(vari.db_path);

			string sql = string.Format(@"SELECT ChatID,DESC FROM telegram WHERE mType = '{0}'", mtype);

			return db.dsExcute_Query(sql).Tables[0];
		}

		public static bool isNewNotice(string site, string key, string title)
		{
			bool rtn;

			Function.Db.SQLite db = new Function.Db.SQLite(vari.db_path);

			string sql = string.Format(@"SELECT COUNT(*) cnt
FROM Notice
WHERE SITE = '{0}'
AND Key = '{1}'", site, key);
			
			using (DataSet ds = db.dsExcute_Query(sql))
			{
				rtn = Fnc.obj2int(ds.Tables[0].Rows[0]["cnt"]) < 1;
			}

			//신규 처리
			if (rtn)
			{
				sql = string.Format(@"INSERT INTO Notice ( SITE, Key, Title, DATE )
VALUES ('{0}', '{1}', '{2}', '{3}' )", site, key, title, Fnc.Date2String(DateTime.Now, Fnc.enDateType.DateTime));

				db.intExcute_Query(sql);
			}

			return rtn;

		}

	}
}
