using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
{
    public List<Observer> Observers { get; }

    public void Notify(Subject subject, Event e);
}