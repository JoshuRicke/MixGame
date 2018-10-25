using UnityEngine;
using Business.Systems.Contracts;

namespace Business.Systems
{
   class JumpSystem : IJumpSystem
   {

      public int JumpCount { get; set; }

      public int Strength { get; set; }


      public void Jump(Rigidbody rigidbody) {
         rigidbody.AddForce(Vector3.up * Strength, ForceMode.Impulse);
      }
   }
}
