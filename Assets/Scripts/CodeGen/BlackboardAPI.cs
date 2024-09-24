/**
* Code generation. Don't modify! 
 */
using System.Runtime.CompilerServices;
using Atomic.AI;
using Game.Engine;
using UnityEngine;
namespace Game
{
    public static class BlackboardAPI
    {
        public const int Character = 1; // GameObject : class
        public const int TreeService = 2; // TreeService : class
        public const int TargetResource = 3; // GameObject : class
        public const int NoTreesView = 4; // GameObject : class
        public const int StoppingDistance = 5; // float
        public const int Barn = 6; // GameObject : class
        public const int FullBarnView = 7; // GameObject : class


        ///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCharacter(this IBlackboard obj) => obj.HasObject(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetCharacter(this IBlackboard obj) => obj.GetObject<GameObject >(Character);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCharacter(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(Character, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCharacter(this IBlackboard obj, GameObject  value) => obj.SetObject(Character, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCharacter(this IBlackboard obj) => obj.DelObject(Character);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTreeService(this IBlackboard obj) => obj.HasObject(TreeService);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static TreeService  GetTreeService(this IBlackboard obj) => obj.GetObject<TreeService >(TreeService);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTreeService(this IBlackboard obj, out TreeService  value) => obj.TryGetObject(TreeService, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTreeService(this IBlackboard obj, TreeService  value) => obj.SetObject(TreeService, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTreeService(this IBlackboard obj) => obj.DelObject(TreeService);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasTargetResource(this IBlackboard obj) => obj.HasObject(TargetResource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetTargetResource(this IBlackboard obj) => obj.GetObject<GameObject >(TargetResource);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetTargetResource(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(TargetResource, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTargetResource(this IBlackboard obj, GameObject  value) => obj.SetObject(TargetResource, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelTargetResource(this IBlackboard obj) => obj.DelObject(TargetResource);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasNoTreesView(this IBlackboard obj) => obj.HasObject(NoTreesView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetNoTreesView(this IBlackboard obj) => obj.GetObject<GameObject >(NoTreesView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetNoTreesView(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(NoTreesView, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNoTreesView(this IBlackboard obj, GameObject  value) => obj.SetObject(NoTreesView, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelNoTreesView(this IBlackboard obj) => obj.DelObject(NoTreesView);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasStoppingDistance(this IBlackboard obj) => obj.HasFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetStoppingDistance(this IBlackboard obj) => obj.GetFloat(StoppingDistance);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetStoppingDistance(this IBlackboard obj, out float value) => obj.TryGetFloat(StoppingDistance, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetStoppingDistance(this IBlackboard obj, float value) => obj.SetFloat(StoppingDistance, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelStoppingDistance(this IBlackboard obj) => obj.DelFloat(StoppingDistance);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBarn(this IBlackboard obj) => obj.HasObject(Barn);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetBarn(this IBlackboard obj) => obj.GetObject<GameObject >(Barn);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBarn(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(Barn, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBarn(this IBlackboard obj, GameObject  value) => obj.SetObject(Barn, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBarn(this IBlackboard obj) => obj.DelObject(Barn);


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasFullBarnView(this IBlackboard obj) => obj.HasObject(FullBarnView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static GameObject  GetFullBarnView(this IBlackboard obj) => obj.GetObject<GameObject >(FullBarnView);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetFullBarnView(this IBlackboard obj, out GameObject  value) => obj.TryGetObject(FullBarnView, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFullBarnView(this IBlackboard obj, GameObject  value) => obj.SetObject(FullBarnView, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelFullBarnView(this IBlackboard obj) => obj.DelObject(FullBarnView);

    }
}
