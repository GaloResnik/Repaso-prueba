//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public float precio1, precio2, precio3, total;
    // Start is called before the first frame update
    void Start()
    {
        float preciot = precio1 + precio2 + precio3;
        if (preciot > total)
        {
            Debug.Log("Te faltan " + (total - preciot) + " pesos");
        }
        else
        {
            Debug.Log("Te sobran " + (total - preciot) + " pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
