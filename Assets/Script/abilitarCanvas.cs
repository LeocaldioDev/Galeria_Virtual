using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abilitarCanvas : MonoBehaviour
{
    public GameObject canvas;

    
    private void OnDisable()
    {
       canvas.SetActive(true);
        
    }
}
