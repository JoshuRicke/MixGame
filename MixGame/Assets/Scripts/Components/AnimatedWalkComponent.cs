﻿using UnityEngine;
using Business.Systems.Contracts;
using Business.Systems;
namespace Engine.Components
{
    public class AnimatedWalkComponent : MonoBehaviour, IWalk
    {
        [SerializeField]
        private Transform _objectToMove;
        [SerializeField]
        private float _walkSpeed;
        [SerializeField]
        private Animator _animator;

        IWalkSystem WalkSystem { get; set; }
        IInputSystem InputSystem { get; set; }

        private void Start()
        {
            WalkSystem = new WalkSystem();
            InputSystem = new InputSystem();

        }

        public void Walk()
        {
            _animator.SetFloat("Walk", _walkSpeed);
            WalkSystem.Walk(_objectToMove, InputSystem.GetMovementInput(), _walkSpeed);
        }
    }
}