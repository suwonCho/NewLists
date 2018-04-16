using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Function;
using System.Collections;

using Telegram.Massenger;

namespace NewLists
{
	public partial class frmNewLists : Function.form.frmBaseForm
	{
		System.Threading.Timer[] tmrWork;
        System.Threading.Timer tmrChkAlive;
        clsItem[] cItems;

        int iChkCnt = 0;

        /// <summary>
        /// 텔레그램 클라이언트
        /// </summary>
        Client _client = null;

        /// <summary>
        /// 조회 할 아이템들 - 추가시 추가
        /// </summary>
        string[] sItems;
        /// <summary>
        /// 데이터를 가지고올 url들
        /// </summary>
        string[] sUrls;

        /// <summary>
        /// 텔레그램 전송 로그
        /// </summary>
        Function.Util.Log cTelLg;

        public frmNewLists()
		{
			InitializeComponent();

			fnc.Init_Vari();

			SavePosition = true;
			SaveConfigFileType = Function.form.enConfigFileType.ConfigXml;
			SavePosition_Setting = vari.Setting;

            clsLog = new Function.Util.Log(vari.pgm_path + "\\Log", "Log", 30, true);

#if (!DEBUG)
			button1.Visible = false;
#endif

		}


		private string json_get(string url)
		{
			
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
			

			// 헤더 정의부분 입니다. (웹페이지에 따라 요청 헤더문이 틀릴수도 있습니다만.. 보통 이런식입니다.)
			req.Accept = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; WOW64; Trident/6.0)";

			//"Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; .NET CLR 2.0.50727; .NET CLR 3.0.04506.590; .NET CLR 3.5.20706; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";


			string sendData = "";

			req.Method = "GET";
			req.Accept = "text/html, application/xhtml+xml, */*";
			//req.Referer = @"http://www.ppomppu.co.kr/index.php";
			req.ContentLength = sendData.Length;
			req.ContentType = "application/x-www-form-urlencoded";
			req.KeepAlive = true;
			//req.CookieContainer = LogIn_cookie;


			string html = "";
			////요청결과
			HttpWebResponse rst = (HttpWebResponse)req.GetResponse();

			if (rst.StatusCode == HttpStatusCode.OK)
			{
				Stream st = rst.GetResponseStream();
				//StreamReader sr = new StreamReader(st, Encoding.GetEncoding("euc-kr"));

				StreamReader sr = new StreamReader(st, Encoding.UTF8);

				html = sr.ReadToEnd(); //Encoding.Default.GetString(st.re)
			}


			return html;
		}


		private string json_get_up(string url)
		{

			string html = "";


			// Create a request for the URL.   
			WebRequest request = WebRequest.Create(
			  "https://upbit.com/service_center/notice?id=326");
			// If required by the server, set the credentials.  
			request.Credentials = CredentialCache.DefaultCredentials;
			// Get the response.  
			WebResponse response = request.GetResponse();
			// Display the status.  
			Console.WriteLine(((HttpWebResponse)response).StatusDescription);
			// Get the stream containing content returned by the server.  
			Stream dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access.  
			StreamReader reader = new StreamReader(dataStream);
			// Read the content.  
			string responseFromServer = reader.ReadToEnd();
			// Display the content.  
			Console.WriteLine(responseFromServer);
			// Clean up the streams and the response.  
			reader.Close();
			response.Close();


			return html;
		}


		protected override void ProcException(Exception ex, string strMethodName, bool showMessageBox = false)
        {
            base.ProcException(ex, strMethodName, showMessageBox);

            try
            {
                if(strMethodName != "TelegramMsgSend") TelegramMsgSend("Error", ex.Message);
            }
            catch
            {

            }
        }


