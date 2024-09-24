using System;
using System.Collections.Generic;
using Atomic.AI;
using Game.Engine;
using UnityEngine;

namespace Engine.AI.BTNodes
{
    //Группа №1
    [Serializable]
    public class BTNode_FindNearestTree : BTNode
    {
        public override string Name => "Find Resource";

        [SerializeField, BlackboardKey]
        private int characterKey;

        [SerializeField, BlackboardKey]
        private int resourceServiceKey;

        [SerializeField, BlackboardKey]
        private int targetResourceKey;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            GameObject character = blackboard.GetObject<GameObject>(this.characterKey);
            TreeService treeService = blackboard.GetObject<TreeService>(this.resourceServiceKey);

            bool success = treeService.FindClosest(
                character.transform.position,
                out GameObject result
            );
            if (success)
            {
                blackboard.SetObject(this.targetResourceKey, result);
                return BTState.SUCCESS;
            }

            return BTState.FAILURE;
        }

       
    }
}