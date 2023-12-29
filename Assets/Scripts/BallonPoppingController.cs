using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonPoppingController : MonoBehaviour
{

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        
    }
}
