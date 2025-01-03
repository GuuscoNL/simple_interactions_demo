using Sandbox;
using SimpleInteractions;

public sealed class ExampleThreeCubeOneInteraction : SimpleInteraction
{

	[Property]
	GameObject OtherCube;

	private SimpleInteraction OtherInteraction;

	protected override void OnStart()
	{
		base.OnStart();

		if(!OtherCube.IsValid())
		{
			Log.Error($"No OtherCube selected for {this.GameObject.Name}!");
		}

		OtherInteraction = OtherCube.GetComponent<SimpleInteraction>();
	}

	[Rpc.Broadcast]
	protected override void OnInteract()
	{
		if (OtherInteraction.InteractionEnabled)
		{
			OtherInteraction.InteractionEnabled = false;
			OtherCube.GetComponent<ModelRenderer>().Tint = Color.Red;
			InteractionString = "Enable Interaction on other cube";
		} else
		{
			OtherInteraction.InteractionEnabled = true;
			OtherCube.GetComponent<ModelRenderer>().Tint = Color.Green;
			InteractionString = "Disable Interaction on other cube";
		}
	}
}
