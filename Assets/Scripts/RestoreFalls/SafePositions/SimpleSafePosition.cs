using UnityEngine;
using Utils;


namespace RestoreFalls.SafePositions
{
    public class SimpleSafePosition : SafePositionBehaviour
    {
        [SerializeField] private Transform defaultSafePosition = null!;


        private void Start()
        {
            defaultSafePosition.EnsureNotNull("Default safe position not found");
        }


        public override Vector3 Pose()
        {
            return defaultSafePosition.position;
        }
    }
}