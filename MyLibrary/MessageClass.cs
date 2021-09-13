using System;

namespace MyLibrary
{
    public class MessageClass
    {
        public static string GetMessage()
        {
            return $"{DateTime.Now} This is test message";
        }
    }
}
