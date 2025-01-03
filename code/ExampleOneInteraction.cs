using Sandbox;

public sealed class ExampleOneInteraction : SimpleInteractions.SimpleInteraction
{
	[Rpc.Broadcast]
	protected override void OnInteract()
	{
		this.GameObject.WorldPosition = this.GameObject.WorldPosition + new Vector3(0, 0, 10);
	}
}
