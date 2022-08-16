using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntajes : MonoBehaviour
{
    [SerializeField] int[] arrayDePuntajes = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es " + ObtenerMayorPuntaje());
        Debug.Log("El índice del nivel con menor puntaje es " + ObtenerNivelDeMenorPuntaje());
        Debug.Log("El promedio es " + ObtenerPuntajePromedio());
    }
    
    int ObtenerMayorPuntaje()
    {
        int nroMayor = 0;
        //Devuelve el puntaje más alto de los 10 almacenados

        foreach(int num in arrayDePuntajes)
        {
            if (num>nroMayor)
            {
                nroMayor = num;
            }
        }

        return nroMayor;
    }

    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivel = 0;
        int menorPuntaje = arrayDePuntajes[0];
        //Devuelve el índice que tiene el menor puntaje (si hay más de un nivel con puntaje mínimo idéntico, devolver el primero encontrado)

        for(int i =1;i<arrayDePuntajes.Length;i++)
        {
            if (arrayDePuntajes[i] < menorPuntaje)
            {
                indiceNivel = i;
                menorPuntaje = arrayDePuntajes[i];
            }
        }

        return indiceNivel;
    }

    float ObtenerPuntajePromedio()
    {
        float promedio = 0;
    

        foreach (int num in arrayDePuntajes)
        {
            float total = num;
            promedio = num / 10;
        }
        
        return promedio;
    }
}
