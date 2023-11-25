using Godot;
using System;
using System.Collections.Generic;

[GlobalClass]
public partial class EquipmentStats : Resource
{
	[Export]
	public string Name = "not set";
	[Export]
	public float Cooldown = 1f;
	[Export]
	public float Damage = 1f;
	[Export]
	public PackedScene Projectile;
}
