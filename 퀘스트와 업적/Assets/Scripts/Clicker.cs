using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour, Subject
{
    List<Observer> _Observers = new List<Observer>();

    public List<Observer> Observers => _Observers;

    public void Notify(Subject subject, Event e)
    {
        foreach (var observer in Observers)
            observer.Notify(subject, e);
    }

    void Start()
    {
        _Observers.Add(new ClickAchieve());
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Notify(this, new ClickEvent());
    }
}
