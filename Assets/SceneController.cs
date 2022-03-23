using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{ 
    public static SceneController instance;
    private void Awake()
    {
        if(SceneController.instance == null){
            
          SceneController.instance = this;
          DontDestroyOnLoad(gameObject);

        } else {

            Destroy(gameObject);

        }
         
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J)){
            setSceneZero();
        }

        if(Input.GetKeyDown(KeyCode.K)){
            setSceneOne();
        }
    }
 
    
    public static void setSceneZero()
    {
        SceneManager.LoadScene(0);
    }

    public static void setSceneOne()
    {
        SceneManager.LoadScene(1);
    }

}
