using System.Collections;
using UnityEngine;


namespace RestoreFalls.SafePositions
{
    public class SmartSafePosition : SafePositionBehaviour
    {
        [SerializeField] private float updateDelay = 0.3f;
        [Header("Debug")] [SerializeField] private Vector3 safePose;


        public override Vector3 Pose()
        {
            return safePose;
        }


        private IEnumerator Start()
        {
            safePose = transform.position;
            while (this)
            {
                var list = Physics.RaycastAll(
                    new Ray(
                        transform.position,
                        Vector3.down
                    )
                )!;

                foreach (var hit in list)
                {
                    if (hit.collider!.CompareTag("Ground"))
                    {
                        safePose = hit.point;
                    }
                }

                yield return new WaitForSeconds(updateDelay);
            }
        }
    }
}