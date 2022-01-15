using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptsButton : MonoBehaviour
{
    //MasterSceen
    public void StarTheGame() 
    {
        SceneManager.LoadScene(0);
    }

    //Village
    public void Village()
    {
        SceneManager.LoadScene(1); 
    }
    //town
    public void Town()
    {
        SceneManager.LoadScene(2);
    }
    //city
    public void City()
    {
        SceneManager.LoadScene(3);
    }
}

    
