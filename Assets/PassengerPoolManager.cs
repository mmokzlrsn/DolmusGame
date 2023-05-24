using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerPoolManager : MonoBehaviour
{
    public static PassengerPoolManager instance;

    [SerializeField] Passenger passengerPrefab;
    Queue<Passenger> passengerQueue;

    [SerializeField] int passengerPoolCount;
    


    public Passenger GetPassenger()
    {
        Passenger passenger = passengerQueue.Dequeue();
        passenger.gameObject.SetActive(true);
        return passenger; 
    }

    public void AddPassenger(Passenger passenger)
    {
        passengerQueue.Enqueue(passenger);
        passenger.transform.parent = transform;
        passenger.gameObject.SetActive(false);
    }

    private void Awake()
    {
        instance = this;
        passengerQueue = new Queue<Passenger>();
        GeneratePassengers();

    }

    public void GeneratePassengers()
    {
        for(int i = passengerQueue.Count; i < passengerPoolCount; i++)
        {
            Passenger passenger = Instantiate(passengerPrefab, this.transform);
            passenger.gameObject.SetActive(false);
            passengerQueue.Enqueue(passenger);
        }
    }

    private void Start()
    {
            
    }
}
