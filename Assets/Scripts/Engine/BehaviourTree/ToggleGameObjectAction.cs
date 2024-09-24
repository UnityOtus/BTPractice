using Atomic.AI;
using UnityEngine;

namespace Game.Engine
{
    public class ToggleGameObjectAction : IBlackboardAction
    {
        [SerializeField, BlackboardKey]
        private int targetKey;
        [SerializeField] private bool enable;
        
        public void Invoke(IBlackboard blackboard)
        {
            var gameObject = blackboard.GetObject<GameObject>(targetKey);
            gameObject.SetActive(enable);
        }
    }
}