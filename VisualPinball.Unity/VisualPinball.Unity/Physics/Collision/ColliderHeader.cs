﻿using VisualPinball.Unity.Physics.Collider;

namespace VisualPinball.Unity.Physics.Collision
{
	/// <summary>
	/// The common data to all colliders.
	///
	/// These are all read-only.
	/// </summary>
	public struct ColliderHeader
	{
		public ColliderType Type;
		public int EntityIndex;
		public Aabb Aabb;
		public PhysicsMaterialData Material;
	}
}