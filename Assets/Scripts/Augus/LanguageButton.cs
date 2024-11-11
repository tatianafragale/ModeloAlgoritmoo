using UnityEngine;

public class LanguageButton : MonoBehaviour
{
    public void SetSpanish()
    {
        LocalizationManager.Instance.SetLanguage("es"); // Cambia a espa�ol
    }

    public void SetEnglish()
    {
        LocalizationManager.Instance.SetLanguage("en"); // Cambia a ingl�s
    }
}
