using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;



public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject bola;
    public Spawnerbolas_segundo spawnerBolasScript;
    private int numerodbolas;
    public Text txtPanelRta;


    // Start is called before the first frame update
    void Start()
    {
        numerodbolas = Random.Range(0, 5);
        bola.SetActive(false);
        for (int i = 0; i < numerodbolas; i++)
        {
            spawnerBolasScript.CloneBola();

        }
        Debug.Log(numerodbolas + 1);

    }

    public void CompararResultados()
    {
        if (inputNumero.text == "")
        {
            // mostrar en panel “Debes ingresar un resultado” 
            txtPanelRta.text = "Debes ingresar un resultado";


        }

        else if (int.Parse(inputNumero.text) == (numerodbolas + 1))
        {
            txtPanelRta.text = "Es correcto, felicitaciones!";
            // mostrar en el panel "Es correcto, felicitaciones!"
        }
        else
        {
            // mostrar en el panel "Es incorrecto."
            txtPanelRta.text = "Es incorrecto.";
        }
             
    }
    
    
        

}
 
