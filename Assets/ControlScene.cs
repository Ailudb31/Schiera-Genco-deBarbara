using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlScene : MonoBehaviour
{
    public InputField inputNumero;
    public GameObject BolaPrefab;
    public Spawnerbolas_segundo spawnerBolasScript;
    private int numeroBolas;
    public Text txtPanelRta;
    public Text reiniciarTexto;
    public GameObject panelRespuesta;

    void Start()
    {
        ReiniciarJuego();
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
            StartCoroutine(ReiniciarEscena());
        }
        else
        {
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Es incorrecto. Intenta de nuevo.";
        }
    }

    IEnumerator ReiniciarEscena()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReiniciarJuego()
    {
        numeroBolas = Random.Range(0, 6);
        BolaPrefab.SetActive(false);

        GameObject[] clones = GameObject.FindGameObjectsWithTag("BolaClone");
        foreach (GameObject clone in clones)
        {
            Destroy(clone);
        }

        for (int i = 0; i < numeroBolas; i++)
        {
            spawnerBolasScript.CloneBola();
        }
        txtPanelRta.text = "";
        Debug.Log(numeroBolas + 1);
        panelRespuesta.SetActive(false);
    }

    public void VolverIntentar() 
    { 
        panelRespuesta.SetActive(false); 
    }


    public void SeleccionarJuego()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }
}

