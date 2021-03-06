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
        {
            //編集ボタン　カード型ビューにリンク

            //   Response.Redirect("CustomerCard.aspx?customer_id={0}");
        }

        protected void FilterButton_Click(object sender, EventArgs e)
        {

        }
        protected void FilterCancel_Click(object sender, EventArgs e)
        {
            //一覧に戻るボタン実行処理
            CustomerIDTextBox.Text = "";
            CustomerKanaTextBox.Text = "";
            CustomerNameTextBox.Text = "";
            DayBiginTextBox.Text = "";
            DayAffterTextBox.Text = "";
            FilterButton_Click(sender, e);
        }

        protected void CustomerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}