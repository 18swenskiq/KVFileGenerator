KV Generator auto installer setup. KV Generator made by Squidski, Installer made by JamDoggie. Licensed MIT 2019. https://github.com/18swenskiq/KVFileGenerator/

==================================================================================================================================================================
MANUAL INSTALL INSTRUCTIONS
==================================================================================================================================================================

If for whatever reason the installer does not work for you, here is how to manually install:

move FileGenerator.exe from bin to Counter Strike: Global Offensive/bin
move kvfilegen.fgd from bin to Counter Strike: Global Offensive/bin
move s_kvfile.vmt and s_kvfile.vtf to Counter Strike: Global Offensive/csgo/materials/s_kvfile/editor

Open hammer, then go to Tools>Options then next to "Game Data files" click add, then browse to kvfilegen.fgd and open it.

==================================================================================================================================================================
MANUALLY CREATING THE COMPILE CONFIG IN HAMMER
==================================================================================================================================================================

Open hammer, then hit f9 or alternatively open the compile window. Click the expert option, then next to configurations clicked edit, then click new, name it whatever you want and then next to 
compile/run commands click "new" and then in the command textbox add "$exedir/bin/skv/FileGenerator.exe", then in the parameters textbox add "$gamedir $path\$file".