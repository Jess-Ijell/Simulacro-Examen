//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
//Luego indicar cuánto dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float MontoDisponible;
    public float Producto1;
    public float Producto2;
    public float Producto3;

    // Start is called before the first frame update
    void Start()           
    {
        float SumaProductos = Producto1 + Producto2 + Producto3;

        if (SumaProductos > MontoDisponible)
        {
            Debug.Log("La suma de los tres productos supera el monto disponible. Falta un total de $" +(SumaProductos-MontoDisponible));
        }

        else
        {
            Debug.Log("La suma de dinero no supera el monto disponible. Sobra un total de $" +(MontoDisponible-SumaProductos));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
