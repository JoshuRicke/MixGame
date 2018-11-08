using UnityEngine;

namespace Business.Systems.Contracts
{
    internal interface IJumpSystem
    {
        void Jump(Rigidbody rigidbody, float jumpStrength);
    }
}