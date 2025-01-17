using Sandbox;

public sealed class ExampleFiveInteractionTwo : SimpleInteractions.SimpleInteraction
{
	[Property]
	public GameObject Parent;
	enum State {
		RED,
		GREEN,
		BLUE
	}

	State state = State.RED;
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
		Parent.WorldPosition = Parent.WorldPosition + new Vector3(0, 0, 0);

		
		var caller = Rpc.Caller.DisplayName;
		Log.Info($"{caller} interacted with {Parent.Name}!");
		

		ModelRenderer renderer = Parent.GetComponent<ModelRenderer>();
		switch (state)
		{
			case State.RED:
				renderer.Tint = Color.Green;
				InteractionString = "Change to Blue";
				state = State.GREEN;
				break;
			case State.GREEN:
				renderer.Tint = Color.Blue;
				InteractionString = "Change to Red";
				state = State.BLUE;
				break;
			case State.BLUE:
				renderer.Tint = Color.Red;
				InteractionString = "Change to Green";
				state = State.RED;
				break;
		}
	}
}
