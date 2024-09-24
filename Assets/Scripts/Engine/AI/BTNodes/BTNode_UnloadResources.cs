using System;
using Atomic.AI;

namespace Game.Engine
{
    //Команда №3
    [Serializable]
    public sealed class BTNode_UnloadResources : BTNode
    {
        public override string Name => "Unload Resources";
        
        protected override BTState OnUpdate(IBlackboard blackboard, float deltaTime)
        {
            var amount = blackboard.GetCharacter().GetComponent<ResourceStorageComponent>().ExtractAllResources();
            blackboard.GetBarn().GetComponent<ResourceStorageComponent>().AddResources(amount);

            return BTState.SUCCESS;
        }
    }
}