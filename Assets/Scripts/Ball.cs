using Inputs;
using System;
using UnityEngine;
using Utils;


[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float speed;
    [Header("Dependencies")] [SerializeField]
    private BallInputBehaviour ballInput = null!;
    private new Rigidbody rigidbody = null!;


    private void Awake()
    {
        ballInput.EnsureNotNull("Input not specified");
        rigidbody = GetComponent<Rigidbody>()!;
    }


    private void Update()
    {
        rigidbody.AddForce(
            ballInput.Direction().Flat()
            * (Time.deltaTime * speed)
        );
    }
}