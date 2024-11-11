using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    // Array para almacenar los GameObjects de las pantallas
    [SerializeField] private GameObject[] screens;

    // M�todo para mostrar una pantalla espec�fica basada en el tipo
    public void ShowScreen(ScreenType screenType)
    {
        HideAllScreens();
        screens[(int)screenType].SetActive(true);
    }

    // M�todo para ocultar todas las pantallas antes de mostrar una nueva
    private void HideAllScreens()
    {
        foreach (GameObject screen in screens)
        {
            screen.SetActive(false);
        }
    }

    // M�todos para manejar el flujo del juego
    public void StartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1; // Asegura que el tiempo est� en escala normal
    }

    public void ShowOptions()
    {
        ShowScreen(ScreenType.Options); // Activa el layout de opciones
    }

    public void PauseGame()
    {
        ShowScreen(ScreenType.Pause);
        Time.timeScale = 0; // Pausa el juego
    }

    public void ResumeGame()
    {
        ShowScreen(ScreenType.Gameplay);
        Time.timeScale = 1; // Reanuda el juego
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        ShowScreen(ScreenType.GameOver);
        Time.timeScale = 0; 
    }
    public void Victory()
    {
        ShowScreen(ScreenType.EndScreen);
        Time.timeScale = 0; 
    }
}
