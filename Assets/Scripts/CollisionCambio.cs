using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCambio : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] CambioScene aux;
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag =="Player"){
            aux.cambioDeEscena();
        }
    } 
}
