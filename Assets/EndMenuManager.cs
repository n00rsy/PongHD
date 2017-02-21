using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndMenuManager : MonoBehaviour
{

    public void Clicked(string end)
    {
        SceneManager.LoadScene(end);
    }
}
