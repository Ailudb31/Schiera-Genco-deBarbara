using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject bola;
    public Spawnerbolas_segundo spawnerBolasScript;
    private int numerodbolas;
    public Text txtPanelRta;

    public Text reiniciarTexto;

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
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Debes ingresar un resultado";
        }

        else if (int.Parse(inputNumero.text) == (numerodbolas + 1))
        {
            reiniciarTexto.text = "Reiniciar el desafio";
            txtPanelRta.text = "Es correcto, felicitaciones!";
           
        }
        else
        {
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Es incorrecto.";
        }
             
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SeleccionarJuego()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }

}
 
