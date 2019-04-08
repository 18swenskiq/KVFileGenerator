KV Generator auto installer setup. KV Generator made by Squidski, Installer made by JamDoggie. Licensed MIT 2019. https://github.com/18swenskiq/KVFileGenerator/

==================================================================================================================================================================
USAGE INSTRUCTIONS
==================================================================================================================================================================

1. Run AutoInstaller.exe
2. Create a 's_kvfile' point entity in your level
3. Choose your desired factions in the properties of the entity.
4. Open the compile menu (F9) and make sure you're on 'Expert Mode'. Go to the SKV_Auto compile preset. Make sure the only option is checked (starts with $exedir) and Press "Go!".
5. Your .kv file should now be generated.

If any issues come up, message Squidski#9545 on Discord.
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
