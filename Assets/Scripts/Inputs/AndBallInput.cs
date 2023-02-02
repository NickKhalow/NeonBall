using System;
using UnityEngine;


namespace Inputs
{
    public class AndBallInput : BallInputBehaviour
    {
        [SerializeField] private BallInputBehaviour[] ballInputs = Array.Empty<BallInputBehaviour>();


        public override Vector2 Direction()
        {
            var direction = Vector2.zero;
            foreach (var input in ballInputs)
            {
                direction += input.Direction();
            }
            return direction;
        }
    }
}