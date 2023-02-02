using UnityEngine;


namespace Inputs
{
    public class KeyboardBallInput : BallInputBehaviour
    {
        public override Vector2 Direction()
        {
            return new Vector2(
                Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical")
            );
        }
    }
}