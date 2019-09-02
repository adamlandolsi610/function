using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatriceFunction : MonoBehaviour
{
    public void Adam(int A, int B)
    {
        int C = A + B;
        Debug.Log("elnetija=" + C + " jame3");
        int D = A - B;
        Debug.Log("eljaweb howa " + D + " tar7");
        int E = A * B;
        Debug.Log("dharb " + E);
        int F = A + B;
        Debug.Log("9isma " + F);
        int G = A % B;
        Debug.Log("be9i " + G);
    }


    
    void Start()
    {
            Adam(60, 40);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 }
