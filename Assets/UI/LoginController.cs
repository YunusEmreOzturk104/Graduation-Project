using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager'� kullanmak i�in gerekli

public class LoginController : MonoBehaviour
{
    // Bu fonksiyon sahne ge�i�ini ger�ekle�tirir
    public void LoadScene1()
    {
        SceneManager.LoadScene("Scene1");
    }
}
