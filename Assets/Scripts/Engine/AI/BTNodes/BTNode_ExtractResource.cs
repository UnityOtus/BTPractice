using System;
using Atomic.AI;
using Game;
using Game.Engine;
using UnityEngine;

namespace Engine.AI.BTNodes
{
    //Группа №2
    [Serializable]
    public sealed class BTNode_ExtractResource : BTNode
    {
        public override string Name => "Extract Resource";

        [SerializeField, BlackboardKey]
        private int minDistanceKey;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            GameObject character = blackboard.GetCharacter();
            GameObject resource = blackboard.GetTargetResource();
            float minDistance = blackboard.GetFloat(this.minDistanceKey);

            if (resource.GetComponent<ResourceStorageComponent>().IsEmpty())
            {
                Debug.Log("Extracted");
                return BTState.SUCCESS;
            }
            
            if (character.GetComponent<ResourceStorageComponent>().IsFull())
            {
                Debug.Log("Backpack is full");
                return BTState.SUCCESS;
            }

            Vector3 distanceVector = resource.transform.position - character.transform.position;
            distanceVector.y = 0;
            
            if (distanceVector.sqrMagnitude > minDistance * minDistance)
            {
                Debug.Log("Not reached");
                return BTState.FAILURE;
            }

            Debug.Log("Invoking");
            character.GetComponent<LookComponent>().Direction = distanceVector.normalized;
            character.GetComponent<HarvestComponent>().StartHarvest();
            return BTState.RUNNING;
        }
    }
}