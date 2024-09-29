using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlTiempo : MonoBehaviour
{
     [SerializeField]CambioScene auxiliar;
    
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        contador_segundos =0;
        Tiempo.text = contador_segundos.ToString();

        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator corrutinaTiempo(){
        while (contador_segundos<200){
            Tiempo.text = contador_segundos++.ToString();
            yield return new WaitForSeconds(1.00f);
    
        }
        auxiliar.cambioDeEscena();

    }
}
