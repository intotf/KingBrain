﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NetworkSocket;
using NetworkSocket.WebSocket;

namespace KingQuestionProxy
{
    class WebsocketMiddleware : NetworkSocket.WebSocket.WebSocketMiddlewareBase
    {
        protected override void OnText(IContenxt context, FrameRequest frame)
        {
            var ipAddress = Encoding.UTF8.GetString(frame.Content);
            context.Session.Tag.Set("ip", ipAddress);
        }
    }
}
