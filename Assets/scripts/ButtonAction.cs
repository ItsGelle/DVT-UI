using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour {


    public void OnClickActionPlus()
    {
        if(transform.localScale.x <= 1.5)
        {
            transform.localScale += new Vector3(0.1f, 0, 0);
       
        }
    }

}
