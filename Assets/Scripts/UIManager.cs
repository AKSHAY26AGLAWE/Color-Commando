using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public RectTransform redButton;
    public RectTransform blueButton;
    public RectTransform yellowButton;

    public bool IsTouchOverUIButton(Vector2 touchPosition)
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(redButton, touchPosition))
            return true;
        if (RectTransformUtility.RectangleContainsScreenPoint(blueButton, touchPosition))
            return true;
        if (RectTransformUtility.RectangleContainsScreenPoint(yellowButton, touchPosition))
            return true;

        return false;
    }
}
