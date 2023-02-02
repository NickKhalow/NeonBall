using System.Globalization;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;


namespace Inputs
{
    [RequireComponent(typeof(RectTransform))]
    public class SwipeInput : BallInputBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        [SerializeField] private Image knob = null!;
        [SerializeField] private float maxDistance = 100;
        [Header("Debug")] [SerializeField] private Vector2 startPosition;
        [SerializeField] private Vector2 output;


        private void Awake()
        {
            knob.EnsureNotNull("Knob not specified");
        }


        public override Vector2 Direction()
        {
            return output;
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            knob.enabled = true;
            startPosition = eventData.position;
            output = Vector2.zero;
            knob.transform.position = startPosition;
        }


        public void OnDrag(PointerEventData eventData)
        {
            var raw = eventData.position - startPosition;
            knob.transform.position =
                raw.magnitude > maxDistance
                    ? startPosition + raw.normalized * maxDistance
                    : eventData.position;

            output = (
                knob.transform.position -
                new Vector3(
                    startPosition.x,
                    startPosition.y
                )
            ) / maxDistance;
        }


        public void OnPointerUp(PointerEventData eventData)
        {
            knob.enabled = false;
            output = Vector2.zero;
        }
    }
}