using Sandbox;

public sealed class ExampleTwoInteraction : SimpleInteractions.SimpleInteraction
{

	enum State {
		RED,
		GREEN,
		BLUE
	}

	State state = State.RED;

	[Rpc.Broadcast]
	protected override void OnInteract()
	{

		this.GameObject.WorldPosition = this.GameObject.WorldPosition + new Vector3(0, 0, 0);

		
		var caller = Rpc.Caller.DisplayName;
		Log.Info($"{caller} interacted with {this.GameObject.Name}!");
		

		ModelRenderer renderer = this.GameObject.GetComponent<ModelRenderer>();
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
