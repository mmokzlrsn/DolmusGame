using Dreamteck;
using Dreamteck.Splines;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplineSpawner : MonoBehaviour
{
    [SerializeField] SplineRenderer splineRenderer;
    [SerializeField] List<Transform> prefabList;
      
    [Header("Offsets")]

    [SerializeField] float xOffset;
    [SerializeField] float yOffset;
    [SerializeField] float zOffset;

    [SerializeField] private float spawnFrequency;
    private float stepSize;

    // Start is called before the first frame update
    void Start()
    {
        stepStepSize();
        Spawn();
    }

    private void stepStepSize()
    {
        stepSize = spawnFrequency / 100;
    }

    public void Spawn()
    { 
        for(double currentPosition = 0.0; currentPosition <= 1.0; currentPosition += stepSize)
        {
            Instantiate(GetPrefabFromList(), splineRenderer.EvaluatePosition(currentPosition) + new Vector3(xOffset * Utilities.RandomSign(), yOffset, zOffset), Quaternion.identity);
        }
         
    }

    private Transform GetPrefabFromList()
    {
        
        return prefabList.GiveRandom(); 
    }

     
}
