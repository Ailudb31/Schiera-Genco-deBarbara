using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject BolaPrefab;
    public Spawnerbolas_segundo spawnerBolasScript;
    private int numeroBolas;
    private int numeroBolasInicial;
    public Text txtPanelRta;
    public Text reiniciarTexto;
    public GameObject panelRespuesta;

    void Start()
    {
        numeroBolas = Random.Range(0, 6);
        //numeroBolasInicial = numeroBolas;
        BolaPrefab.SetActive(false);

        for (int i = 0; i < numeroBolas; i++)
        {
            spawnerBolasScript.CloneBola();
        }
        txtPanelRta.text = "";
        Debug.Log(numeroBolas + 1);

        //StartCoroutine(CaidaBolasConEspera());        
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
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Es incorrecto. Intenta de nuevo.";
        }
    }

    public void ReiniciarJuego()
    {
        GameObject[] clones = GameObject.FindGameObjectsWithTag(BolaPrefab.name + "(Clone)");
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }
        panelRespuesta.SetActive(false);
        //StartCoroutine(CaidaBolasConEspera());
        Start();

    }

    public void SeleccionarJuego()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }

    //IEnumerator CaidaBolasConEspera()
    //{
    //    for (int i = 0; i < numeroBolas; i++)
    //    {
    //        spawnerBolasScript.CloneBola();
    //    }
    //    txtPanelRta.text = "";
    //    Debug.Log(numeroBolas + 1);
    //    yield return new WaitForSeconds(1f);
    //}
   
  
}


