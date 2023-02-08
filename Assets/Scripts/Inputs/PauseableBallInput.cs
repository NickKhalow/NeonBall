using UnityEngine;
using Utils;


namespace Inputs
{
    public class PauseableBallInput : BallInputBehaviour
    {
        [SerializeField] private BallInputBehaviour origin = null!;
        [SerializeField] private bool pause = false;


        public void Pause(bool value)
        {
            pause = value;
        }


        private void Awake()
        {
            origin.EnsureNotNull();
        }


        public override Vector2 Direction()
        {
            return pause ? Vector2.zero : origin.Direction();
        }
    }
}