using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

using Business.Systems.Contracts;
namespace Business.Systems
{
   class InputSystem : IInputSystem
   {
      public Vector3 GetMovementInput() {
         var horizontal = Input.GetAxis("Horizontal");
         var vertical = Input.GetAxis("Vertical");
         var input = new Vector3(horizontal, 0, vertical);
       
         if (input.sqrMagnitude > 1) {
            input.Normalize();
         }

         return input;
      }
   }
}
