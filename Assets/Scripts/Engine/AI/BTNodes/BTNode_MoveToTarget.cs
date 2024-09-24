using System;
using Atomic.AI;
using UnityEngine;

namespace Game.Engine
{
    [Serializable]
    public sealed class BTNode_MoveToTarget : BTNode
    {
        public override string Name => "Move To Target";

        [SerializeField, BlackboardKey]
        private int characterKey;

        [SerializeField, BlackboardKey]
        private int targetKey;

        [SerializeField, BlackboardKey]
        private int stoppingDistanceKey;

        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            GameObject character = blackboard.GetObject<GameObject>(this.characterKey);
            GameObject target = blackboard.GetObject<GameObject>(this.targetKey);
            float stoppingDistance = blackboard.GetFloat(this.stoppingDistanceKey);

            Vector3 distance = target.transform.position- character.transform.position;
            distance.y = 0;
            
            if (distance.sqrMagnitude <= stoppingDistance * stoppingDistance)
            {
                return BTState.SUCCESS;
            }

            Vector3 direction = distance.normalized;
            character.GetComponent<MoveComponent>().MoveStep(direction);
            return BTState.RUNNING;
        }
    }
}