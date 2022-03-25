# AffenCode Service Locator

Implementation of the Service Locator pattern.

## How to

```csharp
using AffenCode.ServiceLocator;
```

```csharp
public class GameStateData
{
    public int Test;
}

private void Start()
{
    Service<GameStateData>().Set(new GameStateData);
    Service<GameStateData>().Get().Test = 100;
}
```