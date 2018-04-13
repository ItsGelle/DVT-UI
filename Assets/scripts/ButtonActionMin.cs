using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActionMin : MonoBehaviour
{

    public void OnClickAction()
    {
        if(transform.localScale.x >= 0)
        {
            transform.localScale -= new Vector3(0.1f, 0, 0);
  
        }
    }
    
}
