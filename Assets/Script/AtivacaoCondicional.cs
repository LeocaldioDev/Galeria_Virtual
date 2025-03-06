using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivacaoCondicional : MonoBehaviour
{
    public GameObject objeto1;

    void Start()
    {
        gameObject.SetActive(false);
    }

    public void HabilitarTela()
    {
        if (!objeto1.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }

    }

    void Update()
    {
        if (objeto1.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }

    }
}