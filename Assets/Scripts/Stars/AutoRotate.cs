using System;
using UnityEngine;


namespace Stars
{
    public class AutoRotate : MonoBehaviour
    {
        [SerializeField] private Vector3 power;


        private void Update()
        {
            transform.Rotate(power * Time.deltaTime);
        }
    }
}