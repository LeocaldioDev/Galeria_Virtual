using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{

  public IEnumerator DesativarPainelAposTempo()
    {
        yield return new WaitForSeconds(20f);
        Debug.Log("ola por aqui!");
        gameObject.SetActive(false);
    }

    void Update(){
      if(gameObject.activeSelf){
        StartCoroutine(DesativarPainelAposTempo());
      }

    }


 }