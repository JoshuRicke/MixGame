using UnityEngine;
using Business.Systems.Contracts;
using Business.Systems;
namespace Engine.Components
{
    public class AnimatedWalkComponent : MonoBehaviour, IWalk, IAnimated
    {
        [SerializeField]
        private Transform _objectToMove;
        [SerializeField]
        private float _walkSpeed;
        [SerializeField]
        private Animator _animator;

        public Animator Animator { get; set; }

        IWalkSystem WalkSystem { get; set; }
        IInputSystem InputSystem { get; set; }

        private void Start()
        {
            WalkSystem = new WalkSystem();
            InputSystem = new InputSystem();

        }

        public void Walk()
        {
            _animator.SetTrigger("Walk");
            WalkSystem.Walk(_objectToMove, InputSystem.GetMovementInput(), _walkSpeed);
        }
    }
}
