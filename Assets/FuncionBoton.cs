using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuncionBoton : MonoBehaviour
{
    public GameObject panel;

    public void BotonRtaOn()
    {
        panel.SetActive(true);
    }
    public void BotonRtaOff()
    {
        panel.SetActive(false);
    }

}
