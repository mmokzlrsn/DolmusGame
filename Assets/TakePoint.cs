using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakePoint : MonoBehaviour
{
    int passengerCount = 3;
    [SerializeField] bool isLeft = false;
    [SerializeField] List<Passenger> passengerList;

    private void Start()
    {
        AddPassengersToList();
        SetPassengersListLocation();
    }

    public void AddPassengersToList()
    {
        for(int i = passengerList.Count; i < passengerCount; i++)
        {
            passengerList.Add(PassengerPoolManager.instance.GetPassenger());
        }
    }

    private void SetPassengersListLocation()
    {
        int position = 0;
        foreach(Passenger passenger in passengerList)
        {
            passenger.transform.SetParent(transform, false);
            if((isLeft))
            {
                passenger.transform.localPosition = new Vector3(--position, 0, 0);
            }
            else
            {
                passenger.transform.localPosition = new Vector3(++position, 0, 0);
            }
            passenger.transform.LookAt(this.transform);
        }
    }

    private void MovePassengersListLocation()
    {
        int position = 0;
        foreach (Passenger passenger in passengerList)
        {
            if ((isLeft))
            {
                passenger.transform.DOLocalMove(new Vector3(--position, 0, 0), 1f);
            }
            else
            {
                passenger.transform.DOLocalMove(new Vector3(++position, 0, 0), 1f);
            }

            
        }
    }



    private void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag(Tags.Tag_Player))
        {
            //make all passengers get in to the car

            passengerList[0].transform.parent = other.transform;
            //get enter point?
            passengerList[0].transform.DOLocalMove(Vector3.zero, 1f).OnComplete(() =>
            {
                PassengerPoolManager.instance.AddPassenger(passengerList[0]);
                passengerList.RemoveAt(0);
                MovePassengersListLocation();
            });


            // CHANGE STATE TO TAKING PASSENGERS
            // MAKE FOLLOW 0 
        }
    }
}
