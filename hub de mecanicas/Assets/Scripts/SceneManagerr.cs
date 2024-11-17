using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerr : MonoBehaviour
{
    #region variables
    [Header("variables")]

    [SerializeField] string moveScene;
    [SerializeField] string jumpScene;
#endregion

#region LoadScenes
    public void MoveSceneLoad() 
    {
        SceneManager.LoadScene(moveScene);
    }
    public void JumpSceneLoad() 
    {
        SceneManager.LoadScene(jumpScene);
    }
 #endregion   
}
