using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject bola;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int NumeroDBolas = Random.Range(1, 20);
        for (int i = 0; i < NumeroDBolas; i++)
        {
            SpawnerObjetos();
        }
    }
    private void SpawnerObjetos()
    {
        
    }
}
