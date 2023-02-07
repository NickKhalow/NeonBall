using UnityEngine;
using Utils;


namespace DefaultNamespace.UI
{
    public class WinCanvas : MonoBehaviour
    {
        [SerializeField] private bool hideOnStart = true;
        [SerializeField] private WinStars winStars = null!;


        private void Awake()
        {
            if (hideOnStart)
            {
                gameObject.SetActive(false);
            }

            winStars.EnsureNotNull();
        }


        public void Show(int starCount)
        {
            gameObject.SetActive(true);
            winStars.Show(starCount);
        }
    }
}