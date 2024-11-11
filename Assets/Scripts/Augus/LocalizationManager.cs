using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class LocalizationManager : MonoBehaviour
{
    public static LocalizationManager Instance;

    private Dictionary<string, Dictionary<string, string>> localizedText;
    private string currentLanguage = "en";

    private void Start()
    {
        SetLanguage("en"); // Establece inglés como idioma predeterminado
    }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadLocalizedText();
        SetLanguage("en"); // Establece inglés como idioma predeterminado
    }


    private void LoadLocalizedText()
    {
        localizedText = new Dictionary<string, Dictionary<string, string>>();

        TextAsset jsonFile = Resources.Load<TextAsset>("translations");
        if (jsonFile != null)
        {
            LocalizationData data = JsonUtility.FromJson<LocalizationData>(jsonFile.text);

            foreach (var item in data.items)
            {
                if (!localizedText.ContainsKey(item.language))
                {
                    localizedText[item.language] = new Dictionary<string, string>();
                }
                localizedText[item.language][item.key] = item.value;
            }
        }
        else
        {
        }
    }


    public void SetLanguage(string languageCode)
    {
        currentLanguage = languageCode;
        UpdateAllTexts();
    }



    public string GetLocalizedValue(string key)
    {
        if (localizedText.ContainsKey(currentLanguage) && localizedText[currentLanguage].ContainsKey(key))
        {
            return localizedText[currentLanguage][key];
        }
        return key; // Devuelve la clave si no encuentra el valor traducido
    }


    private void UpdateAllTexts()
    {
        foreach (LocalizedText text in FindObjectsOfType<LocalizedText>())
        {
            text.UpdateText();
        }
    }

}

[System.Serializable]
public class LocalizationData
{
    public List<LocalizationItem> items;
}

[System.Serializable]
public class LocalizationItem
{
    public string language;
    public string key;
    public string value;
}
