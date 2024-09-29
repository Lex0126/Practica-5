using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject HiddenObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        HiddenObject.GetComponent<Renderer>().enabled = true;

    }
    void OnTriggerExit(Collider other){
        HiddenObject.GetComponent<Renderer>().enabled = false;

    }
}
