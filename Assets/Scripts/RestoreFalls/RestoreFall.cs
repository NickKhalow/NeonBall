using RestoreFalls.SafePositions;
using System;
using System.Collections;
using UnityEngine;
using Utils;


namespace RestoreFalls
{
    public class RestoreFall : MonoBehaviour
    {
        [SerializeField] private float fallYTrigger = -10;
        [SerializeField] private float updateDelay = 0.3f;
        [SerializeField] private SafePositionBehaviour safePosition = null!;


        private IEnumerator Start()
        {
            safePosition.EnsureNotNull("Safe position not found");
            while (this)
            {
                if (transform.position.y < fallYTrigger)
                {
                    transform.position = safePosition.Pose();
                }

                yield return new WaitForSeconds(updateDelay);
            }
        }
    }
}