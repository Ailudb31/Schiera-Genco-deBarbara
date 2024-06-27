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
    private int numeroBolas;
    private int numeroBolasInicial;
    public Text txtPanelRta;
    public Text reiniciarTexto;
    private int oportunidades = 3;
    public GameObject panelRespuesta;

    void Start()
    {
        
        numeroBolas = Random.Range(0, 5);
        numeroBolasInicial = numeroBolas;
        bola.SetActive(false);

        StartCoroutine(CaidaBolasConEspera());

        //for (int i = 0; i < numeroBolas; i++)
        //{
        //    spawnerBolasScript.CloneBola();
        //}
        //txtPanelRta.text = "";
        //Debug.Log(numeroBolas + 1);

        
    }

    public void CompararResultados()
    {
        if (inputNumero.text == "")
        {
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Debes ingresar un resultado";
        }
       
        else if (int.Parse(inputNumero.text) == (numeroBolas + 1))
        {
            reiniciarTexto.text = "Reiniciar el desafio";
            txtPanelRta.text = "Es correcto, felicitaciones!";
        }
        else
        {
            oportunidades--;
            if (oportunidades > 0)
            {
                reiniciarTexto.text = "Volver a intentarlo (" + oportunidades + " oportunidades restantes)";
                txtPanelRta.text = "Es incorrecto. Intenta de nuevo.";
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                txtPanelRta.text = "Has perdido todas las oportunidades. Reiniciando... (" + numeroBolasInicial + " bolas)";
            }
        }
    }

    public void ReiniciarJuego()
    {
        //Destroy TODO LO QUE ESTE TOCANDO EL PANEL 
        panelRespuesta.SetActive(false);
        StartCoroutine(CaidaBolasConEspera());
    }

    public void SeleccionarJuego()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }

    IEnumerator CaidaBolasConEspera()
    {

        for (int i = 0; i < numeroBolas; i++)
        {
            spawnerBolasScript.CloneBola();
        }
        txtPanelRta.text = "";
        Debug.Log(numeroBolas + 1);

        yield return new WaitForSeconds(0.5f);
    }
    
}
 
