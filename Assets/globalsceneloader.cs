using UnityEngine;

using UnityEngine.SceneManagement;
public class globalsceneloader : MonoBehaviour
{
    public void SwichToLogin()
    {
         SceneManager.LoadScene("Login"); // login
    }
}
