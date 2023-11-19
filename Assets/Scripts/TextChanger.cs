using UnityEngine;
using UnityEngine.UI;
using DG.Tweening; 

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        _text.DOText("���� �������.", 3).OnComplete(CallBack1);
    }

    private void CallBack1() 
    {
        _text.DOText(" ���� ��������.", 3).SetRelative().OnComplete(CallBack2); ;
    }

    private void CallBack2()
    {
        _text.DOText("���� �������.", 3, true, ScrambleMode.All);
    }
}
