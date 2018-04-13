using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : MonoBehaviour {


    public void OnClickAction()
    {
        if (transform.localScale.x <= 0.9)
        {
            transform.localScale += new Vector3(0.1f, 0, 0);
        }
    }

}
