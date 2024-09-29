using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform meta;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag =="Player"){
            other.gameObject.transform.position = meta.position;
        }
    } 
}
