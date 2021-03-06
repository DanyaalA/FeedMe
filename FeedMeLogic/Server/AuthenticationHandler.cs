﻿using FeedMeNetworking;
using FeedMeNetworking.Serialization;
using System;

namespace FeedMeLogic.Server
{
    public class AuthenticationHandler
    {
        public static object AuthenticateLogin(string username, string password, int LoginType)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "Login");

            Send.SendMessage(ServerConnection.ServerSock, LoginType.ToString());

            if (LoginType == 0)
            {
                
                return CustomerLogin(username, password);
            }
            else if (LoginType == 1)
            {
                //Send.token = Receive.ReceiveMessage(ServerConnection.ServerSock);
                return VendorLogin(username, password);
            }

            Send.SendMessage(ServerConnection.ServerSock, username);

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }

        public static string GetSalt(string password)
        {
            string salt = Receive.ReceiveMessage(ServerConnection.ServerSock);
            //If Salt Returns -1 then Username received is invalid
            if (salt == "-1")
            {
                return "-1";
            }

            //Send.SendMessage(ServerConnection.ServerSock, FeedMeLogic.Data.HashPass.ConfirmHash(password, salt));

            return salt;
        }

        /// <summary>
        /// Login Function that Returns an Object which can then be casted/converted into UserInfo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static object CustomerLogin(string username, string password)
        {
            //Send.SendMessage(ServerConnection.ServerSock, "Login");

            Send.SendMessage(ServerConnection.ServerSock, username);

            string salt = GetSalt(password);

            string hash = FeedMeLogic.Data.HashPass.ConfirmHash(password, salt);

            Send.SendMessage(ServerConnection.ServerSock, hash);

            Send.token = Receive.ReceiveMessage(ServerConnection.ServerSock);

            return Receive.ReceiveUserInfo(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Login Function that Returns an Object which can then be casted/converted into VendorInfo
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static object VendorLogin(string username, string password)
        {
            Send.SendMessage(ServerConnection.ServerSock, username);

            string salt = GetSalt(password);

            Send.SendMessage(ServerConnection.ServerSock, FeedMeLogic.Data.HashPass.ConfirmHash(password, salt));

            Send.token = Receive.ReceiveMessage(ServerConnection.ServerSock);

            return Receive.ReceiveVendorInfo(ServerConnection.ServerSock);
        }

        /// <summary>
        /// Sends Registration Information to the Client where it will processed
        /// </summary>
        /// <param name="UserInformation">User Information</param>
        /// <returns>Value Indicating if the registration was successfull</returns>
        public static int RegisterUser(UserInfo UserInformation)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "Register");

            Send.SendMessage(ServerConnection.ServerSock, "User");

            Send.SendUserInfo(ServerConnection.ServerSock, UserInformation);

            return Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));
        }

        /// <summary>
        /// Sends REgistration Information with Vendor Information.
        /// </summary>
        /// <param name="VendorInformation">Vendor Information which needs to be registered</param>
        /// <returns>Value Indicating if the registration was successfull</returns>
        public static int RegisterVendor(VendorInfo VendorInformation)
        {
            Send.SendToken(ServerConnection.ServerSock);

            Send.SendMessage(ServerConnection.ServerSock, "Register");

            Send.SendMessage(ServerConnection.ServerSock, "Vendor");

            Send.SendVendorInfo(ServerConnection.ServerSock, VendorInformation);

            return Convert.ToInt32(Receive.ReceiveMessage(ServerConnection.ServerSock));
        }
    }

}