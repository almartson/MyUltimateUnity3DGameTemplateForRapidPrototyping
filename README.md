# MyUltimateUnity3DGameTemplateForRapidPrototyping
## What is this Project?

It is the union of 3 previously published project templates, in a single Template ready to be used and filled with relevant game logic:


##### 1- UnityMainMenuTemplate 
[ https://github.com/almartson/UnityMainMenuTemplate ]

This project contains a Main Menu, with good programming practices in Unity3D, such as: starting the App from an empty Scene that contains objects with a Script that executes the DontDestroyOnLoad() command, so that these objects remain constant throughout all the Game Scenes. The constant GameObjects contain both the MainCamera and the Game Controller components (GameManager.cs Script, please read point (2) below).


#####  2- MyUnity3DGameTemplateForGameJam 
[ https://github.com/almartson/MyUnity3DGameTemplateForGameJam ]

It has a Game Manager Script (Class) based on 'Switch - Case' with ENUM game states. I extended it to take into account the States of the Game in the Menus.


#####  3- OneThousandCustomUpdateCalls
[ https://github.com/almartson/OneThousandCustomUpdateCalls ]

The possibility of adding a Great Code Optimization proposed by Valentin Simonov, of Unity Technologies, in his publication in December 23, 2015: <strong>'10000 Update() calls'</strong> (https://blogs.unity3d.com/en/2015/12/23/1k-update-calls/). The optimization itself is in a separate Scene, and inside a Folder in a path defined as: '\Assets\_Scenes\ThousandUpdateCallsOptimization'. It can be added to the Main Game Scene by reading and understanding the theory behind the blog article.


###### Notes:

* I also added an excellent piece of code from GitHub, to manage Strings with no Garbage Allocations. The Author is someone to be respected because of his talent as a Programmer (Vexe). His Main Project Repo is: https://github.com/vexe/gstring

<strong>You can find an Example using the Scene named: 'GCFreeStringTest'.</strong>

I am using the Library in the Script named: 'ShowSliderValueTMP.cs', to Concat two Strings in the Loading Slider Bar (the 'number' and the '%').

* The Main discussion of this Library is in an Unity Forum: https://forum.unity.com/threads/gstring-gc-free-string-for-unity.338588/

********************************

## How to use it?

1- Download the code and extract the assets carefully inside a new project's Assets folder.

2- Go to: <strong>Build Settings</strong> and 'Add all Scenes' inside the 'Assets\_Scenes\_MyUltimateUnity3DGameTemplate' Folder. The right order is: 

  2.1- Number '0' is 'Scene0Laucher' (this is the empty initial Scene). This Scene creates the Main Camera and the GameManager GameObjects, which will not be destroyed even if you change Scenes with Code inside the Game (thus allowing you to Save Game and Menus State in variables across all the App). <strong>You must start the game from this scene.</strong>

  2.2- Number '1' is 'Scene1MainMenu' (this is the Scene featuring the 'Main Menu' GUI).

  2.3- Number '2' is 'Scene2SubMenu' (this Scene is a Sub-Menu, added as an Example. You could even replace it with: your Main Game Scene, with you 'Level_1' Scene, etc.).


I really hope you find it useful.
If someone manages to make an interesting and fun video game from this code, let me know, because that would make my day.

Peace.

AlMartson



********************************

MIT License

Copyright (c) 2020 AlMartson

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
© 2020 GitHub, Inc.

