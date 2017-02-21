using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour {


    // Update is called once per frame
    public void StartScene(string game)
    {
        Debug.Log("Button Pressed");
        SceneManager.LoadScene(game);
    }
	
}
