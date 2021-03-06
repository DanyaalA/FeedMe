﻿using FeedMeNetworking.Serialization;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FeedMeClient.Forms.Authentication
{
    public partial class Register : FeedMeMainForm
    {
        #region Initializing

        public Register()
        {
            InitializeComponent();
        }

        #endregion Initializing

        #region Methods

        private void UpdateUI()
        {
            //Updates Colour Of Both password Boxes
            PasswordBox.FocusColor = Color.Red;
            PasswordBox.BaseColor = Color.Red;
            PasswordBox.ForeColor = Color.Red;

            ConfirmPasswordBox.FocusColor = Color.Red;
            ConfirmPasswordBox.BaseColor = Color.Red;
            ConfirmPasswordBox.ForeColor = Color.Red;
            if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                PasswordBox.FocusColor = Color.Red;
                PasswordBox.BaseColor = Color.Red;

                ConfirmPasswordBox.FocusColor = Color.Red;
                ConfirmPasswordBox.BaseColor = Color.Red;
            }
        }

        private bool CheckPassword()
        {
            //Checks If both Password   
            if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Passwords Don't Match!");
                return false;
            }
            return true;
        }

        public bool PresenceCheck(string stringToCheck)
        {
            //Checks if the textbox is empty
            if (string.IsNullOrWhiteSpace(stringToCheck))
            {
                return false;
            }
            if (stringToCheck.Contains(" ")) //Checks for any Spaces  as a username should only be one word.
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Sends the Registration Data to the server
        /// </summary>
        private void RegisterUser()
        {
            if (!CheckPassword())
            {
                return;
            }

            UserInfo UserInformation = new UserInfo
            {
                Username = UsernameBox.Text,
                FirstName = FirstNameBox.Text,
                LastName = LastNameBox.Text,
                Email = EmailBox.Text,

                //Add Hashing Or Encryption on password Client Side
                Password = PasswordBox.Text
            };

            string[] HashData = FeedMeLogic.Data.HashPass.HashPassword(UserInformation.Password);

            UserInformation.Password = HashData[0];
            UserInformation.Salt = HashData[1];

            int response = FeedMeLogic.Server.AuthenticationHandler.RegisterUser(UserInformation);

            if (response == 0)
            {
                MessageBox.Show("Duplicate Username");
            }
            else if (response == 1)
            {
                MessageBox.Show("Successfully Registered! You Can Now Login");
            }
            else
            {
                MessageBox.Show("Undiagnosed Error!");
            }
        }

        #endregion Methods

        #region Event Handlers

        #region Password UI Handlers
        //Event Handlers to UpdateUI
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void ConfirmPasswordBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void ConfirmPasswordBox_Enter(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void ConfirmPasswordBox_Leave(object sender, EventArgs e)
        {
            UpdateUI();
        }

        #endregion Password UI Handlers

        #region Other Handlers

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
        }

        private void NoAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            LoginForm LF = new LoginForm();
            LF.Show();
        }

        #endregion Other Handlers

        #endregion Event Handlers
    }
}