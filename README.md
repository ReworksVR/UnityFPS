# UnityFPS
------------------
# How It Works
------------------
Runs every frame using Update().
Measures how long the last frame took with Time.unscaledDeltaTime.
Smooths the value so the FPS doesn't jump around constantly.
Calculates FPS by doing 1 ÷ frame time.
Displays the FPS in a TextMeshPro text object.
Changes the text color:
🟢 Green = Good FPS
🟡 Yellow = Okay FPS
🔴 Red = Low FPS
-------------------
# How To Use It 
------------------
Create a TextMeshPro text
In the Hierarchy, right-click → UI → Text - TextMeshPro.
Import TMP Essentials if Unity asks.
Position the text where you want the FPS counter.
Create the script
In the Project window, right-click → Create → C# Script.
Name it FPSCounter.
Open it and paste in the FPS script.
Attach the script
Create an empty GameObject (or use an existing one).
Drag the FPSCounter script onto it.
Assign the text
Select the GameObject with the script.
In the Inspector, you'll see an FPS Text field.
Drag your TextMeshPro object from the Hierarchy into that field.
Play the game
Press Play.
The text will update with your current FPS and automatically change color:
🟢 Green = Good FPS
🟡 Yellow = Okay FPS
🔴 Red = Low FPS
------------------------
# If You Drag the prefab in from the fpsfolder it is set up!
