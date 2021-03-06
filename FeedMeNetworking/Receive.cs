﻿using FeedMeNetworking.Serialization;
using System;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace FeedMeNetworking
{
    public class Receive
    {
        /*
         * Add Function to Encrypt All BYTES not unserialized data
         */

        /// <summary>
        /// Receives Data And Returns it as a byte
        /// </summary>
        /// <returns>Message From Server as a Byte</returns>
        private static byte[] ReceiveData(Socket Sock)
        {
            byte[] data = new byte[1024];
            int size = Sock.Receive(data);
            byte[] responseBuffer = new byte[size]; //use a Buffer which has a Specific Size of the message (Removes Extra Padding)
            Array.Copy(data, responseBuffer, size);

            return responseBuffer;
        }

        /// <summary>
        /// Uses Receive Data To convert Byte Received into a String
        /// </summary>
        /// <returns>The Message From Server As a String</returns>
        public static string ReceiveMessage(Socket Sock)
        {
            return Encoding.UTF8.GetString(ReceiveData(Sock));
        }

        public static DataTable ReceiveDataTable(Socket Sock)
        {
            return ProtoBufSerialization.DataDeserializing(ReceiveData(Sock));
        }

        /// <summary>
        /// Converts Message From Server Into UserInfo Object
        /// </summary>
        /// <returns>UserInfo Object</returns>
        public static UserInfo ReceiveUserInfo(Socket Sock)
        {
            return (UserInfo)ProtoBufSerialization.ObjectDeserializing(ReceiveData(Sock), ProtoBufSerialization.ObjectType.UserObject);
        }

        public static OrderInfo ReceiveOrderInfo(Socket Sock)
        {
            return (OrderInfo)ProtoBufSerialization.ObjectDeserializing(ReceiveData(Sock), ProtoBufSerialization.ObjectType.OrderObject);
        }

        public static VendorInfo ReceiveVendorInfo(Socket Sock)
        {
            return (VendorInfo)ProtoBufSerialization.ObjectDeserializing(ReceiveData(Sock), ProtoBufSerialization.ObjectType.VendorObject);
        }
    }
}