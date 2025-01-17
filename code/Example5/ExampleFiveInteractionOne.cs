using Sandbox;

public sealed class ExampleFiveInteractionOne : SimpleInteractions.SimpleInteraction
{
	[Property]
	public GameObject Parent;
	protected override void OnStart()
	{
		base.OnStart();

		// Put your initialization code here if you have any
	}

	protected override void OnUpdate()
	{
		base.OnUpdate();

		// Put your update code here if you have any
	}


	[Rpc.Broadcast]
	protected override void OnInteract()
	{
		Parent.WorldPosition = Parent.WorldPosition + new Vector3(0, 0, 10);
	}
}
