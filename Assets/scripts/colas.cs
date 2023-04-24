using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colas : MonoBehaviour
{

    Queue<int> colaOrigin;
    // Start is called before the first frame update
    void Start()
    {
        colaOrigin = new Queue<int>();
        colaOrigin.Enqueue(50);
        colaOrigin.Enqueue(80);
        colaOrigin.Enqueue(1);
        colaOrigin.Enqueue(9);


        OrdenarCola();
    }

    void OrdenarCola()
    {
        Queue<int> cola1, cola2;
        cola1 = new Queue<int>();
        cola2 = new Queue<int>();


        while (colaOrigin.Count > 0)
        {
            int numero = colaOrigin.Dequeue();
            cola1.Enqueue(numero);
        }

        while (cola1.Count > 0)
        {
            int aux = cola1.Dequeue();
            while (cola1.Count > 0)
            {
                int val = cola1.Dequeue();

                if (val < aux)
                {
                    cola2.Enqueue(aux);
                    aux = val;
                }
                else
                {
                    cola2.Enqueue(val);
                }
            }

            colaOrigin.Enqueue(aux);


            //swap
            Queue<int> colaAux = cola1;
            cola1 = cola2;
            cola2 = colaAux;
        }
    }
}
