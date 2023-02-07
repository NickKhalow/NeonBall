using UnityEngine;


namespace Stars
{
    [RequireComponent(typeof(Star))]
    public class DestroyOnCollectStar : MonoBehaviour
    {
        [SerializeField] private float delay = 0.01f;


        private void Awake()
        {
            GetComponent<Star>()!.collected.AddListener(() => Destroy(gameObject, delay));
        }
    }
}