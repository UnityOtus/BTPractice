using System;
using Atomic.AI;
using Atomic.Objects;
using Game.Engine;
using Sample;
using UnityEngine;

namespace Engine.AI.BTNodes
{
    public class BTNode_FindNearestTree : BTNode
    {
        public override string Name => "Find Resource";

        [SerializeField, BlackboardKey]
        private int character;

        [SerializeField, BlackboardKey]
        private int resourceService;

        [SerializeField, BlackboardKey]
        private int targetResource;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var resourceService = blackboard.GetResourceService();
            var character = blackboard.GetCharacter();
            
            var boolResult = resourceService.FindClosestResource(character.Transform.position, out IAtomicObject result);
            blackboard.SetObject(targetResource, result);
            
            return !boolResult ? BTState.FAILURE : BTState.SUCCESS;
        }
    }
}