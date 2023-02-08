using DefaultNamespace.UI;
using Finishes;
using Inputs;
using Stars.Count;
using UnityEngine;
using Utils;


namespace DefaultNamespace
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private Finish finish = null!;
        [SerializeField] private WinCanvas winCanvas = null!;
        [SerializeField] private StarsCounts starsCounts = null!;
        [SerializeField] private PauseableBallInput pauseableBallInput = null!;


        private void Awake()
        {
            starsCounts.EnsureNotNull();
            winCanvas.EnsureNotNull();
            finish.EnsureNotNull().finished.AddListener(() =>
            {
                pauseableBallInput.Pause(true);
                winCanvas.Show(starsCounts.Count);
            });
        }
    }
}