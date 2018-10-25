using Business.Systems.Contracts;
using Business.Systems;
using UnityEngine;

namespace Engine.Components
{
   public class JumpComponent : MonoBehaviour
   {
      IJumpSystem JumpSystem { get; set; }

      [SerializeField]
      private int _strength;

      [SerializeField]
      private int _jumpCount;

      public Rigidbody rigidBody;

      private void Start() {
         JumpSystem = new JumpSystem();
      }

      public void Jump() {
         JumpSystem.Strength = _strength;
         JumpSystem.JumpCount = _jumpCount;
         JumpSystem.Jump(rigidBody);

      }
   }
}
