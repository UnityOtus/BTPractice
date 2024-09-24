using Atomic.AI;
using Game;
using Game.Engine;

namespace Engine
{
    public class IsStorageFullCondition : IBlackboardCondition
    {
        public bool Invoke(IBlackboard blackboard)
        {
            var character = blackboard.GetCharacter();
            var storage = character.GetComponent<ResourceStorageComponent>();
            return storage.IsFull();
        }
    }
}