using Business.Systems.Contracts;
using Business.Systems;
using UnityEngine;

namespace Engine.Components
{
    public class JumpComponent : MonoBehaviour, IJump
    {
        IJumpSystem JumpSystem { get; set; }

        [SerializeField]
        private float _strength;

        [SerializeField]
        private int _jumpCount;

        public Rigidbody rigidBody;

        private void Start()
        {
            JumpSystem = new JumpSystem();
            rigidBody = GetComponent<Rigidbody>();
        }

        public void Jump()
        {
            JumpSystem.Jump(rigidBody, _strength);

        }
    }
}
