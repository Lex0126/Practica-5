using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObj : MonoBehaviour
{
    // Start is called before the first frame update
    public float tiempo;
    void Start()
    {
        Destroy(gameObject,tiempo);
    }

}
