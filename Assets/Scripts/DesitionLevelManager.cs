using UnityEngine;
using UnityEngine.SceneManagment;

public class DesitionLevelManager : MonoBehaviour
{
    private float startdelay = 2.114f;
    
    void toNextDesition2
    {
        SceneManager.LoadScene(SceneManager.getActiveScene.buildIndex() + 2);
    }
    void toNextDesition3
    {
        SceneManager.LoadScene(SceneManager.getActiveScene.buildIndex() + 1);
    }

    public void executestuff1
    {
        Invoke("toNextDesition", startdelay);
    }
    public void executestuff2
    {
        Invoke("toNextDesition2", startdelay);
    }
    
}
