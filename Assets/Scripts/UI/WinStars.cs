using UnityEngine;


namespace DefaultNamespace.UI
{
    public class WinStars : MonoBehaviour
    {
        [SerializeField] private RectTransform[] stars = { };


        public void Show(int count)
        {
            foreach (var star in stars)
            {
                star.gameObject.SetActive(false);
            }

            for (var i = 0; i < count; i++)
            {
                stars[i].gameObject.SetActive(true);
            }
        }
    }
}