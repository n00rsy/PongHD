using UnityEngine;
using System.Collections;

public class OtherWallControl : MonoBehaviour
{

    public AIControl other;


    void OnCollisionEnter2D()
    {
        Debug.Log("ball hit paddle");
        other.PredictWall();


    }
}