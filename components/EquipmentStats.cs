using Godot;
using System;
using System.Collections.Generic;

[GlobalClass]
public partial class EquipmentStats : Resource
{
	[Export]
	public string Name { get; set; } = "not set";
	[Export]
	public float Cooldown { get; set; } = 1f;
	[Export]
	public float Damage { get; set; } = 1f;
}
