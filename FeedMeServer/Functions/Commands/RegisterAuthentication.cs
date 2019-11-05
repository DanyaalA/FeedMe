﻿using FeedMeNetworking;
using FeedMeSerialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeServer.Functions.Commands
{
    class RegisterAuthentication
    {
        private const string SERVER_HASH = "FeedMeHash";
        public static void RegistrationHandler(Socket Client)
        {
            UserInfo UserInformation = Receive.ReceiveUserInfo(Client);

            UserInformation = HashPassword(UserInformation);

            string RegisterValue = RegisterUser(UserInformation).ToString();

            Send.SendMessage(Client, RegisterValue);
        }

        private static UserInfo HashPassword(UserInfo UserInformation)
        {
            string[] HashData = Data.HashPass.HashPassword(UserInformation.Password);

            UserInformation.Password = HashData[0];
            UserInformation.Salt = HashData[1];

            return UserInformation;
        }

        private static int RegisterUser(UserInfo CI)
        {
            string SQLQuery = ($@"INSERT INTO users (username, firstname, lastname, email, password, salt)
                                  VALUES ('{CI.Username}', '{CI.FirstName}', '{CI.LastName}', '{CI.Email}', '{CI.Password}', '{CI.Salt}');");

            Data.DAL.ExecCommand(SQLQuery);

            if (Data.DAL.ErrorCode == 1062)
            {
                return 0; //Duplicate username
            }
            else if (Data.DAL.ErrorCode == -1)
            {
                return 1; //Successfully Registerd
            }
            else
            {
                return 3; //Undiagnosed Error (Will Add More Error Handling Later);
            }
        }

        private static String ReHashPassword(string Password)
        {
            return "No";
        }
    }
}
