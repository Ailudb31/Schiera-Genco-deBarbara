using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject bola;
    public Spawnerbolas_segundo spawnerBolasScript;
    private int numerodbolas;
  
    // Start is called before the first frame update
    void Start()
    {
        numerodbolas = Random.Range(1, 5);
        bola.SetActive(false);
        for (int i = 0; i < numerodbolas; i++)
        {
            spawnerBolasScript.CloneBola();

        }

    }

    public void CompararResultados()
    {
        if (inputNumero.text == "")
        {
            // mostrar en panel “Debes ingresar un resultado” 
        }

        else if (int.Parse(inputNumero.text) == numerodbolas)
        {
            // mostrar en el panel "Es correcto, felicitaciones!"
        }
        else
        {
            // mostrar en el panel "Es incorrecto."
        }
             
    }

}
 
