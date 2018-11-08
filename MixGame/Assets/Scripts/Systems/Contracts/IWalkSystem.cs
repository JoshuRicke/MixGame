using UnityEngine;
namespace Business.Systems.Contracts
{
    public interface IWalkSystem
    {
        void Walk(Transform transform, Vector3 movement, float walkSpeed);
    }
}
