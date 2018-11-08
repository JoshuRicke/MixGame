using UnityEngine;
using Business.Systems.Contracts;

namespace Business.Systems
{
    class JumpSystem : IJumpSystem
    {
        public void Jump(Rigidbody rigidbody, float jumpStrength)
        {
            rigidbody.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
        }
    }
}
