using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBolas : MonoBehaviour
{
    public GameObject bola;
    
    public void CloneObjeto()
    {
        Instantiate(bola);
    }

    
    
}
