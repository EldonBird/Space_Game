using Godot;
namespace SpaceGame.Scripts.Network;

public partial class NetworkManager : Node {

	[Export] public bool isServer = false;

	private const int PORT = 25565;

	public delegate void StartService(int port);
	public StartService startservice;
	public static NetworkManager instance;
	

	public override void _Ready() {

		instance = this;

		if (isServer) {
			AddChild(new Server());
		}
		else {
			AddChild(new Client());
		}
		
		startservice?.Invoke(PORT);
	}
	
	



}
