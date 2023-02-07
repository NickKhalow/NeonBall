using UnityEngine;
using Random = UnityEngine.Random;


namespace Stars
{
    public class RandomRotate : MonoBehaviour
    {
        [SerializeField] private Vector3 from, to;


        private void Start()
        {
            transform.rotation = Quaternion.Euler(
                Random.Range(from.x, to.x),
                Random.Range(from.y, to.y),
                Random.Range(from.z, to.z)
            );
        }
    }
}