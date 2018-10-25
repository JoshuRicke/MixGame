using UnityEngine;

namespace Business.Systems.Contracts
{
   internal interface IJumpSystem
   {
      int JumpCount { get; set; }
      int Strength { get; set; }

      void Jump(Rigidbody rigidbody);
   }
}