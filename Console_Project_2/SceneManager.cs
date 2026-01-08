


using System;
using System.Configuration;

public class SceneManager
{
    public Action OnChangeScene;
    private Scene _current;
    public Scene Current
    {
        get => _current;
        private set
        {
            if (_current == value) return;
            _current = value;
            OnChangeScene?.Invoke();
        }
    }

    private Dictionary<string, Scene> _scenes = new Dictionary<string, Scene>();
    
    public void AddScene(string key, Scene scene)
    {
        if (_scenes.ContainsKey(key)) return;

        _scenes.Add(key, scene);
    }
}
