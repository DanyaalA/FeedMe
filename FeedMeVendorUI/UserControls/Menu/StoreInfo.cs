﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedMeVendorUI.UserControls.Menu
{
    public partial class StoreInfo : UserControl
    {
        public StoreInfo()
        {
            InitializeComponent();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StoreInfo_Load(object sender, EventArgs e)
        {
            if (!FeedMeLogic.Server.ServerConnection.Connected)
            {
                return;
            }
            string vendorID = Forms.Authentication.LoginForm.VendorDetails.VendorID.ToString();
            DataTable StoreInfo = FeedMeLogic.Vendor.StoreMenuInfo.GetStoreInfo(vendorID);

            NameTBox.Text = StoreInfo.Rows[0][0].ToString();
            DescrTbox.Text = StoreInfo.Rows[0][1].ToString();
            AddressTbox.Text = StoreInfo.Rows[0][2].ToString();
            EmailTbox.Text = StoreInfo.Rows[0][3].ToString();
            PostCodeTbox.Text = StoreInfo.Rows[0][4].ToString();
            PhoneTbox.Text = StoreInfo.Rows[0][5].ToString();
            RatingTbox.Text = StoreInfo.Rows[0][6].ToString();

        }
    }
}
