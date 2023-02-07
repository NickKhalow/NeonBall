using System;
using UnityEngine;
using UnityEngine.Events;


namespace Stars
{
    [RequireComponent(typeof(Collider))]
    public class Star : MonoBehaviour
    {
        public UnityEvent collected = new();


        private void Awake()
        {
            if (GetComponent<Collider>()!.isTrigger == false)
            {
                throw new Exception("Must be trigger");
            }
        }


        private void OnTriggerEnter(Collider other)
        {
            collected.Invoke();
        }
    }
}