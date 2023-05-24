using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;
    [SerializeField] SplineFollower splineFollower;

    private void Awake()
    {
        instance = this;
    }
    private bool canMove = true;

    public bool CanMove { get => canMove; set => canMove = value; }

    public void SpeedUp()
    {
        if (!canMove) return;
        splineFollower.follow = true;
        splineFollower.followSpeed += 1f;
    }

    public void SlowDown()
    {
        if (!canMove) return;
        if (splineFollower.followSpeed <= 0) splineFollower.follow = false; 
        splineFollower.followSpeed -= 1f; 
    }


    void Update()
    {
        

    }



}
