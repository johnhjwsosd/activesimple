/**  版本信息模板在安装目录下，可自行修改。
* dt_users.cs
*
* 功 能： N/A
* 类 名： dt_users
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/3/19 16:52:37   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace DAL
{
	/// <summary>
	/// 数据访问类:dt_users
	/// </summary>
	public partial class dt_users
	{
		public dt_users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "dt_users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from dt_users");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add( Model.dt_users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dt_users(");
			strSql.Append("group_id,user_name,salt,password,mobile,email,avatar,nick_name,sex,birthday,telphone,area,address,qq,msn,amount,point,exp,status,reg_time,reg_ip)");
			strSql.Append(" values (");
			strSql.Append("@group_id,@user_name,@salt,@password,@mobile,@email,@avatar,@nick_name,@sex,@birthday,@telphone,@area,@address,@qq,@msn,@amount,@point,@exp,@status,@reg_time,@reg_ip)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@group_id", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@salt", SqlDbType.NVarChar,20),
					new SqlParameter("@password", SqlDbType.NVarChar,100),
					new SqlParameter("@mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@email", SqlDbType.NVarChar,50),
					new SqlParameter("@avatar", SqlDbType.NVarChar,255),
					new SqlParameter("@nick_name", SqlDbType.NVarChar,100),
					new SqlParameter("@sex", SqlDbType.NVarChar,20),
					new SqlParameter("@birthday", SqlDbType.DateTime),
					new SqlParameter("@telphone", SqlDbType.NVarChar,50),
					new SqlParameter("@area", SqlDbType.NVarChar,255),
					new SqlParameter("@address", SqlDbType.NVarChar,255),
					new SqlParameter("@qq", SqlDbType.NVarChar,20),
					new SqlParameter("@msn", SqlDbType.NVarChar,100),
					new SqlParameter("@amount", SqlDbType.Decimal,5),
					new SqlParameter("@point", SqlDbType.Int,4),
					new SqlParameter("@exp", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.TinyInt,1),
					new SqlParameter("@reg_time", SqlDbType.DateTime),
					new SqlParameter("@reg_ip", SqlDbType.NVarChar,20)};
			parameters[0].Value = model.group_id;
			parameters[1].Value = model.user_name;
			parameters[2].Value = model.salt;
			parameters[3].Value = model.password;
			parameters[4].Value = model.mobile;
			parameters[5].Value = model.email;
			parameters[6].Value = model.avatar;
			parameters[7].Value = model.nick_name;
			parameters[8].Value = model.sex;
			parameters[9].Value = model.birthday;
			parameters[10].Value = model.telphone;
			parameters[11].Value = model.area;
			parameters[12].Value = model.address;
			parameters[13].Value = model.qq;
			parameters[14].Value = model.msn;
			parameters[15].Value = model.amount;
			parameters[16].Value = model.point;
			parameters[17].Value = model.exp;
			parameters[18].Value = model.status;
			parameters[19].Value = model.reg_time;
			parameters[20].Value = model.reg_ip;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update( Model.dt_users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dt_users set ");
			strSql.Append("group_id=@group_id,");
			strSql.Append("user_name=@user_name,");
			strSql.Append("salt=@salt,");
			strSql.Append("password=@password,");
			strSql.Append("mobile=@mobile,");
			strSql.Append("email=@email,");
			strSql.Append("avatar=@avatar,");
			strSql.Append("nick_name=@nick_name,");
			strSql.Append("sex=@sex,");
			strSql.Append("birthday=@birthday,");
			strSql.Append("telphone=@telphone,");
			strSql.Append("area=@area,");
			strSql.Append("address=@address,");
			strSql.Append("qq=@qq,");
			strSql.Append("msn=@msn,");
			strSql.Append("amount=@amount,");
			strSql.Append("point=@point,");
			strSql.Append("exp=@exp,");
			strSql.Append("status=@status,");
			strSql.Append("reg_time=@reg_time,");
			strSql.Append("reg_ip=@reg_ip");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@group_id", SqlDbType.Int,4),
					new SqlParameter("@user_name", SqlDbType.NVarChar,100),
					new SqlParameter("@salt", SqlDbType.NVarChar,20),
					new SqlParameter("@password", SqlDbType.NVarChar,100),
					new SqlParameter("@mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@email", SqlDbType.NVarChar,50),
					new SqlParameter("@avatar", SqlDbType.NVarChar,255),
					new SqlParameter("@nick_name", SqlDbType.NVarChar,100),
					new SqlParameter("@sex", SqlDbType.NVarChar,20),
					new SqlParameter("@birthday", SqlDbType.DateTime),
					new SqlParameter("@telphone", SqlDbType.NVarChar,50),
					new SqlParameter("@area", SqlDbType.NVarChar,255),
					new SqlParameter("@address", SqlDbType.NVarChar,255),
					new SqlParameter("@qq", SqlDbType.NVarChar,20),
					new SqlParameter("@msn", SqlDbType.NVarChar,100),
					new SqlParameter("@amount", SqlDbType.Decimal,5),
					new SqlParameter("@point", SqlDbType.Int,4),
					new SqlParameter("@exp", SqlDbType.Int,4),
					new SqlParameter("@status", SqlDbType.TinyInt,1),
					new SqlParameter("@reg_time", SqlDbType.DateTime),
					new SqlParameter("@reg_ip", SqlDbType.NVarChar,20),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.group_id;
			parameters[1].Value = model.user_name;
			parameters[2].Value = model.salt;
			parameters[3].Value = model.password;
			parameters[4].Value = model.mobile;
			parameters[5].Value = model.email;
			parameters[6].Value = model.avatar;
			parameters[7].Value = model.nick_name;
			parameters[8].Value = model.sex;
			parameters[9].Value = model.birthday;
			parameters[10].Value = model.telphone;
			parameters[11].Value = model.area;
			parameters[12].Value = model.address;
			parameters[13].Value = model.qq;
			parameters[14].Value = model.msn;
			parameters[15].Value = model.amount;
			parameters[16].Value = model.point;
			parameters[17].Value = model.exp;
			parameters[18].Value = model.status;
			parameters[19].Value = model.reg_time;
			parameters[20].Value = model.reg_ip;
			parameters[21].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dt_users ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from dt_users ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public  Model.dt_users GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,group_id,user_name,salt,password,mobile,email,avatar,nick_name,sex,birthday,telphone,area,address,qq,msn,amount,point,exp,status,reg_time,reg_ip from dt_users ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			 Model.dt_users model=new  Model.dt_users();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public  Model.dt_users DataRowToModel(DataRow row)
		{
			 Model.dt_users model=new  Model.dt_users();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["group_id"]!=null && row["group_id"].ToString()!="")
				{
					model.group_id=int.Parse(row["group_id"].ToString());
				}
				if(row["user_name"]!=null)
				{
					model.user_name=row["user_name"].ToString();
				}
				if(row["salt"]!=null)
				{
					model.salt=row["salt"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["mobile"]!=null)
				{
					model.mobile=row["mobile"].ToString();
				}
				if(row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["avatar"]!=null)
				{
					model.avatar=row["avatar"].ToString();
				}
				if(row["nick_name"]!=null)
				{
					model.nick_name=row["nick_name"].ToString();
				}
				if(row["sex"]!=null)
				{
					model.sex=row["sex"].ToString();
				}
				if(row["birthday"]!=null && row["birthday"].ToString()!="")
				{
					model.birthday=DateTime.Parse(row["birthday"].ToString());
				}
				if(row["telphone"]!=null)
				{
					model.telphone=row["telphone"].ToString();
				}
				if(row["area"]!=null)
				{
					model.area=row["area"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["qq"]!=null)
				{
					model.qq=row["qq"].ToString();
				}
				if(row["msn"]!=null)
				{
					model.msn=row["msn"].ToString();
				}
				if(row["amount"]!=null && row["amount"].ToString()!="")
				{
					model.amount=decimal.Parse(row["amount"].ToString());
				}
				if(row["point"]!=null && row["point"].ToString()!="")
				{
					model.point=int.Parse(row["point"].ToString());
				}
				if(row["exp"]!=null && row["exp"].ToString()!="")
				{
					model.exp=int.Parse(row["exp"].ToString());
				}
				if(row["status"]!=null && row["status"].ToString()!="")
				{
					model.status=int.Parse(row["status"].ToString());
				}
				if(row["reg_time"]!=null && row["reg_time"].ToString()!="")
				{
					model.reg_time=DateTime.Parse(row["reg_time"].ToString());
				}
				if(row["reg_ip"]!=null)
				{
					model.reg_ip=row["reg_ip"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,group_id,user_name,salt,password,mobile,email,avatar,nick_name,sex,birthday,telphone,area,address,qq,msn,amount,point,exp,status,reg_time,reg_ip ");
			strSql.Append(" FROM dt_users ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,group_id,user_name,salt,password,mobile,email,avatar,nick_name,sex,birthday,telphone,area,address,qq,msn,amount,point,exp,status,reg_time,reg_ip ");
			strSql.Append(" FROM dt_users ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM dt_users ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from dt_users T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "dt_users";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

