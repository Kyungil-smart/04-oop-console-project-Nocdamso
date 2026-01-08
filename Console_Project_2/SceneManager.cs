


using System;
using System.Configuration;

public class SceneManager
{
    private Scene _current;
    public Scene Current
    {
        get => _current;
        set
        {
            _current = value;
            OnChangeScene?.Invoke();
        }
    }

    public Action OnChangeScene;
}
