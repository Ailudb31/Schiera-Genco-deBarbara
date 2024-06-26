using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerbolas_segundo : MonoBehaviour
{

    public GameObject bolaprefab;
    public Vector3 newPosition;
    public float minX;
    public float maxX;
    public bool autoGenerate;
    public float freq;

    void Start()
    {
        if (autoGenerate)
        {
            Invoke(nameof(CloneBola), freq);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CloneBola()
    {
        bolaprefab.SetActive(true);
        float randomX = Random.Range(minX, maxX);
        newPosition = new Vector3(randomX, newPosition.y, newPosition.z);
        Instantiate(bolaprefab, newPosition, Quaternion.identity);
        
    }

}
