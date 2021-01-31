﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SalonApp
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            if (Session["StaffID"] == null)
            {
                //ユーザー認証がされていないので[ログオン]に戻る
                Response.Redirect("Logon.aspx");
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //このWebページをキャッシュしないように設定
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        //編集ボタン　カード型ビューにリンク
        {
            Response.Redirect("CustomerCard.aspx");
        }

        protected void FilterButton_Click(object sender, EventArgs e)
        {
            //検索ボタン実行処理
            //SQLステートメントの定義
//            string queryString = "SELECT tbl_customer" +
 //               " (staff_id, staff_name, user_id, password, admin_flag)" +
//                " VALUES (" + newStaffID + ",'（新規）', '', '', 0)";

            try
            {
                //接続文字列の取得
  //              string connectionString = System.Configuration.ConfigurationManager.
   //                 ConnectionStrings["SalonDBConnectionString"].ConnectionString;
                //コネクションの定義
  //              using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //コマンドの定義
  //                  SqlCommand command = new SqlCommand(queryString, connection);
                    //コネクションを開く
  //                  connection.Open();
                    //SQLステートメントの実行
  //                  command.ExecuteNonQuery();
                    //データの読み直し
  //                  GridView1.DataBind();

                }
            }
            catch (Exception)
            {
                MessageLabel.Text = "該当するデータがありません。条件を変えて検索してください。";
            }
        }
        protected void FilterCancel_Click(object sender, EventArgs e)
        {
            //一覧に戻るボタン実行処理
        }
    }
}