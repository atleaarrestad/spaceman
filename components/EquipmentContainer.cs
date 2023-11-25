using Godot;
using System.Collections.Generic;

[GlobalClass]
public partial class EquipmentContainer : Node2D
{
	[Export]
	public PackedScene[] WeaponScenes { get; set; }

	[Export]
	public Vector2[] WeaponOffsets { get; set; }

	private List<EquipmentComponent> equipmentComponents = new();	


	public override void _Ready()
	{
		for (int i = 0; i < WeaponScenes.Length; i++)
		{
			var weapon = WeaponScenes[i].Instantiate<Node2D>();
			AddChild(weapon);
			weapon.Position += WeaponOffsets[i];
			equipmentComponents.Add(weapon.GetNode<EquipmentComponent>("EquipmentComponent"));
		}	
	}

	private void _on_action_input_component_shoot()
	{
		equipmentComponents.ForEach(equipment => equipment.Activate());
	}
}



