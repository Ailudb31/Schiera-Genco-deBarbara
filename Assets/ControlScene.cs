using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject bola;
    public Spawnerbolas_segundo spawnerBolasScript;
    

  
    // Start is called before the first frame update
    void Start()
    {
        int numerodbolas = Random.Range(1, 5);
        bola.SetActive(false);
        for (int i = 0; i < numerodbolas; i++)
        {
            spawnerBolasScript.CloneBola();

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
 
