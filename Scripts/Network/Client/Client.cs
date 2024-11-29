namespace SpaceGame.Scripts.Network;
using Godot;
using System;


public partial class Client : Node {
    
    private string _token { get; set; }


    private static string GenerateNewToken() {
        
        
        char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        
        
        Random rand = new Random();
        string randomToken = "";
        for (int i = 0; i < 10; i++) {

            randomToken += chars[rand.Next(0, chars.Length)].ToString();
            
        }
        return randomToken;
    }

    public override void _Ready() {
        NetworkManager.instance.startservice += CreateClient;
        
        _token = GenerateNewToken();
        
        
        
    }
    private void CreateClient(int PORT) {

        ENetMultiplayerPeer peer = new ENetMultiplayerPeer();
        peer.CreateClient("localhost", PORT);
        if (peer.GetConnectionStatus() == MultiplayerPeer.ConnectionStatus.Disconnected) {
            OS.Alert($"Failed to connect to the server at port {PORT}");
        }
        Multiplayer.MultiplayerPeer = peer;
        GD.Print("Client Created Successfully");
    }

    [Rpc(MultiplayerApi.RpcMode.AnyPeer)]
    public void TestPrintToAllClients(string msg) {
        GD.Print(msg + "just pressed a button");
    }


    public override void _Process(double delta) {

        if (Input.IsActionJustPressed("Move_Up")) {

            GD.Print("pressed");
            Rpc("TestPrintToAllClients", _token);

        }
    }

}