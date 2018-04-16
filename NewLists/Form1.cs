
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NewLists
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string url = "https://api.bithumb.com/public/ticker/all";
			url = "https://www.binance.com/api/v1/ticker/allPrices";

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

			//요청전송
			//using (StreamWriter writer = new StreamWriter(req.GetRequestStream()))
			//{
			//	writer.Write(sendData);
			//	writer.Close();
			//}

			string html = "";
			////요청결과
			HttpWebResponse rst = (HttpWebResponse)req.GetResponse();

			if (rst.StatusCode == HttpStatusCode.OK)
			{
				Stream st = rst.GetResponseStream();
				StreamReader sr = new StreamReader(st, Encoding.GetEncoding("euc-kr"));

				html = sr.ReadToEnd(); //Encoding.Default.GetString(st.re)
			}

			html = html.Replace("[", "");
			html = html.Replace("]", "");

			TreeNode node = Function.json.jsonParse.String2TreeNode(html);

			foreach (TreeNode n in node.Nodes)
			{
				if(n.Name == "symbol")
				{
					Console.WriteLine(n.Text);
				}
			}

		}






		private void button2_Click(object sender, EventArgs e)
		{
			string json = @"{""status"":""0000"",""data"":{""BTC"":{""opening_price"":""7403000"",""closing_price"":""7358000"",""min_price"":""7350000"",""max_price"":""7490000"",""average_price"":""7400987.1113"",""units_traded"":""10311.17630968"",""volume_1day"":""10311.17630968"",""volume_7day"":""73369.67268667"",""buy_price"":""7358000"",""sell_price"":""7360000""},""ETH"":{""opening_price"":""449000"",""closing_price"":""457000"",""min_price"":""443500"",""max_price"":""462000"",""average_price"":""451774.3198"",""units_traded"":""78129.556484738808084476"",""volume_1day"":""78129.556484738808084476"",""volume_7day"":""469486.235747089716123520"",""buy_price"":""457000"",""sell_price"":""457500""},""DASH"":{""opening_price"":""321500"",""closing_price"":""328500"",""min_price"":""317000"",""max_price"":""332000"",""average_price"":""325264.1545"",""units_traded"":""2322.2898414"",""volume_1day"":""2322.2898414"",""volume_7day"":""11971.236463410000000000"",""buy_price"":""327000"",""sell_price"":""328500""},""LTC"":{""opening_price"":""123100"",""closing_price"":""123500"",""min_price"":""121200"",""max_price"":""127900"",""average_price"":""123538.2859"",""units_traded"":""33209.23782372"",""volume_1day"":""33209.23782372"",""volume_7day"":""133723.958084610000000000"",""buy_price"":""123400"",""sell_price"":""123500""},""ETC"":{""opening_price"":""14800"",""closing_price"":""15150"",""min_price"":""14650"",""max_price"":""15600"",""average_price"":""15042.6332"",""units_traded"":""523466.885814655063335253"",""volume_1day"":""523466.885814655063335253"",""volume_7day"":""2117088.620766100781073632"",""buy_price"":""15160"",""sell_price"":""15200""},""XRP"":{""opening_price"":""529"",""closing_price"":""554"",""min_price"":""525"",""max_price"":""596"",""average_price"":""550.6049"",""units_traded"":""190494083.217993"",""volume_1day"":""190494083.217993"",""volume_7day"":""838577599.919557000000000000"",""buy_price"":""554"",""sell_price"":""555""},""BCH"":{""opening_price"":""710000"",""closing_price"":""705000"",""min_price"":""694000"",""max_price"":""725000"",""average_price"":""704022.3791"",""units_traded"":""7299.61378652"",""volume_1day"":""7299.61378652"",""volume_7day"":""35705.215993990000000000"",""buy_price"":""705000"",""sell_price"":""708000""},""XMR"":{""opening_price"":""178700"",""closing_price"":""178600"",""min_price"":""175500"",""max_price"":""182300"",""average_price"":""179132.7792"",""units_traded"":""10993.005267111427"",""volume_1day"":""10993.005267111427"",""volume_7day"":""35670.892379272144000000"",""buy_price"":""178600"",""sell_price"":""180000""},""ZEC"":{""opening_price"":""194400"",""closing_price"":""196900"",""min_price"":""192000"",""max_price"":""200000"",""average_price"":""195857.5127"",""units_traded"":""2659.75959022"",""volume_1day"":""2659.75959022"",""volume_7day"":""11608.493250620000000000"",""buy_price"":""196400"",""sell_price"":""196900""},""QTUM"":{""opening_price"":""14530"",""closing_price"":""14920"",""min_price"":""14370"",""max_price"":""15400"",""average_price"":""14873.2415"",""units_traded"":""982739.11063802"",""volume_1day"":""982739.11063802"",""volume_7day"":""4864840.879716510000000000"",""buy_price"":""14910"",""sell_price"":""14920""},""BTG"":{""opening_price"":""44000"",""closing_price"":""45100"",""min_price"":""43750"",""max_price"":""45900"",""average_price"":""44643.2872"",""units_traded"":""60604.06768123"",""volume_1day"":""60604.06768123"",""volume_7day"":""288321.026707700000000000"",""buy_price"":""45000"",""sell_price"":""45100""},""EOS"":{""opening_price"":""6465"",""closing_price"":""8940"",""min_price"":""6445"",""max_price"":""9495"",""average_price"":""7944.5045"",""units_traded"":""59672035.41647207887647037"",""volume_1day"":""59672035.41647207887647037"",""volume_7day"":""126387045.433314503803976313"",""buy_price"":""8935"",""sell_price"":""8940""},""ICX"":{""opening_price"":""2170"",""closing_price"":""2137"",""min_price"":""2101"",""max_price"":""2260"",""average_price"":""2186.9311"",""units_traded"":""8611916.36683216122915"",""volume_1day"":""8611916.36683216122915"",""volume_7day"":""43410864.791584552498660000"",""buy_price"":""2135"",""sell_price"":""2137""},""VEN"":{""opening_price"":""2827"",""closing_price"":""2650"",""min_price"":""2566"",""max_price"":""2845"",""average_price"":""2728.8307"",""units_traded"":""3853102.95995587921786"",""volume_1day"":""3853102.95995587921786"",""volume_7day"":""18170863.312561603203500000"",""buy_price"":""2650"",""sell_price"":""2651""},""TRX"":{""opening_price"":""39"",""closing_price"":""39"",""min_price"":""38"",""max_price"":""40"",""average_price"":""38.5937"",""units_traded"":""256085026.838303"",""volume_1day"":""256085026.838303"",""volume_7day"":""1517100846.691251000000000000"",""buy_price"":""38"",""sell_price"":""39""},""date"":""1523497219097""}}";

			TreeNode node = Function.json.jsonParse.String2TreeNode(json);


			foreach(TreeNode n in node.Nodes) //node.Nodes["status"].Nodes)
			{
				Console.WriteLine("{0}:{1}", n.Name, n.Text);
			}

		}
	}
}
