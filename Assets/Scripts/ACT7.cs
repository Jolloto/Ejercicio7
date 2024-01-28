using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random= UnityEngine.Random;

public class ACT7 : MonoBehaviour
{
    [SerializeField] private string[] letraArray = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};
    private string dondeestalaA = "Donde estan los tios";
    

    void Start()
    { 
        ACT1();
        ACT2();
        ACT3();
        ACT4();
        ACT5();
        
    
    }

    private void ACT1()
    {
        int suma = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
         }

         Debug.Log("Sum of even numbers between 1 and 100: " + suma);
    }

    private void ACT2()
    {
        int vocalCount = 0;
        for (int i = 0; i < letraArray.Length; i++) 
        {
            Debug.Log($"{letraArray[i]}");


            if (letraArray[i] == "a" || letraArray[i] == "e" || letraArray[i] == "i" || letraArray[i] == "o" || letraArray[i] == "u");
            {
                vocalCount++;
            }
        }
    }

    private void ACT3()
    {
         for (int i = 10; i > 0; i--) 
        { 
            Debug.Log(i+  "  green bottles\nHanging on the wall\n  green bottles\nHanging on the wall\nAnd if one green bottle\nShould accidentally fall\nThere’ll be" +(i-1)+ "green bottles\nHanging on the wall ");
        }
    }

    void ACT4()
    {
        
        int sum = 0;
        int LosCinquillos = 0;

        while (sum < 100)
        {
            int NumeroAleatorio = Random.Range(1, 11);
            Debug.Log("Numero Aleatorio: " + NumeroAleatorio);

            if (NumeroAleatorio == 5)
            {
                LosCinquillos++;
            }

            sum += NumeroAleatorio;
        }

        Debug.Log("\nSuma de todos los numeros: " + sum);
        Debug.Log("Numeros 5 sacados: " + LosCinquillos);
    }

    void ACT5()
    {
        for (int i = 0; i < dondeestalaA.Length; i++)
        {
            if (dondeestalaA[i] == 'a')
            {
                break;
            }
             else
            {
                Debug.Log(dondeestalaA[i]);
            }
        }
       
    }

}


