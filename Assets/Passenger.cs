using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passenger : MonoBehaviour
{
    float passengerMoveDuration = 1f;
    public void MoveToTarget(Transform targetPoint)
    {
        transform.DOMove(targetPoint.position, passengerMoveDuration);
    }
}
