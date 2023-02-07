using System;
using UnityEngine;
using UnityEngine.Events;


namespace Finishes
{
    [RequireComponent(typeof(Collider))]
    public class Finish : MonoBehaviour
    {
        public UnityEvent finished = new();


        private void Awake()
        {
            if (GetComponent<Collider>()!.isTrigger == false)
            {
                throw new Exception("Must be trigger");
            }
        }


        private void OnTriggerEnter(Collider other)
        {
            finished.Invoke();
        }
    }
}