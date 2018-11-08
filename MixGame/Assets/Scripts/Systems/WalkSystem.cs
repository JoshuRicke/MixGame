using UnityEngine;
using Business.Systems.Contracts;

namespace Business.Systems
{
   class WalkSystem : IWalkSystem
   {
    
      public void Walk(Transform transform, Vector3 movement, float walkSpeed) {
         transform.Translate(movement * Time.deltaTime * walkSpeed);
      }

   }
}
