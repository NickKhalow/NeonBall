using DG.Tweening;
using UnityEngine;


namespace DefaultNamespace.UI
{
    public class WinStars : MonoBehaviour
    {
        [SerializeField] private RectTransform[] stars = { };
        [SerializeField] private float appearDelay = 0.2f;
        [SerializeField] private float appearDuration = 0.5f;
        [SerializeField] private Ease appearEase = Ease.OutBounce;


        public void Show(int count)
        {
            foreach (var star in stars)
            {
                star.transform.localScale = Vector3.zero;
            }

            var sequence = DOTween.Sequence()!;
            for (var i = 0; i < count; i++)
            {
                sequence.Insert(
                    appearDelay * i,
                    stars[i]
                        .DOScale(1, appearDuration)!
                        .SetEase(appearEase)!
                );
            }
        }
    }
}