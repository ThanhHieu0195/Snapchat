﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DataChat
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        //Biến kết nối
        private String connect;

        public String Connect1
        {
            get { return connect; }
            set { connect = value; }
        }
        private SqlConnection cnt;

        public SqlConnection Cnt
        {
            get { return cnt; }
            set { cnt = value; }
        }
        private SqlDataAdapter da;

        public SqlDataAdapter Da
        {
            get { return da; }
            set { da = value; }
        }
        private DataSet ds;

        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        public String Connect
        {
            get { return Connect1; }
            set { Connect1 = value; }
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        //Kết nối CSDL
        public void connectData()
        {
            Connect = System.Configuration.ConfigurationSettings.AppSettings["connectstring"];
            Cnt = new SqlConnection();
            Cnt.ConnectionString = Connect;
        }
        //Load tất cả dữ liệu bản Users
        [WebMethod]
        public DataSet loadAllData()
        {
            Connect = System.Configuration.ConfigurationSettings.AppSettings["connectstring"];
            Cnt = new SqlConnection();
            Ds = new DataSet();
            Cnt.ConnectionString = Connect;
            Da = new SqlDataAdapter("select* from Users", Cnt);
            Da.Fill(Ds);
            return Ds;
        }
        //Load dữ liệu từ bản table
        [WebMethod]
        public DataSet loadDatafromTable(String table, String queue)
        {
            connectData();
            Ds = new DataSet();
            if (queue == "")
                Da = new SqlDataAdapter("select* from " + table, Cnt);
            else
                Da = new SqlDataAdapter("select* from " + table + " where " + queue, Cnt);

            Da.Fill(Ds);
            return Ds;
        }
        //Thay đổi trang thái online của người dùng
        [WebMethod]
        public bool changeStateUser(String state, String id)
        {
            connectData();
            Cnt.Open();
            String t = "UPDATE Users set State='" + state + "' where IDUser='" + id + "'";
            SqlCommand cmn = new SqlCommand();
            cmn.Connection = Cnt;
            cmn.CommandType = CommandType.Text;
            cmn.CommandText = t;
            cmn.ExecuteNonQuery();
            Cnt.Close();
            return true;
        }
        [WebMethod]
        public bool changeStateMess(String state, String id1, String id2, String dt)
        {
            connectData();
            Cnt.Open();
            String t = "UPDATE Message set State='" + state + "' where IDUser=' " + id1 + "' and IDSender = '" + id2 + "' and DateTime = '" + dt + "'";
            SqlCommand cmn = new SqlCommand();
            cmn.Connection = Cnt;
            cmn.CommandType = CommandType.Text;
            cmn.CommandText = t;
            cmn.ExecuteNonQuery();
            Cnt.Close();
            return true;
        }

        [WebMethod]
        public int findIDfromUsername(String s)
        {
            try
            {
                return (int)loadDatafromTable("Users", "Username = '" + s + "'").Tables[0].Rows[0]["IDUser"];
            }
            catch
            {
                return 0;
            }
        }

        [WebMethod]
        public String findUsernamefromID(int ID)
        {
            try
            {
                return (String)loadDatafromTable("Users", "IDUser = " + ID).Tables[0].Rows[0]["Username"];
            }
            catch
            {
                return "";
            }

        }
        //Chèn thêm thêm dữ liệu vào bảng table
        [WebMethod]
        public bool insertUsers(String User, String Pass, String State, String FullName, String Email, String Address)
        {
            try
            {
                //Xử lí dữ liệu:
                User = (User.Length > 0) ? ("" + "'" + User + "'") : "NULL";
                Pass = (Pass.Length > 0) ? ("" + "'" + Pass + "'") : "NULL";
                State = (State.Length > 0) ? ("" + "'" + State + "'") : "NULL";
                FullName = (FullName.Length > 0) ? ("" + "'" + FullName + "'") : "NULL";
                Email = (Email.Length > 0) ? ("" + "'" + Email + "'") : "NULL";
                Address = (Address.Length > 0) ? ("" + "'" + Address + "'") : "NULL";
                
                //
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                int id1 = dt.Day + dt.Month + dt.Year + dt.Hour + dt.Minute + dt.Second;
                String id = "'"+id1+"'";
                if (findIDfromUsername(User) != 0) return false;
                connectData();
                Cnt.Open();
                //Insert Users values('113', 'HieuThanh', '123', 'False', NULL, 'a', NULL)
                String t = "Insert Users values(" + id + "," + User + "," + Pass + "," + State + "," + FullName + "," + Email + "," + Address + ")";
                SqlCommand cmn = new SqlCommand();
                cmn.Connection = Cnt;
                cmn.CommandType = CommandType.Text;
                cmn.CommandText = t.Trim();
                cmn.ExecuteNonQuery();
                Cnt.Close();
                return true;
                //String t = "insert Users values('"  +id +"','" + User + "','" + Pass + "','" + State + "','" + FullName +"','"+Email+"','"+Address +"')";

            }
            catch
            {
                return false;
            }

        }
        [WebMethod]
        public bool deleteMessage(int id1, int id2)
        {
            try
            {

                String t = "Delete from Message where IDSender='" + id2 + "' and IDUser = '" + id1 + "'";
                changeInfomation(t);
                return true;
            }
            catch
            {
                return false;

            }

        }
        //Hàm thay xử lí trên thông tin dưới bộ nhớ
        public void changeInfomation(String queue)
        {
            connectData();
            Cnt.Open();
            String t = queue;
            SqlCommand cmn = new SqlCommand();
            cmn.Connection = Cnt;
            cmn.CommandType = CommandType.Text;
            cmn.CommandText = t;
            cmn.ExecuteNonQuery();
            Cnt.Close();
        }
        //Thêm dữ liệu vào table Message
        [WebMethod]
        public bool insertDatatoMessage(string id_user, string id_sender, DateTime time, string content, String State)
        {
            try
            {
                connectData();
                Cnt.Open();
                String t = "insert Message values('" + id_user + "','" + id_sender + "','" + time + "','" + content + "','" + State + "')";
                SqlCommand cmn = new SqlCommand();
                cmn.Connection = Cnt;
                cmn.CommandType = CommandType.Text;
                cmn.CommandText = t;
                cmn.ExecuteNonQuery();
                Cnt.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        #region Function:
        [WebMethod]
        public bool addFriend(int id1, int id2)
        {
            try
            {
                String t = "Insert FriendList values('" + id2 + "','" + id1 + "')";
                changeInfomation(t);
                return true;
            }
            catch
            {
                return false;
            }


        }
        //xóa tên bạn bè
        [WebMethod]
        public bool deleteFriend(int id1, int id2)
        {
            try
            {
                String t = "Delete from FriendList where IDFriendList = '" + id2 + "' and IDUser = '" + id1+"'";
                changeInfomation(t);
                return true;
            }
            catch
            {
                return false;
            }

        }
        //xóa tài khoản
        [WebMethod]
        public bool deleteAccount(int id1)
        {
            try
            {
                //xóa tất danh sách bạn bè
                String t = "Delete from FriendList where IDUser = '" + id1+"' or IDFriendList = '" +id1+"'";
                changeInfomation(t);
                //xóa thông tin nhắn
                t = "Delete from Message where IDUser = '" + id1+"' or IDSender = '" +id1+"'";
                changeInfomation(t);
                //xóa tài khoản
                t = "Delete from Users where IDUser = '" + id1+"'";
                changeInfomation(t);
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion
    }
}
