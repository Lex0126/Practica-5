using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Susto : MonoBehaviour
{
   public GameObject susto;

    private void OnCollisionEnter(Collision other){
        if (other.gameObject.tag=="Player"){
            Instantiate(susto);
        }
    }
   
}
