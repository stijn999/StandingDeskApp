using UnityEngine;

public class Move : MonoBehaviour
{
    private RectTransform rectTransform;
    public Vector2 InactivePos = new Vector2(0f, 0f);
    public Vector2 ActivePos = new Vector2(0f, 0f);

    public bool isActive = false;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void TogglePosition()
    {
        if (isActive)
        {
            rectTransform.anchoredPosition = InactivePos;
        }
        else
        {
            rectTransform.anchoredPosition = ActivePos;
        }

        isActive = !isActive;
    }
}