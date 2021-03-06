﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapChat
{
    class ViewLayer
    {
        //
        BusinessLayer bsl = new BusinessLayer();

        public ViewLayer()
        {
            BusinessLayer bsl = new BusinessLayer();
        }
        //Sự kiện bấm vào nút đăng nhập
        internal int clickDangNhap(System.Windows.Forms.TextBox txtuser, System.Windows.Forms.TextBox txtpass)
        {
            int id = bsl.testDangNhap(txtuser, txtpass);
            return id;
        }
        //load giao diện
        internal void loadGiaoDien(int ID, System.Windows.Forms.ListView listViewdanhsach)
        {
            //Load danh sách bạn bè
            bsl.loadListViewChat(ID + "", listViewdanhsach);
            //Bật user đang chat
            bsl.isState("true", ID+"");
        }

        //load lại danh sách các bạn chat xem ai đang online
        internal void updateForm(int ID, System.Windows.Forms.ListView listViewdanhsach)
        {
            bsl.loadListViewChat(ID + "", listViewdanhsach);
        }

        //Đóng giao diện
        internal void closeGiaoDien(int Id_user)
        {
            //tắt chat
            bsl.isState("False", Id_user + "");
        }

        internal void clicksendMessage(int id_user, string p, System.Windows.Forms.TextBox txt_tinnhan, System.Windows.Forms.ListView listView_khungchat)
        {
            bool t = bsl.saveDataOfMess(id_user, p, txt_tinnhan.Text);
            if (t)
            {
                String mess = "Me: " + txt_tinnhan.Text.ToString();
                txt_tinnhan.Text = "";
                listView_khungchat.Items.Add(mess);
            }
            else
            {
                String mess = "Error";
                listView_khungchat.Items.Add(mess);
            }
        }


        //Lấy tên User từ ID
        internal string setUser(int Id_user)
        {
            return bsl.svcl.findUsernamefromID(Id_user);
        }
        //load các tin nhắn
        internal void loadMessage(int id_user, System.Windows.Forms.Label lb_Sender, System.Windows.Forms.ListView listView_khungchat)
        {
            bsl.loadallMessage(id_user + "", lb_Sender, listView_khungchat);
        }

        internal void loadnewMessage(int id_user, System.Windows.Forms.Label lb_Sender, System.Windows.Forms.ListView listView_khungchat)
        {
            bsl.loadnewMessage(id_user + "", lb_Sender, listView_khungchat);
        }

        internal bool clickDangKi(System.Windows.Forms.TextBox txt_username, System.Windows.Forms.TextBox txt_pas, System.Windows.Forms.TextBox txt_re, System.Windows.Forms.TextBox txt_email)
        {
            return bsl.testDangKi(txt_username, txt_pas, txt_re, txt_email);
        }



        internal bool clickdelete_message(int id_user, System.Windows.Forms.Label lb_Sender, System.Windows.Forms.ListView listView_khungchat)
        {
            int id_sender = (int)bsl.svcl.findIDfromUsername(lb_Sender.Text);
            return bsl.svcl.deleteMessage(id_user, id_sender);
        }

        internal bool clickAdd(int id1, String name_id2)
        {
            int id2 = bsl.svcl.findIDfromUsername(name_id2);
            if(id2!=0)
                return bsl.function_Process("addFriend", id1, id2);
            return false;
        }

        internal bool clickDeleteFriend(int Id_user, string s)
        {
            int id2 = bsl.svcl.findIDfromUsername(s);
            if (id2 != 0)
                return bsl.function_Process("deleteFriend", Id_user, id2);
            return false;
        }

        internal bool clickDeleteAccount(int Id_user)
        {
            return bsl.function_Process("deleteAccount", Id_user, -1);
        }

        internal bool ClickFunction(String s1, int i1, String s)
        {
            int i2 = bsl.svcl.findIDfromUsername(s);
            return bsl.function_Process(s1, i1, i2);
        }
    }
}
