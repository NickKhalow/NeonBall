using System;
using UnityEngine;
using Utils;


namespace Stars
{
    [RequireComponent(typeof(Star))]
    public class ParticlesOnCollectStar : MonoBehaviour
    {
        [SerializeField] private new ParticleSystem particleSystem = null!;
        private Star star = null!;


        private void Awake()
        {
            particleSystem.EnsureNotNull();
            star = GetComponent<Star>()!;
            star.collected.AddListener(() =>
            {
                particleSystem.transform.SetParent(null!);
                particleSystem.Play();
            });
        }
    }
}