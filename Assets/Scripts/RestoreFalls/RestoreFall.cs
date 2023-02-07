using Codice.CM.Common.Replication;
using RestoreFalls.SafePositions;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Utils;


namespace RestoreFalls
{
    public class RestoreFall : MonoBehaviour
    {
        public UnityEvent restored = new();
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
                    restored.Invoke();
                }

                yield return new WaitForSeconds(updateDelay);
            }
        }
    }
}