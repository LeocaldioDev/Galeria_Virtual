using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterarAoDesativar : MonoBehaviour
{
    public GameObject objetoComNovoMaterial;
    public Material novoMaterial;
    public GameObject objetoParaDesativar;

    void OnDisable()
    {
        Renderer renderer = objetoComNovoMaterial.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = novoMaterial;
        }

        objetoParaDesativar.SetActive(false);
    }
}
