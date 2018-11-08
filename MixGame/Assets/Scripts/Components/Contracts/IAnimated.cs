using UnityEngine;

namespace Engine.Components
{
    public interface IAnimated
    {
        Animator Animator { get; set; }
    }
}