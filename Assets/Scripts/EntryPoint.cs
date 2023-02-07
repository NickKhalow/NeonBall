using DefaultNamespace.UI;
using Finishes;
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


        private void Awake()
        {
            starsCounts.EnsureNotNull();
            winCanvas.EnsureNotNull();
            finish.EnsureNotNull().finished.AddListener(() => winCanvas.Show(starsCounts.Count));
        }
    }
}