namespace SpaceGame.Scripts.Network;
using Godot;
using System;
using System.Collections.Generic;

public partial class Server : Node {

    public override void _Ready() {
        NetworkManager.instance.startservice += CreateServer;

    }
    
    private void CreateServer(int PORT) {
        
        ENetMultiplayerPeer peer = new ENetMultiplayerPeer();

        peer.CreateServer(PORT);
        if (peer.GetConnectionStatus() == MultiplayerPeer.ConnectionStatus.Disconnected) {
            OS.Alert($"Failed to connect to the server at port {PORT}");
        }
        Multiplayer.MultiplayerPeer = peer;
        GD.Print("Server started");
    }

    [Rpc(MultiplayerApi.RpcMode.AnyPeer)]
    public void TestPrintToAllClients(string msg) {
        GD.Print(msg);
    }
    
    
}