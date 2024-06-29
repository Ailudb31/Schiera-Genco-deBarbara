﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor.Experimental.UIElements.GraphView;


public class ControlScene : MonoBehaviour
{
    public Vector3 newPosition;
    public float minX ;
    public float maxX;
    public float freq;
    public bool autoGenerate;
    
    public GameObject objetoPrefab;
    public InputField inputNumero;
    public Text txtPanelRta;
    public Text reiniciarTexto;
    public GameObject panelRespuesta;
    private int numeroBolas;


    void Start()
    {
        numeroBolas = Random.Range(0, 6);
        objetoPrefab.SetActive(false);

        for (int i = 0; i <= (numeroBolas); i++)
        {
            Invoke(nameof(CloneBola), freq);
            freq++;
        }

        txtPanelRta.text = "";
        Debug.Log(numeroBolas + 1);
        panelRespuesta.SetActive(false);
    }

    public void CompararResultados()
    {
        if (inputNumero.text == "")
        {
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Debes ingresar un resultado.";
        }
        else if (int.Parse(inputNumero.text) == (numeroBolas + 1))
        {
            reiniciarTexto.text = "Reiniciar el desafio";
            txtPanelRta.text = "Es correcto!";
        }
        else
        {
            reiniciarTexto.text = "Volver a intentarlo";
            txtPanelRta.text = "Es incorrecto.       Intenta de nuevo.";
        }
    }

    public void VolverIntentar()
    {
        if (reiniciarTexto.text == "Volver a intentarlo")
        {
            GameObject[] clones = GameObject.FindGameObjectsWithTag("BolaClone");
            foreach (GameObject clone in clones)
            {
                Destroy(clone);
            }

            Start();
        }
        
        else
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void SeleccionarJuego()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }

    public void CloneBola()
    {
        objetoPrefab.SetActive(true);
        float randomX = Random.Range(minX, maxX);
        newPosition = new Vector3(randomX, newPosition.y, newPosition.z);
        GameObject clone = Instantiate(objetoPrefab, newPosition, Quaternion.Euler(-90, 0, 0));
        clone.tag = "BolaClone";
    }
}

