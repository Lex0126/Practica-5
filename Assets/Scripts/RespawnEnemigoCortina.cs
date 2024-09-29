using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnEnemigoCortina : MonoBehaviour
{
    
    float tiempo_en_trigger;
    float tiempo_para_nuevo_enemigo;

    Transform spawn;

    [SerializeField] List <GameObject>lista_enemigos;

    int contador_enemigo_actual;
    void Awake(){
        spawn =GameObject.Find("Spawn Enemigos").transform;
    }
    void Start()
    {
        tiempo_para_nuevo_enemigo =1;
        contador_enemigo_actual= 0;
    }
    IEnumerator corrutinaSpawn(){
        while(tiempo_en_trigger>tiempo_para_nuevo_enemigo){
                    /// version con corrutina
            lista_enemigos[contador_enemigo_actual].transform.position =spawn.position;
            contador_enemigo_actual++;
            contador_enemigo_actual %= contador_enemigo_actual;
            tiempo_en_trigger =0;
        }
        yield return new WaitForSeconds(tiempo_para_nuevo_enemigo);

    }

    private void OnTriggerStay(Collider other){
        tiempo_en_trigger += Time.deltaTime;
        if(other.gameObject.CompareTag("Player")){
            StartCoroutine("corrutinaSpawn");

        }

    }
}
