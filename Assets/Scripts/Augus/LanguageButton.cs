using UnityEngine;

public class LanguageButton : MonoBehaviour
{
    public void SetSpanish()
    {
        LocalizationManager.Instance.SetLanguage("es"); // Cambia a español
    }

    public void SetEnglish()
    {
        LocalizationManager.Instance.SetLanguage("en"); // Cambia a inglés
    }
}
