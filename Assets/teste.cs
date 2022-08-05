using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class teste : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Teste((56,"porra"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Teste((int leo, string leo2) request)
    {
        print(request.leo2);
    }
}
