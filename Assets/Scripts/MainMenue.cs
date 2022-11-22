using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenue : MonoBehaviour
{
    //start Button
    public void Level1()
    {
        SceneManager.LoadScene(1);

    }
    //Exit button
    public void Exit()
    {

        Application.Quit(); 
    }
}
