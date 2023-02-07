using System;
using UnityEngine;


namespace Stars.Count
{
    public class StarsCounts : MonoBehaviour
    {
        [Header("Debug")] [SerializeField] private Star[] stars = { };
        [SerializeField] private int count;


        private void Awake()
        {
            stars = FindObjectsOfType<Star>()!;
            foreach (var star in stars)
            {
                star.collected.AddListener(() => count++);
            }
        }


        public int Count => count;
    }
}