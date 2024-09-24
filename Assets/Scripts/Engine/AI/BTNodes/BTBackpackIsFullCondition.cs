using Atomic.AI;
using Game;
using Game.Engine;

namespace Engine.AI.BTNodes
{
    public sealed class BTBackpackIsFullCondition: IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            return blackboard.GetCharacter().GetComponent<ResourceStorageComponent>().IsFull();
        }
    }
}