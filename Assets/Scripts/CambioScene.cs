using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CambioScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_tiempo;
    void Update()
    {
        int escena_actual = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetMouseButtonDown(0))
        {
            // Obtén la escena actual
            

            // Carga la siguiente escena
            SceneManager.LoadScene(escena_actual + 1);
        }
        else if(escena_actual==2){
            texto_tiempo.text = PlayerPrefs.GetInt("Tiempo",0).ToString();

        }
    }
    public void cambioDeEscena(){
         int escena_actual = SceneManager.GetActiveScene().buildIndex;

        // Carga la siguiente escena
        SceneManager.LoadScene(escena_actual + 1);
    }
    public void cambioDeEscena(int Tiempo){
        PlayerPrefs.SetInt("Tiempo",Tiempo);
        cambioDeEscena();
    }
}
