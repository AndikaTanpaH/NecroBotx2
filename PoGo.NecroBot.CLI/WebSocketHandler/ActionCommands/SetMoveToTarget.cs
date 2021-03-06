﻿using System.Threading.Tasks;
using PoGo.NecroBot.Logic.State;
using SuperSocket.WebSocket;

namespace PoGo.NecroBot.CLI.WebSocketHandler.ActionCommands
{
    public class SetDestination : IWebSocketRequestHandler
    {
        public string Command { get; private set; }

        public SetDestination()
        {
            Command = "SetMoveToTarget";
        }

        public async Task Handle(ISession session, WebSocketSession webSocketSession, dynamic message)
        {
            await Logic.Tasks.SetMoveToTargetTask.Execute(session,(double)message.Latitude, (double)message.Longitude, (string)message.FortId);
        }
    }
}