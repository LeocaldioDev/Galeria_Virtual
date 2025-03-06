using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterarAoAtivar : MonoBehaviour
{
    public GameObject objetoComMaterialOriginal;
    public Material materialOriginal;
    public GameObject objetoParaAtivar;

    void OnDisable()
    {
        Renderer renderer = objetoComMaterialOriginal.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = materialOriginal;
        }

        objetoParaAtivar.SetActive(true);
    }
}