using UnityEngine;


namespace RestoreFalls.SafePositions
{
    public abstract class SafePositionBehaviour : MonoBehaviour, ISafePosition
    {
        public abstract Vector3 Pose();
    }
}