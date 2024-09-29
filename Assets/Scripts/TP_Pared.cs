using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Pared : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform ubi_spawn;
    GameObject Pared;
    private void Awake(){
        Pared = GameObject.Find("Pared");
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            Pared.transform.position= ubi_spawn.position;
        }
    }
   

    
    
}
