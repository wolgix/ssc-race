﻿using CitizenFX.Core;

namespace SSRC
{
    public static class ChatHelper
    {
        public static void Print(string sender, string message, int red = 255, int green = 255, int blue = 255)
        {
            BaseScript.TriggerEvent("chat:addMessage", new
            {
                color = new[] { red, green, blue },
                multiline = false,
                args = new[] { sender, message }
            });
        }
    }
}
