using UnityEngine;
using TMPro;

public class LocalizedText : MonoBehaviour
{
    [SerializeField] public string key;
    private TextMeshProUGUI textComponent;

    private void Start()
    {
        UpdateText();
    }

    private void Awake()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        if (textComponent == null)
        {
            return;
        }

        if (LocalizationManager.Instance != null)
        {
            UpdateText();
        }
        else
        {
        }
    }

    public void UpdateText()
    {
        if (textComponent != null && LocalizationManager.Instance != null)
        {
            string localizedValue = LocalizationManager.Instance.GetLocalizedValue(key);
            textComponent.text = localizedValue;
        }
        else
        {
        }
    }
}
