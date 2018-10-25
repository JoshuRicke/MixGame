using UnityEngine;
using Business.Systems.Contracts;
using Business.Systems;
namespace Engine.Components
{
    public class WalkComponent : MonoBehaviour, IWalk
    {
        [SerializeField]
        private Transform _objectToMove;
        [SerializeField]
        private float _walkSpeed;

        IWalkSystem WalkSystem { get; set; }
        IInputSystem InputSystem { get; set; }

        private void Start()
        {
            WalkSystem = new WalkSystem();
            InputSystem = new InputSystem();

        }

        public void Walk()
        {
            WalkSystem.Walk(_objectToMove, InputSystem.GetMovementInput(), _walkSpeed);

        }
    }
}
