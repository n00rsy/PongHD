using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestRightWall : MonoBehaviour
{

    public AIControl other;

    void OnCollisionEnter2D()
    {

        Debug.Log("hit sides trigger");
        SceneManager.LoadScene("Win");
    }
}