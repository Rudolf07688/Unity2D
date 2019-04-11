using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string my_name = "Rudolf";
        // string hello_line = string.Format("Hello {0}!", my_name);

        print(string.Format("Hello {0}!", my_name));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
