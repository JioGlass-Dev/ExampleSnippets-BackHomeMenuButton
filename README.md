# Back, Home and Menu Button
Back, Home and Menu button implementation of JMRSDK

## Scripts 

### `ButtonManager.cs`
Shows example of accessing callbacks called during back, home and menu button press.</br>
- Interfaces to implement button funtionalities
```cs
public class ButtonManager : MonoBehaviour, IBackHandler, IHomeHandler, IMenuHandler
```

## How to use?
1. Download and unzip this project.
2. Open the project using Unity Hub.
3. Download and import the latest version of JMRSDK package.
4. Open and play the ControllerOrientation scene from Assets/Scenes folder.
