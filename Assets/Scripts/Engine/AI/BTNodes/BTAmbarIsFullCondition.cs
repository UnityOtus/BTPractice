using Atomic.AI;
using Game;
using Game.Engine;

public sealed class BTAmbarIsFullCondition : IBlackboardCondition
{
    public bool Invoke(IBlackboard blackboard)
    {
        return blackboard.GetBarn().GetComponent<ResourceStorageComponent>().IsFull();
    }
}
