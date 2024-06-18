using UnityEngine;
using UnityEngine.UI;

public class UltraBundleUI : MonoBehaviour
{
    public Sprite backgroundSprite;
    public Sprite chestSprite;
    public Sprite[] iconSprites;
    public string priceText = "0.99 USD";

    void Start()
    {
        // Create and set up UltraBundleContainer
        GameObject ultraBundleContainer = new GameObject("UltraBundleContainer");
        ultraBundleContainer.transform.SetParent(transform);
        VerticalLayoutGroup verticalLayout = ultraBundleContainer.AddComponent<VerticalLayoutGroup>();

        // Create and set up Background
        GameObject background = new GameObject("Background");
        background.transform.SetParent(ultraBundleContainer.transform);
        Image backgroundImage = background.AddComponent<Image>();
        backgroundImage.sprite = backgroundSprite;

        // Create and set up UltraBundleContent
        GameObject ultraBundleContent = new GameObject("UltraBundleContent");
        ultraBundleContent.transform.SetParent(ultraBundleContainer.transform);
        HorizontalLayoutGroup horizontalLayout = ultraBundleContent.AddComponent<HorizontalLayoutGroup>();

        // Create and set up IconContainer
        GameObject iconContainer = new GameObject("IconContainer");
        iconContainer.transform.SetParent(ultraBundleContent.transform);
        VerticalLayoutGroup iconLayout = iconContainer.AddComponent<VerticalLayoutGroup>();

        // Add icons to IconContainer
        foreach (var iconSprite in iconSprites)
        {
            GameObject icon = new GameObject("Icon");
            icon.transform.SetParent(iconContainer.transform);
            Image iconImage = icon.AddComponent<Image>();
            iconImage.sprite = iconSprite;
        }

        // Create and set up ChestImage
        GameObject chestImageObject = new GameObject("ChestImage");
        chestImageObject.transform.SetParent(ultraBundleContent.transform);
        Image chestImage = chestImageObject.AddComponent<Image>();
        chestImage.sprite = chestSprite;

        // Create and set up PriceButton
        GameObject priceButtonObject = new GameObject("PriceButton");
        priceButtonObject.transform.SetParent(ultraBundleContent.transform);
        Button priceButton = priceButtonObject.AddComponent<Button>();
        Image buttonImage = priceButtonObject.AddComponent<Image>();
        buttonImage.color = Color.green; // Set your desired button color

        // Create and set up PriceText
        GameObject priceTextObject = new GameObject("PriceText");
        priceTextObject.transform.SetParent(priceButtonObject.transform);
        Text priceTextComponent = priceTextObject.AddComponent<Text>();
        priceTextComponent.text = priceText;
        priceTextComponent.alignment = TextAnchor.MiddleCenter;
        priceTextComponent.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf"); // Set your desired font
        priceTextComponent.color = Color.white; // Set your desired text color
    }
}
