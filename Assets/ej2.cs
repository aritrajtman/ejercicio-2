using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ej2 : MonoBehaviour
{
    public Text MiTexto;
    public int edadUsuario;
    
    // Start is called before the first frame update
    void Start()
    {
        if (edadUsuario >= 18)
        {
            MiTexto.text = "El usuario es mayor de edad";
            Debug.Log("El usuario es mayor de edad");
        }
        else
        {
            MiTexto.text = "el usuario es menor de edad";
            Debug.Log("el usuario es menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