        private void thBinance(object obj)
		{
            clsItem citem = obj as clsItem;

            if (citem == null)
            {
                return;
            }

            try
            {
                

                string html = json_get(citem.Url);

                html = html.Replace("[", "");
                html = html.Replace("]", "");

                TreeNode node = Function.json.jsonParse.String2TreeNode(html);

				int cnt = NewListCompByTreeNode(citem, node, "symbol", enTN_Symbol.Text, "", 30);

	   //         foreach (TreeNode n in node.Nodes)
	   //         {
	   //             if (n.Name == "symbol")
	   //             {
	   //                 bool isNew = db.isNewList(citem.Name, n.Text);

				//                 if (isNew)
				//                 {

				//NewSymbol_Changed(citem, n.Text, enSymbol_Ch_Type.Add);
				//                 }

				//                 cnt++;
				//             }
				//         }

				citem.iRunCnt = 1;

                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, cnt.ToString());
                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
                Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.White);
            }
            catch(Exception ex)
            {
                ProcException(ex, "thBinance", false);

                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, "0");
                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
                Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.Red);

            }


		}

		private void thBithumb(object obj)
		{
            clsItem citem = obj as clsItem;

            if (citem == null) return;

            try
            {
                

                string html = json_get(citem.Url);
                TreeNode node = Function.json.jsonParse.String2TreeNode(html);

                int cnt = NewListCompByTreeNode(citem, node.Nodes["data"], "", enTN_Symbol.Name, "", 2);

				//foreach (TreeNode n in node.Nodes["data"].Nodes)
    //            {
    //                bool isNew = db.isNewList(citem.Name, n.Name);

    //                if (isNew)
    //                {
				//		NewSymbol_Changed(citem, n.Name, enSymbol_Ch_Type.Add);
    //                }

    //                cnt++;
    //            }

				citem.iRunCnt = 1;


				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, cnt.ToString());
                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
                Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.White);

            }
            catch (Exception ex)
            {
                ProcException(ex, "thBithumb", false);

                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, "0");
                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
                Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.Red);
            }
        }



		private void thBinanceWallet(object obj)
		{
            clsItem citem = obj as clsItem;
            if (citem == null) return;

            try
            {
                

                string html = json_get(citem.Url);

                ArrayList alst = fnc.SymbolGet(html, "assetCode");

				if (alst.Count < 100)
				{
					throw new Exception(string.Format("조회된건수가 100건이 안됨.총 {0}건", alst.Count));
				}

				string h = "";
				//string name;
				int cnt = NewListCompByArray(citem, alst, h, 10);
				
      //          foreach (object n in alst)
      //          {
      //              bool isNew = db.isNewList(citem.Name, n.ToString());

      //              if (isNew)
      //              {
						//NewSymbol_Changed(citem, n.ToString(), cnSymbol_Ch_Type.Add);
      //              }

      //              cnt++;

      //          }

				citem.iRunCnt = 1;

				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, cnt.ToString());
                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
                Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.White);
            }
            catch (Exception ex)
            {
                ProcException(ex, "thBinanceWallet", false);

                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, "0");
                Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
                Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.Red);
            }
        }

		/// <summary>
		/// 업빗 가격
		/// </summary>
		/// <param name="obj"></param>
		private void thUpbit(object obj)
		{
			clsItem citem = obj as clsItem;

			if (citem == null) return;

			try
			{
				string html = json_get(citem.Url);

				ArrayList alst = fnc.SymbolGet(html, "\"code\"");

				if(alst.Count < 100)
				{
					throw new Exception(string.Format("조회된건수가 100건이 안됨.총 {0}건", alst.Count));
				}

				string h = "CRIX.UPBIT.";
				//string name;
				int cnt = NewListCompByArray(citem, alst, h, 19);
				
				citem.iRunCnt = 1;
				
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, cnt.ToString());
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
				Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.White);

				citem.iErrCnt = 0;

			}
			catch (Exception ex)
			{
				citem.iErrCnt++;

				//업빗은 자주에러가 발생 함으로 3회 이상 일시만 문자 발송
				if (citem.iErrCnt > 3)
				{
					ProcException(ex, "thUpbit", false);
					citem.iErrCnt = 0;
				}

				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, "0");
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
				Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.Red);
			}
		}


	


		private void thUpbitNotice(object obj)
		{
			clsItem citem = obj as clsItem;

			if (citem == null) return;

			try
			{
				string html = json_get_up("https://upbit.com/service_center/notice?id=326");


				int cnt = 0;

				citem.iRunCnt = 1;

				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, cnt.ToString());
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
				Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.White);

			}
			catch (Exception ex)
			{
				ProcException(ex, "thUpbitNotice", false);

				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, "0");
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
				Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.Red);
			}

		}


		private void thBithumbNotice(object obj)
		{
			clsItem citem = obj as clsItem;

			if (citem == null) return;

			try
			{
				string html = json_get(citem.Url);
				
				int cnt = 0;
				int idx = 0;
				int idx2 = 0;
				string smark = "<div class=\"entry-thumb\">";				
				string url;
				string notice;
				bool isNew;

				while(true)
				{
					idx = html.IndexOf(smark, idx);

					if (idx < 0) break;

					//공지 주소 조회
					idx = html.IndexOf("<a href=\"", idx + smark.Length);
					idx2 = html.IndexOf("\">", idx + 1);

					url = html.Substring(idx + 9, idx2 - idx - 9);

					//제목 찾기
					idx = idx2;
					idx = html.IndexOf( url+ "\">", idx);
					idx += 2;
					idx2 = html.IndexOf("</a>", idx);

					notice = html.Substring(idx + url.Length, idx2 - idx - url.Length);

					idx = idx2;

					isNew = db.isNewNotice(citem.Name, url, notice);

					if(isNew)
					{   //신규 항목임
						Thread.Sleep(500);

						Notice_Add(citem, url, notice);
					}


					cnt++;
					
					//Console.WriteLine("[{0}]{1}  / {2}",cnt, url, notice);				
				}
				
				citem.iRunCnt = 1;

				if (cnt != 9) TelegramMsgSend("Error", string.Format("빗썸공지가 9건이 아닙니다. {0}건", cnt));


				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, cnt.ToString());
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
				Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.White);

			}
			catch (Exception ex)
			{
				ProcException(ex, "thUpbitNotice", false);

				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 2, "0");
				Function.form.control.Invoke_ListView_SubItem_Text(lstNew, citem.lstItem, 3, DateTime.Now.ToString());
				Function.form.control.Invoke_ListView_SubItem_Color(lstNew, citem.lstItem, Color.Red);
			}

		}


		private int NewListCompByArray(clsItem citem, ArrayList alst, string header, int iDelRowCountMax)
		{
			DataTable dt = db.NewList_Get(citem.Name);

			string name;
			int cnt = 0;
			DataRow[] rows;

			foreach (object n in alst)
			{
				name = "";

				//헤더가 같아야 심볼
				if (header == string.Empty || n.ToString().StartsWith(header))
				{
					if (header != string.Empty)
						name = n.ToString().Substring(header.Length);
					else
						name = n.ToString();

					//테스트용 처리 예외 
					//if (name.StartsWith("Z")) continue;

					rows = dt.Select(string.Format("I_Name = '{0}'", name));

					if(rows.Length < 1)
					{   //신규 심볼
						//db에 저장
						db.NewList_Add(citem.Name, name);
						//로그 및 메시지
						NewSymbol_Changed(citem, name, enSymbol_Ch_Type.Add);
					}
					else if(rows.Length > 0)
					{
						//확인 여부 체크
						rows[0]["IsChk"] = 1;
					}				

					cnt++;
				}

			}

			//삭제 여부 확인
			rows = dt.Select("IsChk = 0");

			string log = "";

			foreach(DataRow r in rows)
			{
				name = Fnc.obj2String(r["i_name"]);

				if (rows.Length > iDelRowCountMax)
				{   //한번에 지정 건수이상 삭제되는 경우는 에러로 처리 한다.
					log = Fnc.StringAdd(log, name, ",");
				}
				else
				{					
					//db에서 삭제
					db.NewList_Del(citem.Name, name);
					//로그 및 메시지
					NewSymbol_Changed(citem, name, enSymbol_Ch_Type.Del);
				}
			}

			if (rows.Length > iDelRowCountMax)
			{
				string l = string.Format("삭제처리1회 최대치 초과[Site]{0}[삭제처리 {1}건]/[Max {2}건]", citem.Name, rows.Length, iDelRowCountMax);
				TelegramMsgSend("Error", l );
				log_add(l);
				clsLog.WLog("[Site]{0}[삭제처리1회 최대치 초과 {1}건/Max {3}건]{2}", citem.Name, rows.Length, log, iDelRowCountMax);
			}


			return cnt;
		}



		private int NewListCompByTreeNode(clsItem citem, TreeNode tn, string node_name, enTN_Symbol tn_symbol, string header, int iDelRowCountMax)
		{
			DataTable dt = db.NewList_Get(citem.Name);

			string name;
			int cnt = 0;
			DataRow[] rows;

			foreach (TreeNode n in tn.Nodes)
			{
				//노드 이름 체크 
				if (node_name != string.Empty && node_name != n.Name) continue;					

				if (tn_symbol == enTN_Symbol.Name)
					name = n.Name;
				else
					name = n.Text;

				//헤더가 같아야 심볼
				if (header == string.Empty || n.ToString().StartsWith(header))
				{
					if (header != string.Empty)
						name = name.Substring(header.Length);
					
					//테스트용 처리 예외 
					//if (name.StartsWith("Z")) continue;

					rows = dt.Select(string.Format("I_Name = '{0}'", name));

					if (rows.Length < 1)
					{   //신규 심볼
						//db에 저장
						db.NewList_Add(citem.Name, name);
						//로그 및 메시지
						NewSymbol_Changed(citem, name, enSymbol_Ch_Type.Add);
					}
					else if (rows.Length > 0)
					{
						//확인 여부 체크
						rows[0]["IsChk"] = 1;
					}

					cnt++;
				}

			}

			//삭제 여부 확인
			rows = dt.Select("IsChk = 0");

			string log = "";

			foreach (DataRow r in rows)
			{
				name = Fnc.obj2String(r["i_name"]);

				if (rows.Length > iDelRowCountMax)
				{   //한번에 지정 건수이상 삭제되는 경우는 에러로 처리 한다.
					log = Fnc.StringAdd(log, name, ",");
				}
				else
				{
					//db에서 삭제
					db.NewList_Del(citem.Name, name);
					//로그 및 메시지
					NewSymbol_Changed(citem, name, enSymbol_Ch_Type.Del);
				}
			}

			if (rows.Length > iDelRowCountMax)
			{
				string l = string.Format("삭제처리1회 최대치 초과[Site]{0}[삭제처리 {1}건]/[Max {2}건]", citem.Name, rows.Length, iDelRowCountMax);
				TelegramMsgSend("Error", l);
				log_add(l);
				clsLog.WLog("[Site]{0}[삭제처리1회 최대치 초과 {1}건/Max {3}건]{2}", citem.Name, rows.Length, log, iDelRowCountMax);
			}


			return cnt;
		}



		private void NewSymbol_Changed(clsItem item, string symbolname, enSymbol_Ch_Type chType)
		{
			string log;
			string mtype;

			if (item.iRunCnt == 0)
			{
				log = "[첫실행후바로]";
				mtype = "Admin";
			}
			else
			{
				log = "";
				mtype = "NewLists";
			}
			
			switch(item.Idx)
			{
				case 0:     //심볼 추가확인
				case 1:
				case 2:
				case 3:
				case 4:
					if(chType == enSymbol_Ch_Type.Add)
						log += string.Format("[{0}]{1} 심볼 추가 확인", item.Name, symbolname);
					else
						log += string.Format("[{0}]{1} 심볼이 삭제 되었습니다.", item.Name, symbolname);
					break;


				default:
					throw new Exception(string.Format("신규 심볼 처리 미등록 [{0}]{1}", item.Name, symbolname));
					break;
					
			}			

			TelegramMsgSend(mtype, log);
			log_add(log);
		}

		private void Notice_Add(clsItem item, string url,string title)
		{
			string log;
			string mtype;

			if (item.iRunCnt == 0)
			{
				log = "[첫실행후바로]";
				mtype = "Admin";
			}
			else
			{
				log = "";
				mtype = "NewNotice";
			}

			switch (item.Idx)
			{
				case 5:     //공지 전송
				case 6:					
						log += string.Format("[신규{0}]{1} \r\n{2}", item.Name, title, url);
					break;

				default:
					throw new Exception(string.Format("신규 공지 처리 미등록 [{0}]{1} \r\n", item.Name, title, url));
					break;

			}

			TelegramMsgSend(mtype, log);
			log_add(log);
		}


		private delegate void dellog_add(string log);

		private void log_add(string log)
		{
			if(lstLog.InvokeRequired)
			{
				lstLog.Invoke(new dellog_add(log_add), new object[] { log });
				return;
			}

			int log_max_cnt = 100;

			ListViewItem item = new ListViewItem(new string[] { "", Fnc.Date2String(DateTime.Now, Fnc.enDateType.DateTime),  log });
			lstLog.Items.Insert(0, item);

			while(lstLog.Items.Count > log_max_cnt)
			{
				lstLog.Items.RemoveAt(lstLog.Items.Count - 1);
			}

		}


        private void thChkAlive(object obj)
        {
            try
            {
                string msg;

                if (iChkCnt == 0)
                {
                    msg = "NewLists 프로그램이 시작 되었음.";
                    iChkCnt = 1;
                }
                else
                    msg = "NewLists 프로그램이 동작중.....";


                TelegramMsgSend("Error", msg);
            }
            catch (Exception ex)
            {
                ProcException(ex, "thChkAlive", false);
            }
        }


        public async void TelegramMsgSend(string mType, string msg)
        {

            try
            {
                DataTable dt = db.ChatID_Get(mType);

#if (!DEBUG)
                await _client.Connect();

                if (!_client.isAuth())
                {

                    SetMessage(true, "메시지 전송 실패-인증필요.", false);
                    return;
                }
#endif

                foreach (DataRow dr in dt.Rows)
                {
#if (!DEBUG)
                    await _client.SendMessageToChat(enChatsInfoType.id, Fnc.obj2String(dr["ChatID"]), msg);
					cTelLg.WLog("[Mtype]{0}[ChatID{1}:{2}]{3}",mType, dr["chatid"], dr["desc"], msg);
#else
					cTelLg.WLog("미전송[Mtype]{0}[ChatID{1}:{2}]{3}",mType, dr["chatid"], dr["desc"], msg);
#endif
                }
            }
            catch(Exception ex)
            {
                ProcException(ex, "TelegramMsgSend");
            }

        }



        private void frmNewLists_Load(object sender, EventArgs e)
		{
#if (DEBUG)
			this.Text += "[DEBUG]";
#endif
			this.Text += " v." + Application.ProductVersion;


            //텔레그램 전송 로그            
            cTelLg = new Function.Util.Log(vari.pgm_path + "\\LOG", "TEL_SEND_LOG", 30, true);



            vari.Setting.Group_Select("PGM");
            //설정된 전화번호 가져오기
            vari.HP = vari.Setting.Value_Get("PGM", "HP", "");
            inpHP.Value = vari.HP;

            //텔래그램 연결
            btnHPConn_Click(null, null);


            sItems =  new string[] {
                "Binance"						//0
                ,"Bithumb"						//1
                ,"BinanceWallet"				//2
				,"Upbit"						//3
				,"bittrex(미동작)"				//4
				,"Upbit공지(미동작)"			//5
				,"Bithumb공지"					//6
			}; 
            sUrls = new string[]
            {
                "https://www.binance.com/api/v1/ticker/allPrices"									//바이낸스 가격
                ,"https://api.bithumb.com/public/ticker/all"										//빗썸
                ,"https://www.binance.com/assetWithdraw/getAllAsset.html"							//바이낸스 지갑
				,"https://crix-api.upbit.com/v1/crix/trends/change_rate"							//upbit 가격
				,"https://bittrex.com/api/v1.1/public/getmarketsummaries"							//비트렉스 가격
				,"https://api-manager.upbit.com/api/v1/notices?page=1&per_page=10"					//업비트 공지
				,"https://bithumb.cafe/notice"														//빗썸공지
				,"https://api.huobi.co.kr/v1/notice/list?language=ko-KR&limit=10&currPage=1"		//후오비코리아 공지
			};

			cItems = new clsItem[sItems.Length];
			tmrWork = new System.Threading.Timer[cItems.Length];

			int idx = 0;

			foreach (string item in sItems)
			{
				cItems[idx] = new clsItem(idx, item, sUrls[idx]);
				cItems[idx].lstItem = new ListViewItem(new string[] { "", item, "0", "" });

				lstNew.Items.Add(cItems[idx].lstItem);

#if (!no_tmr)
				switch(idx)
				{
					case 0:
						tmrWork[idx] = new System.Threading.Timer(new TimerCallback(thBinance), cItems[idx], 1000, 5000);
						break;

					case 1:
						tmrWork[idx] = new System.Threading.Timer(new TimerCallback(thBithumb), cItems[idx], 1000, 5000);
						break;

					case 2:
						tmrWork[idx] = new System.Threading.Timer(new TimerCallback(thBinanceWallet), cItems[idx], 1000, 5000);
						break;

					case 3:
						tmrWork[idx] = new System.Threading.Timer(new TimerCallback(thUpbit), cItems[idx], 1000, 9000);
						break;

					case 6:
						tmrWork[idx] = new System.Threading.Timer(new TimerCallback(thBithumbNotice), cItems[idx], 1000, 5000);
						break;

				}

#endif

				idx++;
			}


            //60분간격으로 문자 보냄
            tmrChkAlive = new System.Threading.Timer(new TimerCallback(thChkAlive), null, 1000, 1000 * 60 * 60);



        }

		private void button1_Click(object sender, EventArgs e)
		{
			int idx;
            ParameterizedThreadStart parm = null;
            idx = 6;

            switch(idx)
            {
                case 0:     //바이낸스 가격
					parm = new ParameterizedThreadStart(thBinance);
					break;

                case 1:     //빗썸 가격
					parm = new ParameterizedThreadStart(thBithumb);
					break;

                case 2:     //바이낸스 지갑
					parm = new ParameterizedThreadStart(thBinanceWallet);
					break;

                case 3:     //upbit
					parm = new ParameterizedThreadStart(thUpbit);
					break;

                case 4:
                    break;

				case 5:     //upbit 공지
					parm = new ParameterizedThreadStart(thUpbitNotice);
					break;

				case 6:     //빗썸 공지
					parm = new ParameterizedThreadStart(thBithumbNotice);
					break;


			}



			Thread th = new Thread(parm);		
			th.Start(cItems[idx]);

		}

        /// <summary>
        /// 휴대폰번호 변경 체크
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inpHP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //설정된 전화번호 저장
                vari.HP = inpHP.Text;
                inpHP.Value = vari.HP;

                vari.Setting.Value_Set("PGM", "HP", vari.HP, "", "", "");

                vari.Setting.Setting_Save();
                
            }
        }

        private async void btnHPConn_Click(object sender, EventArgs e)
        {
            try
            {
#if (!DEBUG)
                if(vari.HP.Trim() == string.Empty)
                {
                    lblHPMsg.Text = "전화번호를 입력 하여 주십시요.";
                    return;
                }

                _client = new Client(vari.HP, vari.apiId, vari.apiHash, this);

                await _client.Connect();

                if (_client.isAuth())
                {
                    lblHPMsg.Text = "연결이 되었습니다.";
                }
                else
                    lblHPMsg.Text = "연결이 되었습니다. 인증이 필요 합니다.";
#else
                lblHPMsg.Text = "디버그에서는 텔래그램을 연결하지 안습니다..";
#endif
            }
            catch (Exception ex)
            {
                ProcException(ex, "btnHPConn_Click", false);
            }
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (_client.AuthFormOpen())
                {
                    lblHPMsg.Text = "인증이 완료 되었습니다.";                    
                }
                else
                    lblHPMsg.Text = "인증이 완료 되었습니다.";               

            }
            catch (Exception ex)
            {
                ProcException(ex, "btnPCAuth_Click", false);
            }
        }

        private async void btnHPTest_Click(object sender, EventArgs e)
        {
            try
            {
                vari.TestCnt++;
                string msg = string.Format("테스트 메시지 전송 {0}번", vari.TestCnt);

                //await _client.SendMessageToChat(enChatsInfoType.id, "1373476627", msg);
                TelegramMsgSend("Admin", msg);

                lblHPMsg.Text = "메시지전송:" + msg;
            }
            catch (Exception ex)
            {
                ProcException(ex, "btnPCAuth_Click", false);
            }
        }

		private async void btnHPReConn_Click(object sender, EventArgs e)
		{

			try
			{
#if (!DEBUG)
				if (vari.HP.Trim() == string.Empty)
				{
					lblHPMsg.Text = "전화번호를 입력 하여 주십시요.";
					return;
				}

				_client = new Client(vari.HP, vari.apiId, vari.apiHash, this);

				await _client.Connect(true);

				if (_client.isAuth())
				{
					lblHPMsg.Text = "연결이 되었습니다.";
				}
				else
					lblHPMsg.Text = "연결이 되었습니다. 인증이 필요 합니다.";
#else
                lblHPMsg.Text = "디버그에서는 텔래그램을 연결하지 안습니다..";
#endif
			}
			catch (Exception ex)
			{
				ProcException(ex, "btnHPConn_Click", false);
			}
		}
	}
}

