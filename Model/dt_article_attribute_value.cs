/**  版本信息模板在安装目录下，可自行修改。
* dt_article_attribute_value.cs
*
* 功 能： N/A
* 类 名： dt_article_attribute_value
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/3/19 16:52:40   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Model
{
	/// <summary>
	/// 扩展属性表
	/// </summary>
	[Serializable]
	public partial class dt_article_attribute_value
	{
		public dt_article_attribute_value()
		{}
		#region Model
		private int _article_id;
		private string _sub_title;
		private string _source;
		private string _author;
		private string _goods_no;
		private int? _stock_quantity=0;
		private decimal? _market_price=0M;
		private decimal? _sell_price=0M;
		private int? _point=0;
		private string _video_src;
		private string _activity_sources;
		private int? _activity_integral;
		private int? _is_launchs;
		private string _receive_address;
		/// <summary>
		/// 父表ID
		/// </summary>
		public int article_id
		{
			set{ _article_id=value;}
			get{return _article_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sub_title
		{
			set{ _sub_title=value;}
			get{return _sub_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string goods_no
		{
			set{ _goods_no=value;}
			get{return _goods_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? stock_quantity
		{
			set{ _stock_quantity=value;}
			get{return _stock_quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? market_price
		{
			set{ _market_price=value;}
			get{return _market_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? sell_price
		{
			set{ _sell_price=value;}
			get{return _sell_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? point
		{
			set{ _point=value;}
			get{return _point;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string video_src
		{
			set{ _video_src=value;}
			get{return _video_src;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string activity_sources
		{
			set{ _activity_sources=value;}
			get{return _activity_sources;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? activity_integral
		{
			set{ _activity_integral=value;}
			get{return _activity_integral;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? is_launchs
		{
			set{ _is_launchs=value;}
			get{return _is_launchs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string receive_address
		{
			set{ _receive_address=value;}
			get{return _receive_address;}
		}
		#endregion Model

	}
}

