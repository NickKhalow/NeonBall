using System.Collections;
using UnityEngine;
using Utils;


namespace RestoreFalls
{
    [RequireComponent(typeof(RestoreFall))]
    public class TrailOnRestore : MonoBehaviour
    {
        [SerializeField] private TrailRenderer trail = null!;
        private RestoreFall restoreFall = null!;


        private void Awake()
        {
            trail.EnsureNotNull();
            restoreFall = GetComponent<RestoreFall>()!;
            restoreFall.restored.AddListener(() => StartCoroutine(Trail()));
        }


        private IEnumerator Trail()
        {
            yield return null;
            trail.Clear();
        }
    }
}